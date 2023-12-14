function solve() {
  const textInput = document
    .getElementById("text")
    .value.toLowerCase()
    .split(" ");
  const namingConv = document.getElementById("naming-convention").value;
  let output = "";

  if (namingConv != "Camel Case" && namingConv != "Pascal Case") {
    output = "Error!";
  } else {

    for (let i = 0; i < textInput.length; i++) {
      let word = textInput[i].substr(1, textInput[i].length);
      let firsLetter = textInput[i].split("").shift();

      if (namingConv == "Camel Case" && i == 0) {

        output += firsLetter + word;
      } else {

        output += firsLetter.toUpperCase() + word;
      }
    }
  }

  document.getElementById("result").textContent = output;
}
