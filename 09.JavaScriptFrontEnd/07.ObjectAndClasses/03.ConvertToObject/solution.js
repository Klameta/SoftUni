function solve(jsonString) {
    let person = JSON.parse(jsonString);
    const props = Object.entries(person);

    for (const [key,value] of props) {
        console.log(`${key}: ${value}`);
    }
}

solve('{"name": "George", "age": 40, "town": "Sofia"}')