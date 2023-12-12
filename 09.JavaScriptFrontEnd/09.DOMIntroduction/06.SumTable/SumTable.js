function sumTable() {
  const priceNodes = Array.from(document.querySelectorAll("tr td:nth-child(2):not(#sum)"));
  let sum = 0;  
  for (const node of priceNodes) {
        sum+= Number(node.textContent)
    }

    document.getElementById("sum").textContent = sum;
}
