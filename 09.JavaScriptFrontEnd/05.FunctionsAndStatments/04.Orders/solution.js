function solve(item, quantity) {
  let priceSingular = 0.0;
  switch (item) {
    case "coffee":
    priceSingular=1.50;  
    break;
    case "water":
        priceSingular=1.00;
      break;
    case "coke":
        priceSingular=1.40;
      break;
    case "snacks":
        priceSingular=2.00;
      break;
  }

  console.log(priceSingular*quantity);
}

solve("water",5)
