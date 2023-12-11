function solve(inputArr) {
    let towns = [];
    for (const currInput of inputArr) {
        let currObjs = currInput.split(" | ");
        towns.push({
            town: currObjs[0],
            latitude: parseFloat(currObjs[1]).toFixed(2),
            longitude: parseFloat(currObjs[2]).toFixed(2)
        });
    }

    towns.forEach(e => {
        console.log(e)
    });
}

solve(['Sofia | 42.696552 | 23.32601',

'Beijing | 39.913818 | 116.363625'])