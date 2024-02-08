const SpellJsonOne = require('./spells.json');
const PHBspells = require('./spells-phb.json');

let spells = {}

PHBspells['spell'].forEach(spell => {
    console.log(spell.name);
    let customSpell = {}
    spells[spell.name] = customSpell;
});

SpellJsonOne['compendium']['spell'].forEach(spell => {
    if (!Object.keys(spells).includes(spell.name)) {
        return;
    }

    let roll = undefined

    if (spell.roll instanceof Array) {
        roll = spell.roll;
    } else if (spell.roll !== undefined) {
        roll = [spell.roll];
    }

    let SpellName = spell.name;
    delete spell.name;
    let customSpell = {
        "level": parseInt(spell.level),
        "time": spell.time,
        "range": spell.range,
        "duration": spell.duration,
        "classes:": [],
        "components": {
            "S": true,
            "V": true,
            "M": {}
        },
        "roll": roll,
        "description": spell.text,
        "source": "Player's Handbook"
    };

    spells[SpellName] = customSpell;
});

const fs = require("fs")
const data = JSON.stringify(spells)
fs.writeFile('./CustomSpells.json', data, (error) => {
    if (error) {
        console.log(error);
        throw error;
    }
})