function solve(inputArr) {
  let employees = {};
  for (const currInput of inputArr) {
    let [name, number] = [currInput, currInput.length];
    employees[name] = number;
  }

  for (const employee in employees) {
    console.log(`Name: ${employee} -- Personal Number: ${employees[employee]}`);
  }
}

solve([
  "Silas Butler",

  "Adnaan Buckley",

  "Juan Peterson",

  "Brendan Villarreal",
]);
