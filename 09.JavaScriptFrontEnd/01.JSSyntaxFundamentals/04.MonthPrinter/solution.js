function monthPrinter(monthNumber) {
    if (monthNumber > 0 && monthNumber < 13) {
        let monthName = monthNumber == 1 ? `January` :
            monthNumber == 2 ? `February` :
            monthNumber == 3 ? `March` :
            monthNumber == 4 ? `April` :
            monthNumber == 5 ? `May` :
            monthNumber == 6 ? `June` :
            monthNumber == 7 ? `July` :
            monthNumber == 8 ? `August` :
            monthNumber == 9 ? `September` :
            monthNumber == 10 ? `October` :
            monthNumber == 11 ? `November` : `December`

        console.log(monthName)
    }else{
        console.log(`Error!`)
    }
}

monthPrinter(2)
monthPrinter(13)