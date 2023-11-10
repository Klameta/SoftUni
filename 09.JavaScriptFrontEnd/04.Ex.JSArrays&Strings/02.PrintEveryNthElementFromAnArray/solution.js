function solve(stringArr, nSteps) {
  let result = [];
  for (let index = 0; index < stringArr.length; index += nSteps) {
    result.push(stringArr[index]);
  }
  return result;
}