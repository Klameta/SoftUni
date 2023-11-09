function solve(typeOfFruit, weightG, priceKg) {
  let weightKg = weightG * 0.001;
  let price = weightKg * priceKg;

  console.log(`I need $${price.toFixed(2)} to buy ${weightKg.toFixed(2)} kilograms ${typeOfFruit}.`);
}
