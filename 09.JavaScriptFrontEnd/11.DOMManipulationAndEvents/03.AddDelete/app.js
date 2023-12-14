function addItem() {
    const inputText = document.getElementById("newItemText");
    const listOfItems = document.getElementById("items");

    let li = document.createElement("li");
    li.textContent = inputText.value;
    
    let a = document.createElement("a");
    a.textContent = "[Delete]"
    a.href = "#";

    a.addEventListener('click', deleteItem);
    
    li.appendChild(a);
    listOfItems.appendChild(li)

    function deleteItem(a) {
        li.remove();
    }
}