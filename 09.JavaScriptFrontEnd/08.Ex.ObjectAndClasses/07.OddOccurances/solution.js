function solve(inputStr) {
  const inputArr = inputStr.toLowerCase().split(" ");
  const words = {};

  for (const wordName of inputArr) {
    if (words.hasOwnProperty(wordName)) {
      words[wordName]++;
    } else {
      words[wordName] = 1;
    }
  }

  let filtered = Object.entries(words)
    .filter(([word, count]) => count % 2 != 0)
    .map(([word]) => word);

  console.log(filtered.join(" "));
}

solve("Java C# Php PHP Java PhP 3 C# 3 1 5 C#");
