function solution(day, age) {
    let result;
    switch (day) {
        case 'Weekday':
            result = (age >= 0 && age <= 18) ? "12$" :
                age <= 64 ? '18$' :
                age <= 122 ? '12$' :
                'Error!'
            break;
        case 'Weekend':
            result = (age >= 0 && age <= 18) ? "15$" :
                age <= 64 ? "20$" :
                age <= 122 ? "15$" :
                'Error!'
            break;
        case 'Holiday':
            result = (age >= 0 && age <= 18) ? "5$" :
                age >=0 && age<= 64 ? "12$" :
                age >=0 && age <= 122 ? "10$" :
                'Error!'
            break;
    }

    console.log(result)
}

solution('Weekday', 42)
solution('Holiday', -12)
solution('Holiday', 15)