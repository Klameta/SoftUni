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

    } else if (groupType == "Regular")
        switch (weekDay) {
            case "Friday":
                resultForOne = 15;
                break;
            case "Saturday":
                resultForOne = 9.80;
                break;
            case "Sunday":

                break;
        }
}