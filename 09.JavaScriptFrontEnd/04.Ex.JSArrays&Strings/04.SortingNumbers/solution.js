function solve(numArr) {
  let smallNums = numArr
    .map(function (num) {
      return num;
    })
    .sort();
  let bigNums = numArr
    .map(function (num) {
      return num;
    })
    bigNums = bigNums.sort().reverse()

  let indexTracker = 0;

  let result = [];
  for (let i = 0; i < numArr.length; i++) {
    if (i % 2 != 0) {
      result.push(bigNums[indexTracker]);
      indexTracker++;
    } else {
      result.push(smallNums[indexTracker]);
    }
  }

  console.log(result);
  return result;
}

solve([22, 9, 63, 3, 2, 19, 54, 11, 21, 18]);
