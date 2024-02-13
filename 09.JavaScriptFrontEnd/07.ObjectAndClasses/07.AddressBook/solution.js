function solve(inputArr) {
  let addresses = [];
  for (const currAddress of inputArr) {
    let [name, address] = currAddress.split(":");

    addresses[name] = address;
  }
  addresses;

  let entries = Object.entries(addresses);
  for (const [key, value] of entries.sort((a, b) => a[0].localeCompare(b[0]))) {
    console.log(`${key} -> ${value}`);
  }
}

solve([
  "Bob:Huxley Rd",
  "John:Milwaukee Crossing",
  "Peter:Fordem Ave",
  "Bob:Redwing Ave",
  "George:Mesta Crossing",
  "Ted:Gateway Way",
  "Bill:Gateway Way",
  "John:Grover Rd",
  "Peter:Huxley Rd",
  "Jeff:Gateway Way",
  "Jeff:Huxley Rd",
]);
