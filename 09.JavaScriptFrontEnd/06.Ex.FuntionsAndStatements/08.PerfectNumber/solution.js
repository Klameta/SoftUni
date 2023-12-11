function solve(inputNumber) {
  let isPerfect = true;
  let halfSum = inputNumber / 2;
  if (inputNumber < 1 || inputNumber % 2 != 0) {
    isPerfect = false;
  }

  let divisors = [1];
  let divCounter = inputNumber/2;
  let currNumber = inputNumber;

  while (divCounter > 1) {
    if (currNumber % divCounter === 0) {
      divisors.push(divCounter);
    }
    divCounter--;
  }

  divisors = divisors.filter((d) => d<halfSum)
  let divSum =0
  for (const currNum of divisors) {
    divSum+=currNum;
  }

  if (divSum==inputNumber/2 && isPerfect) {
    console.log("We have a perfect number!")
    }else{
        console.log("It's not so perfect.")
    }

}

solve(1236498);
