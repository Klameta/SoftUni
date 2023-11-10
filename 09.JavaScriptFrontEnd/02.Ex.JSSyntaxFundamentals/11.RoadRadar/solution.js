function solve(currSpeed, area) {
  let limit =
    area == "motorway"
      ? 130
      : area == "interstate"
      ? 90
      : area == "city"
      ? 50
      : 20;
  if (currSpeed <= limit) {
    console.log(`Driving ${currSpeed} km/h in a ${limit} zone`);
  } else {
    let diffrence = currSpeed - limit;
    let status =
      diffrence <= 20
        ? "speeding"
        : diffrence <= 40
        ? "excessive speeding"
        : "reckless driving";

    console.log(
      `The speed is ${diffrence} km/h faster than the allowed speed of ${limit} - ${status}`
    );
  }
}