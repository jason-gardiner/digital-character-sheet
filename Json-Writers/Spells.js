const spells = require('./spells.json');

spells['compendium']['spell'].forEach(spell => {
    console.log(spell);
});