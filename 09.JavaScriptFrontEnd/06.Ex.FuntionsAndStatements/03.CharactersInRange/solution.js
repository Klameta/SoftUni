function solve(firstChar, secondChar) {
    let smaller = firstChar < secondChar ? firstChar : secondChar;
    let bigger = firstChar > secondChar ? firstChar : secondChar;
    smaller = smaller.charCodeAt() + 1;
    bigger = bigger.charCodeAt();

    let charArr = [];

    for (let i = smaller; i < bigger; i++) {
        charArr.push(String.fromCharCode(i));
    }

    console.log(charArr.join(" "));
}
solve('C','#')