function lockedProfile() {
  const profilesButtons = Array.from(
    document.querySelectorAll(".profile button")
  );

  for (const pBtn of profilesButtons) {
    pBtn.addEventListener("click", showBtn);
  }

  function showBtn(e) {
    const profileDiv = e.target.parentElement;
    const unlockRadio = profileDiv.querySelector('input[value="unlock"]');
    const hiddenFields = profileDiv.querySelector("div[id^='user']");

    if (unlockRadio.checked) {
      hiddenFields.style.display =
        hiddenFields.style.display === "none" ? "block" : "none";
        e.target.textContent = hiddenFields.style.display === "none" ? "Show more" : "Hide it";
        
    }
    else{
        e.target.removeEventListener('click', showBtn);
    }
  }
}
