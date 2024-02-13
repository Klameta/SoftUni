function solve(inputArr) {
  let cats = [];

  class cat {
    constructor(name, age) {
      this.name = name;
      this.age = age;
    }

    meow() {
      console.log(`${this.name}, age ${this.age} says Meow`);
    }
  }
  for (let i = 0; i < inputArr.length; i++) {
    const element = inputArr[i].split(" ");
    let currCat = new cat(element[0], element[1]);
    cats.push(currCat);
  }

  for (const currCat of cats) {
    currCat.meow();
  }
}

solve(['Candy 1', 'Poppy 3', 'Nyx 2'])
