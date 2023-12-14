function toggle() {
  let buttonText = document.querySelector(".button");
  const shownOrHidden = document.querySelector("#extra");
  console.log("hello world");

  if (shownOrHidden.style.display == "none") {
    buttonText.textContent = "Less";
    shownOrHidden.style.display = "block";
  }else{
    buttonText.textContent = "More";
    shownOrHidden.style.display = "none";
  }
}
