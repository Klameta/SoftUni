function solve(firstNumber, secondNumber) {
  let firstFact = factorial(firstNumber);
  let secondFact = factorial(secondNumber);

  let result = firstFact / secondFact;
  console.log(result.toFixed(2));

  function factorial(n) {
    if (n == 0 || n == 1) return 1;
    return factorial(n - 1) * n;
  }
}

solve(6, 2);
