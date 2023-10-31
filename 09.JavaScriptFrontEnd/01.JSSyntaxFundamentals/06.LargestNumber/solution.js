function largestNum(firstNum, secondNum, thirdNum) {
    let result = 0;
    if (firstNum > secondNum && firstNum > thirdNum) {
        result = firstNum;
    } else if (secondNum > firstNum && secondNum > thirdNum){
        result = secondNum;
    } else {
        result = thirdNum;
    }

    console.log(`The largest number is ${result}`)
}

largestNum(5, -3, 16)
largestNum(-3, -5, -22.5)