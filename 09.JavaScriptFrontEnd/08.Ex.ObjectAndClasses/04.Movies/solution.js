function solve(inputArr) {

  let movies = {};

  for (const strInp of inputArr) {
    if (strInp.includes("addMovie ")) {
      let name = strInp.split("addMovie ")[1];
      movies[name] = {};
      movies[name].name = name;
    } else if (strInp.includes(" directedBy ")) {
      let [name, director] = strInp.split(" directedBy ");
      if (movies[name]) {
        movies[name].director = director;
      }
    } else {
      let [name, date] = strInp.split(" onDate ");
      if (movies[name]) {
        movies[name].date = date;
      }
    }
  }

  function hasAllProperties(movie) {
    const requiredProperties = ["name", "date", "director"];
    return requiredProperties.every(
      (prop) => movie.hasOwnProperty(prop) && movie[prop]
    );
  }

  for (const movieName in movies) {
    if (hasAllProperties(movies[movieName])) {
      console.log(JSON.stringify(movies[movieName]));
    }
  }
}

solve([
  "addMovie Fast and Furious",
  "addMovie Godfather",
  "Inception directedBy Christopher Nolan",
  "Godfather directedBy Francis Ford Coppola",
  "Godfather onDate 29.07.2018",
  "Fast and Furious onDate 30.07.2018",
  "Batman onDate 01.08.2018",
  "Fast and Furious directedBy Rob Cohen",
]);

solve([
  "addMovie The Avengers",

  "addMovie Superman",

  "The Avengers directedBy Anthony Russo",

  "The Avengers onDate 30.07.2010",

  "Captain America onDate 30.07.2010",

  "Captain America directedBy Joe Russo",
]);
