function solve(inputNumber) {
    for (let i = 0; i < inputNumber; i++) {
        let numberStr = `${inputNumber} `;
        let currLine = numberStr.repeat(inputNumber).trimEnd();
        console.log(currLine)
    }
}
