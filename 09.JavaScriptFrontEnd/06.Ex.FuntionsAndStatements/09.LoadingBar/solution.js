function solve(inputNumber) {
    let timesReplicated = inputNumber/10;
    let percentale = "%".repeat(timesReplicated);

    let result = `[${percentale.padEnd(10,".")}]`
    if (inputNumber<100) {
        console.log(`${inputNumber}% ${result}`)
        console.log("Still loading...");
    }
    else{
        console.log("100% Complete!");
        console.log(result)
    }
   
}

solve(100)