async function getInfo() {
  const baseUrl = "http://localhost:3030/jsonstore/bus/businfo/";
  const stopId = document.getElementById("stopId").value;
  document.getElementById("buses").innerHTML = "";
  stopId.value = "";

  try {
    const response = await fetch(baseUrl + stopId);
    displayBusStopInformation(response);
  } catch (e) {
    document.getElementById("stopName").textContent = "Error";
  }

  function displayBusStopInformation(response) {
    const busStopInfo = response.json();
    const busStopNameElement = document.getElementById("stopName");

    busStopNameElement.textContent = busStopInfo.name;

    displayBusesInfo(busStopInfo.buses);
  }

  function displayBusesInfo(busesArr) {
    let busesUl = document.getElementById("buses");

    for (const [id, minutes] of Object.entries(busesArr)) {
      const busLi = document.createElement("li");
      busLi.textContent = `Bus ${id} arrives in ${minutes} minutes`;
      busesUl.appendChild(busLi);
    }
  }
}
