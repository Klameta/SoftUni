function solve(grade) {
  let gradeWord = "";
  if (grade < 3) {
    gradeWord = "Fail";
  } else if (grade < 3.5) {
    gradeWord = "Poor";
  } else if (grade < 4.5) {
    gradeWord = "Good";
  } else if (grade < 5.5) {
    gradeWord = "Very Good";
  } else {
    gradeWord = "Excellent";
  }

  console.log(`${gradeWord} (${grade.toFixed(2)})`);
}
solve(4)