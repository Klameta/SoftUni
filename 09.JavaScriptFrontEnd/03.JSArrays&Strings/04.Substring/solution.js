function solve(wordToSplit, startIndex, countOfElementsToRemove) {
    // let result = wordToSplit.slice(startIndex, countOfElementsToRemove+1);
    let result = wordToSplit.substring(startIndex, countOfElementsToRemove+startIndex);

    console.log(result)
}

solve('SkipWord', 4, 7 )