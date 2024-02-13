function solve(inputArr) {
  const cars = [];
  for (const lineInp of inputArr) {
    const lineArr = lineInp.split(", ");
    if (lineArr[0] == "IN" && !cars.includes(lineArr[1])) {
      cars.push(lineArr[1]);
    } else if (lineArr[0] == "OUT" && cars.includes(lineArr[1])) {
      cars.pop(lineArr[1]);
      if (cars.length == 0) {
        console.log("Parking Lot is Empty");
      }
    }
  }

  const sorted = cars.sort();

  sorted.forEach(x => console.log(x))
}
solve(['IN, CA2844AA', 'IN, CA1234TA', 'OUT, CA2844AA', 'IN, CA9999TT', 'IN, CA2866HI', 'OUT, CA1234TA', 'IN, CA2844AA', 'OUT, CA2866HI', 'IN, CA9876HH', 'IN, CA2822UU'])