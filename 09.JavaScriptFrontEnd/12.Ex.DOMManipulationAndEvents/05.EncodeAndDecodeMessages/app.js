function encodeAndDecodeMessages() {
  const encodeAndSendBtn = document.querySelector("main div button");
  const decodeAndReadBtn = document.querySelector("main :nth-child(2) button");

  encodeAndSendBtn.addEventListener("click", () => {
    const input = document.querySelector("main div textarea");
    let output = document.querySelector("main :nth-child(2) textarea");

    let inputText = input.value.split("");
    let encrypted = inputText.map(letter => {
        return String.fromCharCode(letter.charCodeAt(0) +1);
    }).join("");

    input.value ="";
    output.value = encrypted;
  });

  decodeAndReadBtn.addEventListener("click", ()=>{
    const input = document.querySelector("main :nth-child(2) textarea");

    let inputText = input.value.split("");
    let decrypted = inputText.map(letter => {
        return String.fromCharCode(letter.charCodeAt(0) -1);
    }).join("");

    input.value = decrypted;
  })
}
