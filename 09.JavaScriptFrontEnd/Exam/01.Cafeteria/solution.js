function solve(inputArr) {
  const baristasCount = Number(inputArr.shift());
  let baristas = [];

  for (let i = 0; i < baristasCount; i++) {
    let baristasInput1 = inputArr.shift();
    let baristasInput = baristasInput1.split(" ");
    const baristaName = baristasInput[0];
    const shift = baristasInput[1];
    const coffies1 = baristasInput[2];
    const coffies = coffies1.split(",");
    baristas.push({ baristaName, shift, coffies });
  }

  let currentAction = inputArr.shift();

  while (currentAction != "Closed") {
    let actionsAndValues = currentAction.split(" / ");
    const action = actionsAndValues[0];

    switch (action) {
      case "Prepare":
        const bName = actionsAndValues[1];
        const shift = actionsAndValues[2];
        const coffeeType = actionsAndValues[3];
        let hasPreped = false;

        baristas.forEach((b) => {
          if (
            b.baristaName == bName &&
            b.shift == shift &&
            b.coffies.includes(coffeeType)
          ) {
            console.log(`${bName} has prepared a ${coffeeType} for you!`);
            hasPreped = true;
          }
        });

        if (!hasPreped)
          console.log(`${bName} is not available to prepare a ${coffeeType}.`);
        break;
      case "Change Shift":
        const bName1 = actionsAndValues[1];
        const newShift = actionsAndValues[2];

        baristas.forEach((b) => {
          if (b.baristaName == bName1) {
            b.shift = newShift;
            console.log(`${bName1} has updated his shift to: ${newShift}`);
          }
        });
        break;
      case "Learn":
        const bName2 = actionsAndValues[1];
        const coffeToLearn = actionsAndValues[2];
        let hasLearnt = false;

        baristas.forEach((b) => {
          if (b.baristaName == bName2 && !b.coffies.includes(coffeToLearn)) {
            b.coffies.push(coffeToLearn);
            console.log(`${bName2} has learned a new coffee type: ${coffeToLearn}.`);
          hasLearnt = true;
          }
        });

        if(!hasLearnt) console.log(`${bName2} knows how to make ${coffeToLearn}.`);
        break;
    }

    currentAction = inputArr.shift();
  }

  baristas.forEach(b => {
    console.log(`Barista: ${b.baristaName}, Shift: ${b.shift}, Drinks: ${b.coffies.join(", ")}`);
  });
}
