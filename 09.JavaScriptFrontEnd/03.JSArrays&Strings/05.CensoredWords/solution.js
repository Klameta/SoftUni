function solve(inputSentance, censoredWord) {
  let censoredChars = "*".repeat(censoredWord.length);

  while (inputSentance.indexOf(censoredWord) != -1) {
    inputSentance = inputSentance.replace(censoredWord, censoredChars);
  }

  console.log(inputSentance);
}
