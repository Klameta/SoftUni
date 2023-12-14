function solve() {
  let boughtProducts = [];
  let totalPrice = 0;

  let addButtons = Array.from(document.querySelectorAll("button.add-product"));
  let textArea = document.querySelector("textarea");
  let chechoutButton = document.querySelector(".checkout");

  addButtons.forEach((btn) => {
    btn.addEventListener("click", adding);
  });

  function adding(e) {
    const currentProduct = e.currentTarget.parentNode.parentNode;

    const productTitle =
      currentProduct.querySelector(".product-title").textContent;
    const productPrice = Number(
      currentProduct.querySelector(".product-line-price").textContent
    );

    if (!boughtProducts.includes(productTitle)) {
      boughtProducts.push(productTitle);
    }
    totalPrice += productPrice;

    textArea.value += `Added ${productTitle} for ${productPrice} to the cart.\n`;
  }

  chechoutButton.addEventListener("click", (e) => {
    textArea.value += `You bought ${boughtProducts.join(
      ", "
    )} for ${totalPrice.toFixed(2)}`;

    addButtons.forEach((btn) => {
      btn.removeEventListener("click", adding);
    });
  });
}
