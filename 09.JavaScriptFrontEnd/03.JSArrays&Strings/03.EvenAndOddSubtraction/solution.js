function solve(numsArray) {
  let evens = numsArray.filter(function (n) {
    return n % 2 == 0;
  });

  let evenSum=0;
  evens.forEach((element) => {
    evenSum += element;
  });

  let odds = numsArray.filter(function (n) {
    return n % 2 != 0;
  });

  let oddSum =0;
  odds.forEach((element) => {
    oddSum += element;
  });

  console.log(evenSum - oddSum);
}
