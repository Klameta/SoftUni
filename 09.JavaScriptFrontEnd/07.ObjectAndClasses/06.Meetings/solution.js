function solve(arrayInput) {
  let result = {};
  for (const currInput of arrayInput) {
    let [day, person] = currInput.split(" ");

    if (day in result) {
      console.log(`Conflict on ${day}`);
    } else {
      console.log(`Scheduled for ${day}`);
      result[day] = person;
    }
  }

  for (let currMeet in result) {
    console.log(`${currMeet} -> ${result[currMeet]}`);
  }
}

solve(["Monday Peter", "Wednesday Bill", "Monday Tim", "Friday Tim"]);
