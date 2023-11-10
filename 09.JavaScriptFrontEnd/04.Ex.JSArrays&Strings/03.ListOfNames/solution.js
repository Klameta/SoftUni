function solve(nameArr) {
  nameArr.sort((a, b) => a.localeCompare(b));
  let counter = 1;
  nameArr.forEach((element) => {
    console.log(`${counter}.${element}`);
    counter++;
  });
}
