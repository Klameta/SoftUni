function solve(word, sentance) {
    sentance = sentance.toLowerCase();
    let searchWord = word.toLowerCase();

    if (sentance.includes(searchWord)) {
        console.log(word)
    } else {
        console.log(`${word} not found!`)
    }
}
solve('javascript','JavaScript is the best programming language' )