function solve(wordToSplit) {
  let wordArr = [];
  let currWord = "";
  let isFirst = true;
  for (let index = 0; index < wordToSplit.length; index++) {
    const currLetter = wordToSplit[index];

    if (currLetter.toUpperCase() == currLetter) {
      if (isFirst) {
        currWord += currLetter;
        isFirst = false;
      } else {
        wordArr.push(currWord);
        currWord=currLetter;
      }
    }
    else{
        currWord+=currLetter;
    }
  }
  wordArr.push(currWord);
  console.log(wordArr.join(", "))
}

