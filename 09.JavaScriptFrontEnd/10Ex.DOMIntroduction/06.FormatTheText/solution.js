function solve() {
  const textInputs = document.getElementById("input").value.split(".");
  const textInput = textInputs.filter(Boolean);
  let paragraps = [];
  let sentenceCounter = 0;
  let paragraphCounter = 0;

  for (const sentence of textInput) {
    if (sentenceCounter <= 3 && sentenceCounter!=0) {
      paragraps[paragraphCounter-1] = paragraps[paragraphCounter-1] + "." + sentence;
    } else {
      paragraps[paragraphCounter] = sentence;
      paragraphCounter++;
      sentenceCounter = 0;
    }
    sentenceCounter++;
  }

 for (let i = 0; i < paragraps.length; i++) {
  paragraps[i] = `<p>${paragraps[i]}</p>`
 }

  document.getElementById("output").innerHTML = paragraps
}
