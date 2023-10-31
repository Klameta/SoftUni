function solve(startum, endNum) {
    let sum = 0;
    let nums = "";
    for (let index = startum; index <= endNum; index++) {
        nums += `${index} `
        sum+= index;
    }
    console.log(nums)
    console.log(`Sum: ${sum}`)
}