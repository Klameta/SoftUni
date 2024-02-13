function addItem() {
    const text  = document.getElementById("newItemText").value;
    const value  = document.getElementById("newItemValue").value;

    let newOption = document.createElement("option");
    newOption.text = text + value;

    const dropDown = document.getElementById("menu");
    dropDown.appendChild(newOption);

    document.getElementById("newItemText").value ="";
     document.getElementById("newItemValue").value = "";
}