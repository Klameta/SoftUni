function solve(originalNumbersCount, numsArray) {
  let splittedArray = numsArray.slice(0, originalNumbersCount);
  let result = splittedArray.reverse().join(" ");

  console.log(result);
}
