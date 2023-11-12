function solve(numArr) {
  numArr.sort((a, b) => a - b);
  let result = [];
  let length = numArr.length;

  for (let i = 0; i < length; i++) {
    if (i % 2 == 0) {
      result.push(numArr.shift());
    } else {
      result.push(numArr.pop());
    }
  }
  return result
}
