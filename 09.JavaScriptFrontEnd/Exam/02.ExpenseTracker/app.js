window.addEventListener("load", solve);

function solve() {
  const previewList = document.getElementById("preview-list");

  const addBtn = document.getElementById("add-btn");

  addBtn.addEventListener("click", () => {
    addBtn.disabled = true;
    
    let expenseTypeElInput = document.getElementById("expense");
    let amountElInput = document.getElementById("amount");
    let dateElInput = document.getElementById("date");

    const expenseType = expenseTypeElInput.value;
    const amount = amountElInput.value;
    const date = dateElInput.value;

    expenseTypeElInput.value = ""
    amountElInput.value = ""
    dateElInput.value = ""
    const isValid = expenseType != "" && amount != "" && date != "";

    if (isValid) {
      const expenseTypeEl = document.createElement("p");
      const amountEl = document.createElement("p");
      const dateEl = document.createElement("p");

      expenseTypeEl.textContent = `Type: ${expenseType}`;
      amountEl.textContent = `Amount: ${amount}$`;
      dateEl.textContent = `Date: ${date}`;

      const article = document.createElement("article");
      const li = document.createElement("li");
      const buttonsDiv = document.createElement("div");
      const editBtn = document.createElement("button");
      const okBtn = document.createElement("button");

        editBtn.addEventListener('click', ()=>{
            expenseTypeElInput.value = expenseTypeEl.textContent.split(": ")[1];
            amountElInput.value = amountEl.textContent.split(": ")[1].split("$")[0];
            dateElInput.value =  dateEl.textContent.split(": ")[1];

            previewList.innerHTML = '';
            addBtn.disabled = false;
        });

        okBtn.addEventListener('click', ()=>{
            let expenseItem = document.createElement('li');
            let expenses = document.getElementById('expenses-list')
            expenseItem.className="expense-item"
            expenseItem.appendChild(li);
            expenses.appendChild(expenseItem)
            li.removeChild(buttonsDiv);

            
            previewList.innerHTML = '';
            addBtn.disabled = false;
        })

      editBtn.textContent = "edit";
      okBtn.textContent = "ok";

      buttonsDiv.className = "buttons";
      li.className = "expense-item";
      editBtn.className = "btn edit";
      okBtn.className = "btn ok";

      previewList.appendChild(li);
      li.appendChild(article);
      article.appendChild(expenseTypeEl);
      article.appendChild(amountEl);
      article.appendChild(dateEl);
      buttonsDiv.appendChild(editBtn);
      buttonsDiv.appendChild(okBtn);
      li.appendChild(buttonsDiv);
    }
  });

  const deleteBtn = document.querySelector('#expenses button');
  deleteBtn.addEventListener('click', ()=>{
    console.log('delete');
    window.location.reload();
  })
}
