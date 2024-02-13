function solve(firstName, lastName, hairColor) {
  let person = { firstName, lastName, hairColor };
  let jsonied = JSON.stringify(person);

  console.log(jsonied);
}

solve("George", "Jones", "Brown");
