function solve() {
   document.querySelector("#btnSend").addEventListener("click", onClick);
 
   function onClick() {
     let inputText = document.getElementsByTagName("textarea")[0].value;
     let inputArray = Array.from(JSON.parse(inputText));
 
     let restaurants = {};
 
     for (const inputRestaurant of inputArray) {
       let [restaurantName, workersString] = inputRestaurant.split(" - ");
       let workers = workersString.split(", ");
       
       let workersArr = [];
 
       for (const worker of workers) {
         let [name, salary] = worker.split(" ");
         workersArr.push({ name, salary: Number(salary) });
       }
 
       if (restaurants[restaurantName]) {
         restaurants[restaurantName].workers = restaurants[restaurantName].workers.concat(workersArr);
       } else {
         restaurants[restaurantName] = { workers: workersArr };
       }
     }
 
     let maxAvgSalary = -Infinity;
     let restaurantWithMaxAvgSalary = '';
 
     for (const restaurant in restaurants) {
       const workers = restaurants[restaurant].workers;
       let totalSalary = 0; // Initialize total salary for each restaurant
 
       for (const worker of workers) {
         totalSalary += worker.salary; // Calculate total salary by summing up each worker's salary
       }
 
       const workerCount = workers.length;
       const avgSalary = totalSalary / workerCount;
 
       if (avgSalary > maxAvgSalary) {
         maxAvgSalary = avgSalary;
         restaurantWithMaxAvgSalary = restaurant;
       }
     }
 
     if (restaurantWithMaxAvgSalary !== '') {
       const restaurantInfo = restaurants[restaurantWithMaxAvgSalary];
       const sortedWorkers = restaurantInfo.workers.sort((a, b) => b.salary - a.salary);
       
       const workers = sortedWorkers.map(worker => (`Name: ${worker.name} With Salary: ${worker.salary}`));
       const resturant = `Name: ${restaurantWithMaxAvgSalary} Average Salary: ${maxAvgSalary.toFixed(2)} Best Salary: ${sortedWorkers.shift().salary.toFixed(2)}`;
      
       document.querySelector("#bestRestaurant p").textContent = resturant;
       document.querySelector("#workers p").textContent = workers.join(" ");
      }
   }
 }
 