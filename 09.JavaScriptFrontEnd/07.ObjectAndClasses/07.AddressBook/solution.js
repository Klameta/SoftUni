function solve(inputArr) {
  let addresses = {};
  for (const currAddress of inputArr) {
    let [name, address] = currAddress.split(":");

    address[name] = address;
  }

  for (let currAddress in addresses) {
    console.log(`${currAddress} -> ${addresses[currAddress]}`);
  }
}

solve([
  "Tim:Doe Crossing",
  "Bill:Nelson Place",
  "Peter:Carlyle Ave",
  "Bill:Ornery Rd",
]);
