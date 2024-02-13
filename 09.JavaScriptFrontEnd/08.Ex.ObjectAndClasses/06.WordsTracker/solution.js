function solve(inputArr) {
  let searchWordsArr = inputArr.shift().split(" ");
  let words = {};
  
  for (const word of searchWordsArr) {
    words[word] = {
      name: word,
      timesRepeated: 0,
    };
  }

  for (const word of inputArr) {
    if (words[word]) {
      words[word].timesRepeated++;
    }
  }

  let sortedWords = Object.values(words).sort(
    (first, second) => second.timesRepeated - first.timesRepeated
  );
  for (const word in sortedWords) {
    console.log(
      `${sortedWords[word].name} - ${sortedWords[word].timesRepeated}`
    );
  }
}

solve([
  "sentence this",

  "In",
  "this",
  "sentence",
  "you",
  "have",

  "to",
  "count",
  "the",
  "occurrences",
  "of",

  "the",
  "words",
  "this",
  "and",
  "sentence",

  "because",
  "this",
  "is",
  "your",
  "task",
]);
