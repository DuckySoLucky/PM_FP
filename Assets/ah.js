const { fetch } = require('undici');
const { delay } = require('./util/helperFunctions');
const { parse } = require('prismarine-nbt');
const { items, attributes, armor_attributes, weapon_attributes } = require('../config.json');

async function refreshData() {
    const itemsWithAttributes = initializeNewDataObject();
    item_loop: // Loop through every item fetched.
    for(const item of await getAllItems()) { try {
        // category can be Necklace, Cloak, Belt and Other, type is the actual item name (without reforges and stuff), returns undefined if item is not equipment
        const { category, type: equipmentType } = getEquipmentType(item.name);
        // armorType is undefined if item is not armor
        const armorType = ["Helmet", "Chestplate", "Leggings", "Boots"].find(p => item.name.includes(p));
        for(const attribute of item.attributes) if(attribute.name === 'Mending') attribute.name = 'Vitality'; // Hypixel is fucking shit
        // Check if item is attribute shard and insert it at the correct place
        if(item.name.includes(`Attribute Shard`)) {
            const shards = itemsWithAttributes.shard[item.attributes[0].name][item.attributes[0].level];
            for(let i = 0; i < shards.length - 1; i++) {
                if(item.price < shards[i].price) {
                    shards.splice(i, 0, { id: item.id, price: item.price });
                    continue item_loop;
                }
            }
            shards.push({ id: item.id, price: item.price });
        } else if(armorType) {
            // Check if the bot can handle this armor type
            if(![...items.kuudra_armor, ...items.other_armor].some(element => item.name.includes(element))) continue;
            const category = items.kuudra_armor.find(c => item.name.includes(c)) ? `kuudra_armor` : `other_armor`;
            // the name of the armor set
            const type = items[category].find(t => item.name.includes(t));
            // insert item in the 'double' array if its price is lower than the currently cheapest one
            const lowestAttributeCombination = itemsWithAttributes[category].double[item.attributes[0].name][item.attributes[1].name][armorType][type];
            if(!lowestAttributeCombination || lowestAttributeCombination?.price > item.price) {
                itemsWithAttributes[category].double[item.attributes[0].name][item.attributes[1].name][armorType][type] = { id: item.id, price: item.price, level1: item.attributes[0].level, level2: item.attributes[1].level }
            }
            // insert item at the correct place (for both attributes the item has)
            for(const attribute of item.attributes) {
                const pieces = itemsWithAttributes[category].single[attribute.name][armorType][attribute.level];
                if(pieces.length == 0) pieces.push({ id: item.id, price: item.price });
                else for(let i = 0; i < pieces.length; i++) {
                    if(item.price < pieces[i].price) {
                        pieces.splice(i, 0, { id: item.id, price: item.price });
                        break;
                    } else if(i == pieces.length - 1) {
                        pieces.splice(i + 1, 0, { id: item.id, price: item.price });
                        break;
                    }
                }
            }
        } else if(equipmentType) {
            // add item to the equipment array of this equipment category
            itemsWithAttributes.equipmentType.double[item.attributes[0].name][item.attributes[1].name][category].push(
                { id: item.id, price: item.price, name: equipmentType, level1: item.attributes[0].level, level2: item.attributes[1].level }
            );
            // insert item at the correct place (for both attributes the item has)
            for(const attribute of item.attributes) {
                const pieces = itemsWithAttributes.equipmentType.single[attribute.name][category][attribute.level];
                if(pieces.length == 0) pieces.push({ id: item.id, price: item.price });
                else for(let i = 0; i < pieces.length; i++) {
                    if(item.price < pieces[i].price) {
                        pieces.splice(i, 0, { id: item.id, price: item.price, name: equipmentType });
                        break;
                    } else if(i == pieces.length - 1) {
                        pieces.splice(i + 1, 0, { id: item.id, price: item.price, name: equipmentType });
                        break;
                    }
                }
            }
        } else if(items.weapon.some(element => item.name.includes(element))) {
            // todo
        } else continue;
    } catch(error) { console.log(`Failed to identify ${item.name}: ${error}`); }}
}

async function getAllItems() {
    console.log(`Started fetching AH data.`)
    const newData = [];
    let page = 0; let totalPages = Infinity; let failedRequests = 0;
    while(page < 5 && failedRequests < 20) {
        try {
            const result = await (await fetch(`https://api.hypixel.net/skyblock/auctions?page=${page}`)).json();
            if(!result.success) { await delay(5000); failedRequests++; continue; } // try again 20 times, then stop
            totalPages = result.totalPages; failedRequests = 0; page++;
            for(const item of result.auctions) {
                if(!item) continue; if(!item.bin) continue;
                const nbt = (await parse(Buffer.from(item.item_bytes, 'base64'))).parsed.value.i.value.value[0].tag.value.ExtraAttributes.value;
                if(!nbt.attributes) continue;
                const attributes = [{ name: getAttributeCaseSensitive(Object.keys(nbt.attributes.value)[0]), level: nbt.attributes.value[Object.keys(nbt.attributes.value)[0]].value}];
                if(Object.keys(nbt.attributes.value).length == 2) attributes.push({ name: getAttributeCaseSensitive(Object.keys(nbt.attributes.value)[1]), level: nbt.attributes.value[Object.keys(nbt.attributes.value)[1]].value });
                newData.push({ id: item.uuid, price: item.starting_bid, name: item.item_name, attributes: attributes });
            }
            await delay(100);
        } catch(error) { console.log(`Failed to refresh AH data for page ${page}: ${error}`); }
    }
    console.log(`Done fetching data.`)
    return newData;
}

function getEquipmentType(item_name) {
    for(const category of Object.keys(items.equipmentType)) {
        for(const piece of items.equipmentType[category]) {
            if(category === 'Other' && item_name.includes(piece)) return { type: piece, category: 'Other' };
            else if(category !== 'Other' && item_name.includes(`${piece} ${category}`)) return { type: `${piece} ${category}`, category: category };
        }
    }
    return {};
}

function initializeNewDataObject() {
    const new_data = {
        shard: {},
        kuudra_armor: { single: {}, double: {} },
        other_armor: { single: {}, double: {} },
        equipmentType: { single: {}, double: {} },
        weapon: { single: {}, double: {} }
    };
    for(const attribute of attributes) {
        new_data.shard[attribute] = [];
        for(let level = 0; level < 10; level++) new_data.shard[attribute][level] = [];
        if(armor_attributes.includes(attribute)) {
            new_data.kuudra_armor.single[attribute] = { Helmet: [], Chestplate: [], Leggings: [], Boots: [] };
            for(const part of Object.keys(new_data.kuudra_armor.single[attribute])) for(let level = 0; level < 10; level++) new_data.kuudra_armor.single[attribute][part][level] = [];
            new_data.other_armor.single[attribute] = { Helmet: [], Chestplate: [], Leggings: [], Boots: [] };
            for(const part of Object.keys(new_data.other_armor.single[attribute])) for(let level = 0; level < 10; level++) new_data.other_armor.single[attribute][part][level] = [];
            new_data.equipmentType.single[attribute] = {};
            for(const type of Object.keys(items.equipmentType)) {
                new_data.equipmentType.single[attribute][type] = [];
                for(let level = 0; level < 10; level++) new_data.equipmentType.single[attribute][type][level] = [];
            }
            new_data.kuudra_armor.double[attribute] = {};
            new_data.other_armor.double[attribute] = {};
            new_data.equipmentType.double[attribute] = {};
            for(const attribute_2 of armor_attributes) {
                new_data.kuudra_armor.double[attribute][attribute_2] = { Helmet: {}, Chestplate: {}, Leggings: {}, Boots: {} };
                new_data.other_armor.double[attribute][attribute_2] = { Helmet: {}, Chestplate: {}, Leggings: {}, Boots: {} };
                new_data.equipmentType.double[attribute][attribute_2] = {};
                for(const type of Object.keys(items.equipmentType)) new_data.equipmentType.double[attribute][attribute_2][type] = [];
            }
        }
        if(weapon_attributes.includes(attribute)) {
            new_data.weapon.single[attribute] = [];
            for(let level = 0; level < 10; level++) new_data.weapon.single[attribute][level] = [];
        }
    }
    return new_data;
}

function getAttributeCaseSensitive(name) {
    return name.split('_').map(word => `${word.charAt(0).toUpperCase()}${word.slice(1)}`).join(' ');
}

module.exports = { refreshData };