function solve(firstNum, secondNum) {
    let smallNum = firstNum < secondNum ? firstNum : secondNum;
    let bigNum = firstNum > secondNum ? firstNum : secondNum;

    for (let index = bigNum; smallNum <= index; index--) {
        console.log(index)
    }
}

solve(6, 2)
console.log(`\n`)
solve(4, 1)