function solve(firstNum, secondNum, thirdNum) {
    let minNumber = firstNum;
    if(minNumber>secondNum) minNumber=secondNum;
    if(minNumber>thirdNum) minNumber=thirdNum;

    console.log(minNumber)
}

solve(2,5,3)