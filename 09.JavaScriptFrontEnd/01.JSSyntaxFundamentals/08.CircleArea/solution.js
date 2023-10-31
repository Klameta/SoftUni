function solve(radius) {
    let result;
    if (typeof(radius)=== 'number') {
        result = Math.PI *radius**2
    }
    else{
        console.log(`We can not calculate the circle area, because we recieve a ${typeof(radius)}`)
        return;
    }

    console.log(`${result.toFixed(2)}`)
}

solve(5)
solve('name')