function operations(firstNum, secondNum, operation) {
    let result = 0;
    switch (operation) {
        case '+':
            result = firstNum + secondNum;
            break;
        case '-':
            result = firstNum - secondNum;
            break;
        case '*':
            result = firstNum * secondNum;
            break;
        case '/':
            result = firstNum / secondNum;
            break;
        case '%':
            result = firstNum % secondNum;
            break;
        case '**':
            result = firstNum ** secondNum;
        default:
            break;
    }

    console.log(result)
}

operations(5, 6, '+')
operations(3, 5.5, '*')