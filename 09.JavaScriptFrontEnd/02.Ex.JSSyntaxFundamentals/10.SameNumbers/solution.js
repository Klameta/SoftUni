function solve(inputNumber) {
  let isSame = true;
  let numCheck = inputNumber % 10;
  let digitSum = 0;

  while (inputNumber > 0) {
    let currDigit = inputNumber % 10;
    inputNumber = Math.floor(inputNumber / 10);
    digitSum += currDigit;

    if (numCheck != currDigit) {
      isSame = false;
    }
  }
  console.log(isSame);
  console.log(digitSum);
}
