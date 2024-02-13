function solve(inputNumber) {
    let digitArr = Array.from(String(inputNumber), Number);
    let evenSum = 0;
    let oddSum = 0;

    for (let i = 0; i < digitArr.length; i++) {
        const element = digitArr[i];
        if (element % 2 == 0) {
            evenSum += element;
        } else {
            oddSum += element;
        }
    }

    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`)
}

solve(3495892137259234)