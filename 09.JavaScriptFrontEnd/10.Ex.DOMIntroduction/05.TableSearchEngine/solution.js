function solve() {
  document.querySelector("#searchBtn").addEventListener("click", onClick);

  function onClick() {
    const input = document.querySelector("#searchField");
    const searchItem = input.value;
    input.value = "";

    const rowsElems = Array.from(document.querySelectorAll("tbody tr"));
    for (const rowElem of rowsElems) {
      rowElem.classList.remove("select");
      let cols = Array.from(rowElem.children);

      for (const col of cols) {
        if (col.textContent.includes(searchItem)) {
          rowElem.className = "select";
          break;
        }
      }
    }
  }
}
