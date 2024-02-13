function solve(firstInputArr, secondInputArr) {
  let products = {};
  for (let i = 0; i < firstInputArr.length; i += 2) {
    let name = firstInputArr[i];
    let quantity = parseInt(firstInputArr[i + 1]);
    products[name] = quantity;
  }

  for (let i = 0; i < secondInputArr.length; i += 2) {
    let name = secondInputArr[i];
    let quantity = parseInt(secondInputArr[i + 1]);
    if (products.hasOwnProperty(name)) {
      products[name] += quantity;
    } else {
      products[name] = quantity;
    }
  }

  for (const [key, value] of Object.entries(products)) {
    console.log(`${key} -> ${value}`);
  }
}

solve(
  ["Chips", "5", "CocaCola", "9", "Bananas", "14", "Pasta", "4", "Beer", "2"],
  ["Flour", "44", "Oil", "12", "Pasta", "7", "Tomatoes", "70", "Bananas", "30"]
);
