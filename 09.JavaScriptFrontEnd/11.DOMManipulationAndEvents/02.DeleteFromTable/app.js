function deleteByEmail() {
  const inputEmail = document.querySelector("input").value;
  const emails = Array.from(
    document.querySelectorAll("tbody tr :nth-child(2)")
  );
  
  let isDeleted = false;
  
  for (const email of emails) {
      let emailText = email.textContent;
      if (emailText == inputEmail) {
          email.parentElement.parentElement.removeChild(email.parentElement);
          isDeleted = true;
        }
    }

    let result = document.getElementById("result");
    result.textContent = isDeleted? "Deleted" : "Not found";
}
