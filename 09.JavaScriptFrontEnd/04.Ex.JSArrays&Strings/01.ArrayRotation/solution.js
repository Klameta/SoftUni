function solve(numsArr, nRotations) {
    for (let index = 0; index < nRotations; index++) {
        let removed = numsArr[0]; 
        numsArr.splice(0,1);

        numsArr.push(removed)
    }

    console.log(numsArr.join(" "))
}