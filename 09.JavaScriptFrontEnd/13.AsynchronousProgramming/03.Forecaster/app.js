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

      getForecastToday();
      showForecastFor3Days();
    } catch (e) {
      forecastDiv.style.display = "block";
      forecastDiv.textContent = "Error";
    }
  });

  async function getForecastToday() {
    const response = await fetch(baseUrlToday + cityCode);
    const todayForecastInfo = await response.json();

    const [forecast, name] = Object.values(todayForecastInfo);
    const [condition, high, low] = Object.values(forecast);

    outPuttingShowForecastToday(name, condition, high, low);
  }

  function outPuttingShowForecastToday(name, condition, high, low) {
    {
      const conditionSymbol =
        condition == "Sunny"
          ? "☀️"
          : condition == "Partly sunny"
          ? "⛅"
          : condition == "Overcast"
          ? "☁️"
          : condition == "Rain"
          ? "☔"
          : "°";

      let forecastDiv = document.createElement("div");
      let spanCondSym = document.createElement("span");
      let spanName = document.createElement("span");
      let spanLowHigh = document.createElement("span");
      let spanCond = document.createElement("span");
      let forecastDataSpan = document.createElement("span");

      forecastDiv.className = "forecasts";
      forecastDataSpan.className = "condition";

      spanCondSym.textContent = conditionSymbol;
      spanName.textContent = name;
      spanLowHigh.textContent = `${low}°/${high}°`;
      spanCond.textContent = condition;

      spanCondSym.classList.add("symbol");
      spanName.classList.add("forecast-data");
      spanLowHigh.classList.add("forecast-data");
      spanCond.classList.add("forecast-data");

      forecastDiv.appendChild(spanCondSym);
      forecastDataSpan.appendChild(spanName);
      forecastDataSpan.appendChild(spanLowHigh);
      forecastDataSpan.appendChild(spanCond);

      let currentDivId = document.getElementById("current");
      let forecastDivId = document.getElementById('forecast');
      forecastDivId.style.display = "block";

      currentDivId.appendChild(forecastDiv);
      currentDivId.appendChild(forecastDataSpan);

      console.log(currentDivId);
      console.log(forecastDiv);
      console.log(forecastDataSpan);
    }

    
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