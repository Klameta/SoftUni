function attachEvents() {
  const baseUrlLocations =
    "http://localhost:3030/jsonstore/forecaster/locations";
  const baseUrlToday = "http://localhost:3030/jsonstore/forecaster/today/";
  const baseUrl3Days = "http://localhost:3030/jsonstore/forecaster/upcoming/";

  let requestTextInp = document.querySelector("#request input");
  let requestBtnInp = document.querySelector(
    '#request input[value="Get Weather"]'
  );
  let forecastDiv = document.getElementById("forecast");

  let requestText = requestTextInp.value;
  let cityCode = "";
  let cityName = "";

  requestBtnInp.addEventListener("click", async function getLocations() {
    try {
      const response = await fetch(baseUrlLocations);
      const locationInfo = await response.json();
      const locations = Object.entries(locationInfo);

      let hasPassed = false;
      for (const loc of locations) {
        let locObj = loc[1];
        if (requestText === locObj.name) {
          cityCode = locObj.code;
          cityName = locObj.name;
          hasPassed = true;
        }
      }
      if (!hasPassed) {
        throw new Error("Error");
      }

      showForecastToday();
      showForecastFor3Days();
    } catch (e) {
      forecastDiv.style.display = "block";
      forecastDiv.textContent = "Error";
    }
  });

  async function showForecastToday() {
    const response = await fetch(baseUrlToday + cityCode);
    const todayForecastInfo = await response.json();

    const [forecast, name] = Object.values(todayForecastInfo);
    const [condition, high, low] = Object.values(forecast);

    const conditionSymbol =
      condition == "Sunny"
        ? '&#x2600;'
        : condition == "Partly sunny"
        ? '&#x26C5;'
        : condition == "Overcast"
        ? '&#x2601;'
        : condition == "Rain"
        ? '&#x2614;'
        : '&#x176;';

    console.log(conditionSymbol);
  }

  async function showForecastFor3Days() {
    const response = await fetch(baseUrl3Days + cityCode);
    const threeDayForecastInfo = await response.json();

    let [forecast, name] = Object.values(threeDayForecastInfo);
    forecast = forecast.map((f) => Object.values(f));

    console.log(forecast);
  }
}

attachEvents();
