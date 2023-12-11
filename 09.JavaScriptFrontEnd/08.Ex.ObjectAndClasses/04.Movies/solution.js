function solve(inputArr) {
  class movie {
    constructor(name, date, director) {
      (this.name = name), (this.date = date), (this.director = director);
    }
  }
  let movies = [];
  for (const strInp of inputArr) {
    let currInput = strInp.split(" ");
    if (strInp[0] == "addMovie") {
    } else if (currInput.find((x) => x == "directedBy")) {
        let index = currInput
        let currMovie = movies.find(x=> x.name == "")
    } else {
    }
  }
}
