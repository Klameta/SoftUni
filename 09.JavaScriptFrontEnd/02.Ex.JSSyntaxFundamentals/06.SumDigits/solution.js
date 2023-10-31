function solve(inputNumber) {
    let sum = 0;
    while (inputNumber > 0) {
        sum += inputNumber % 10;
        inputNumber = Math.floor(inputNumber/10);
    }
    console.log(sum)
}