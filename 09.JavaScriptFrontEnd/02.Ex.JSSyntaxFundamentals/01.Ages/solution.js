function solve(age) {
    if(age<0)
    {
        console.log("out of bounds");
        return;
    }

    result = age <=2 ? "baby":
            age <=13 ? "child":
            age<=19 ? "teenager":
            age<=65 ? "adult":
            "elder";
    console.log(result);
}