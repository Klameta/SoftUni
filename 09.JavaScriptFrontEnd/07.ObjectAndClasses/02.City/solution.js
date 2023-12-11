function solve(cityObj) {
  const props = Object.entries(cityObj);

  for (const [key, value] of props) {
    console.log(`${key} -> ${value}`);
  }
}

solve({
  name: "Sofia",
  area: 492,
  population: 1238438,
  country: "Bulgaria",
  postCode: "1000",
});
