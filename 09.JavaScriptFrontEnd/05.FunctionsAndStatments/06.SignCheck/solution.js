function solve(firstNum, secondNum, thirdNum) {
  let lessThan0Counter = 0;
  if (firstNum < 0) lessThan0Counter++;
  if (secondNum < 0) lessThan0Counter++;
  if (thirdNum < 0) lessThan0Counter++;

  if (lessThan0Counter % 2 == 0) {
    console.log("Positive");
  } else {
    console.log("Negative");
  }
}
solve(5, 12, 15);
