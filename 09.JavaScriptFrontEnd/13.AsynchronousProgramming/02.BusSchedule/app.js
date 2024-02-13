function solve() {
  const baseUrl = "http://localhost:3030/jsonstore/bus/schedule/";
  let nextBusId = "depot";
  let currentBusName = "";

  let departBtn = document.getElementById("depart");
  let arriveBtn = document.getElementById("arrive");
  let resultOutput = document.querySelector(".info");

  async function depart() {
    try {
      const response = await fetch(baseUrl + nextBusId);
      const busInfo = await response.json();

      const [name, next] = Object.entries(busInfo);

      nextBusId = next[1];
      currentBusName = name[1];
      resultOutput.textContent = `Next stop ${currentBusName}`;
      departBtn.disabled = "disabled";
      arriveBtn.disabled = "";
    } catch (e) {
      resultOutput.textContent = "Error";
      departBtn.disabled = "disabled";
      arriveBtn.disabled = "disabled";
    }
  }

  function arrive() {
    resultOutput.textContent = `Arriving at ${currentBusName}`;

    departBtn.disabled = "";
    arriveBtn.disabled = "disabled";
  }

  return {
    depart,
    arrive,
  };
}

let result = solve();
