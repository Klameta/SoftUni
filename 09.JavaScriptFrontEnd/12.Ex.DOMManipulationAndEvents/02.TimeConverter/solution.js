function attachEventsListeners() {
  let buttons = Array.from(document.querySelectorAll('input[type="button"]'));

  buttons.forEach((btn) => {
    btn.addEventListener("click", (e) => {
      const input = btn.parentElement.querySelector("input");
      const inputValue = Number(input.value);

      const id = input.id;

      const days = document.getElementById("days");
      const hours = document.getElementById("hours");
      const minutes = document.getElementById("minutes");
      const seconds = document.getElementById("seconds");

      switch (id) {
        case "days":
          hours.value = inputValue * 24;
          minutes.value = inputValue * 24 * 60;
          seconds.value = inputValue * 24 * 60 * 60;
          break;
        case "hours":
          days.value = inputValue / 24;
          minutes.value = inputValue * 60;
          seconds.value = inputValue * 60 * 60;
          break;
        case "minutes":
          days.value = inputValue / 24 / 60;
          hours.value = inputValue / 60;
          seconds.value = inputValue * 60;
          break;
        case "seconds":
          days.value = inputValue / 24 / 60 / 60;
          hours.value = inputValue / 60 / 60;
          minutes.value = inputValue / 60;
          break;
      }
    });
  });
}
