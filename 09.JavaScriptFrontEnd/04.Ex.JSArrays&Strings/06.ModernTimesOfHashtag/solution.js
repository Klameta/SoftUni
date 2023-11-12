function solve(sentance) {
  let regex = /(#)[A-Za-z]+/g;
  let matches = sentance.match(regex);
  let result = [];

  for (const word of matches) {
    console.log(word.slice(1, word.length));
  }
}
