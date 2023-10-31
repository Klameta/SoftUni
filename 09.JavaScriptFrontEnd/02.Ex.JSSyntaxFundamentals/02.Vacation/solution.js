function solve(groupNumber, groupType, weekDay) {
    let resultForOne = 0;

    if (groupType == "Students") {
        switch (weekDay) {
            case "Friday":
                resultForOne = 8.45;
                break;
            case "Saturday":
                resultForOne = 9.80;
                break;
            case "Sunday":
                resultForOne = 10.46;
                break;
        }
    } else if (groupType == "Business") {
        switch (weekDay) {
            case "Friday":
                resultForOne = 10.90;
                break;
            case "Saturday":
                resultForOne = 15.60;
                break;
            case "Sunday":
                resultForOne = 16;
                break;
        }

    } else if (groupType == "Regular") {
        switch (weekDay) {
            case "Friday":
                resultForOne = 15;
                break;
            case "Saturday":
                resultForOne = 20;
                break;
            case "Sunday":
                resultForOne = 22.50;
                break;
        }
    }

    let totalPrice = resultForOne * groupNumber;
    if (groupType == "Students" && groupNumber >= 30) {

        totalPrice -= totalPrice*0.15;
    } else if (groupType == "Business" && groupNumber >= 100) {

        let reducedPrice = resultForOne * 10;
        totalPrice -= reducedPrice;
    } else if (groupType == "Regular" && groupNumber >= 10 && groupNumber <= 20) {

        totalPrice -= totalPrice*0.05;
    }

    console.log(`Total price: ${totalPrice.toFixed(2)}`)
}
