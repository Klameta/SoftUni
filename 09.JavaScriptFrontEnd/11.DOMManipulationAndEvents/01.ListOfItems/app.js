function addItem() {
    const inputText = document.getElementById("newItemText");
    const listOfItems = document.getElementById("items");

    let li = document.createElement("li");
    li.textContent = inputText.value;
    listOfItems.appendChild(li)
}