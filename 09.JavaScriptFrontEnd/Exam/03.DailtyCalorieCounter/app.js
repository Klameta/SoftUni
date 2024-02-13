const baseUrlMeals = "http://localhost:3030/jsonstore/tasks";

const addMealBtn = document.getElementById("add-meal");
const loadMealsBtn = document.getElementById("load-meals");
const editMealsBtn = document.getElementById("edit-meal");

const mealList = document.getElementById("list");

const foodElInput = document.getElementById("food");
const timeElInput = document.getElementById("time");
const caloriesElInput = document.getElementById("calories");

let meals = [];

loadMealsBtn.addEventListener("click", loadMeals);

async function loadMeals() {
  let response = await fetch(baseUrlMeals);
  let info = await response.json();
  mealList.innerHTML = "";

  Object.values(info).forEach((item) => {
    let meal = {
      id: item._id,
      food: item.food,
      time: item.time,
      calories: item.calories,
    };

    let div = document.createElement("div");
    let foodH = document.createElement("h2");
    let timeH = document.createElement("h3");
    let caloriesH = document.createElement("h3");
    let btns = document.createElement("div");

    div.className = "meal";

    foodH.textContent = meal.food;
    timeH.textContent = meal.time;
    caloriesH.textContent = meal.calories;

    btns.id = "meal-buttons";

    let changeBtn = document.createElement("button");
    changeBtn.className = "change-meal";
    changeBtn.textContent = "Change";

    let deleteBtn = document.createElement("button");
    deleteBtn.className = "delete-meal";
    deleteBtn.textContent = "Delete";

    deleteBtn.addEventListener("click", async function deleteMeals() {
      fetch(`${baseUrlMeals}/${meal.id}`, {
        method: "DELETE",
      });

      div.parentElement.removeChild(div);
    });

    changeBtn.addEventListener("click", async function changeMeals() {
      foodElInput.value = meal.food;
      timeElInput.value = meal.time;
      caloriesElInput.value = meal.calories;

      div.remove();

      editMealsBtn.disabled = false;
      addMealBtn.disabled = true;
      editMealsBtn.addEventListener("click", async function editMeals() {

        let meal1 = {
            calories: caloriesElInput.value,
            food: foodElInput.value,
            time: timeElInput.value,
          };

        await fetch(`${baseUrlMeals}/${meal.id}`, {
          method: "PUT",
          body: JSON.stringify(meal1),
        });

        foodElInput.value = "";
        timeElInput.value = "";
        caloriesElInput.value = "";

        editMealsBtn.disabled = true;
        addMealBtn.disabled = false;

        loadMeals();
      });
    });

    btns.appendChild(changeBtn);
    btns.appendChild(deleteBtn);

    div.appendChild(foodH);
    div.appendChild(timeH);
    div.appendChild(caloriesH);
    div.appendChild(btns);

    mealList.appendChild(div);
  });
}

addMealBtn.addEventListener("click", function addMeals() {
  const food = foodElInput.value;
  const time = timeElInput.value;
  const calories = caloriesElInput.value;

  foodElInput.value = "";
  timeElInput.value = "";
  caloriesElInput.value = "";

  let isValid = food != "" && time != "" && calories != "";

  if (isValid) {
    let meal = {
      calories,
      food,
      time,
    };

    fetch(baseUrlMeals, {
      method: "POST",
      body: JSON.stringify(meal),
    });
  }

  loadMeals();
});
