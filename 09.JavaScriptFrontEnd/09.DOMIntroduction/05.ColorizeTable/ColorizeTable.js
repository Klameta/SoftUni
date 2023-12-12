function colorize() {
  const rowsNodes = Array.from(document.querySelectorAll("tr:nth-child(even)"));

  for (const row of rowsNodes) {
    row.style.background = "teal"
  }
}
