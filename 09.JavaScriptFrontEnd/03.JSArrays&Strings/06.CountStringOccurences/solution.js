function solve(inputSentance, wordToCount) {
  let sentanceArr = inputSentance.split(" ");
  let wordCounter = 0;
  sentanceArr.forEach((word) => {
    if (word == wordToCount) {
      wordCounter++;
    }
  });

  console.log(wordCounter);
}
