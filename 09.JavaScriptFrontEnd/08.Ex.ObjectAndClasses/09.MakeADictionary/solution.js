function solve(inputArr) {
  const dictionary = {};
  for (const inputLine of inputArr) {
    const currObj = JSON.parse(inputLine);
    const [key, value] = Object.entries(currObj)[0];
    if (dictionary[key]) {
      dictionary[key].definition = value;
    } else {
      dictionary[key] = { term: key, definition: value };
    }
  }

  const sorted = Object.values(dictionary).sort((a, b) => {
    if (a.term < b.term) {
      return -1;
    } else if (a.term > b.term) {
      return 1;
    }
    return 0;
  });

  for (const term in sorted) {
    console.log(
      `Term: ${sorted[term].term} => Definition: ${sorted[term].definition}`
    );
  }
}

solve([
  '{"Coffee":"A hot drink madefrom the roasted and groundseeds (coffee beans) of atropical shrub."}',
  '{"Bus":"A large motor vehicle carrying passengers by road, typically one serving the publicon a fixed route and for a fare."}',
  '{"Boiler":"A fuel-burning apparatus or container for heating water."}',
  '{"Tape":"A narrow strip of material, typically used to hold or fasten something."}',
  '{"Microphone":"An instrument for converting sound waves into electrical energy variations which may then be amplified, transmitted, or recorded."}',
]);
