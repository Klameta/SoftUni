function solve(inputNumber, firstOp, secondOp, thirdOp, forthOp, fifthOp) {
  inputNumber = Number.parseInt(inputNumber);
  let ops = {
    0: firstOp,
    1: secondOp,
    2: thirdOp,
    3: forthOp,
    4: fifthOp,
  };
  for (let index = 0; index < 5; index++) {
    let currOp = ops[index];

    if (currOp == "chop") {
      inputNumber /= 2;
    } else if (currOp == "dice") {
      inputNumber = Math.sqrt(inputNumber);
    } else if (currOp == "spice") {
      inputNumber++;
    } else if (currOp == "bake") {
      inputNumber *= 3;
    } else {
      inputNumber -= inputNumber * 0.2;
    }

    console.log(inputNumber);
  }
}