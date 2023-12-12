function solve(inputArr) {
  let heroes = {};
  for (const strInp of inputArr) {
    let [name, level, itemsStr] = strInp.split(" / ");
    heroes[name] = {
      Hero: name,
      level: parseInt(level),
      items: itemsStr.split(", "),
    };
  }

  let sortedHeroes = Object.values(heroes).sort((first, second) => first.level - second.level);
  for (const heroName in sortedHeroes) {
    console.log(`Hero: ${sortedHeroes[heroName].Hero}`);
    console.log(`level => ${sortedHeroes[heroName].level}`);
    console.log(`items => ${sortedHeroes[heroName].items.join(", ")}`);
  }
}

solve([
  "Isacc / 25 / Apple, GravityGun",
  "Derek / 12 / BarrelVest, DestructionSword",
  "Hes / 1 / Desolator, Sentinel, Antara",
]);
