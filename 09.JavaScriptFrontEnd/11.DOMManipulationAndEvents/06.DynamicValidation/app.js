function validate() {
  const inputField = document.querySelector("input");

  inputField.addEventListener("change", (e) => {
    let textToValidate = e.target.value;
    const regex = /[a-z]+@[a-z]+[.][a-z]+/gi;

    regex.test(textToValidate)
      ? (e.target.classList.remove("error"), console.log("hi"))
      : e.target.classList.add("error");
  });
}
