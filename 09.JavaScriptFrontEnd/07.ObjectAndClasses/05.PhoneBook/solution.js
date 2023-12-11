class Person {
  constructor(name, number) {
    (this.name = name), (this.number = number);
  }
}

function solve(phonesArr) {
  let people = [];
  for (const currObj of phonesArr) {
    let currLine = currObj.split(" ");
    let currPer = new Person(currLine[0], currLine[1]);

    let repeat = people.find(({ name }) => name == currPer.name);

    if (repeat != undefined) {
      repeat.number = currPer.number;
    } else {
      people.push(currPer);
    }
  }

  for (const currObj of people) {
    console.log(`${currObj.name} -> ${currObj.number}`);
  }
}

solve(["George 0552554", "Peter 087587", "George 0453112", "Bill 0845344"]);
