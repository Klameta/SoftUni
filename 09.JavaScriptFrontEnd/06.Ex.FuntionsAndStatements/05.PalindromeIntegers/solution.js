function solve(inputNumArr) {
  for (const currNum of inputNumArr) {
    console.log(isNumberPalindrome(currNum));
  }

  function isNumberPalindrome(inputNumber) {
    const strArr = inputNumber.toString().split("");

    while (strArr.length > 1) {
      let firstNum = strArr.shift();
      let secondNum = strArr.pop();

      if (firstNum != secondNum) {
        return false;
      }
    }
    return true;
  }
}
