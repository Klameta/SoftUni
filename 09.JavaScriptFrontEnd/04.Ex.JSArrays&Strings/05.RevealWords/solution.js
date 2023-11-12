function solve(input, sentance) {
  censoredWords = input.split(", ");
  
    for (const element of censoredWords) {
      let stars = "*".repeat(element.length)
      sentance = sentance.replace(stars, element)
    }
  console.log(sentance)
}
