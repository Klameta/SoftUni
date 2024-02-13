function focused() {
    let inputFields = Array.from(document.querySelectorAll("input"));

    for (const inputField of inputFields) {
        inputField.addEventListener('focus', focusedCard)
        inputField.addEventListener('blur', blurCard)
        
    }
    
    function focusedCard(event) {
        let parent = event.target.parentElement;
        parent.classList.add("focused")
    }

    function blurCard(event) {
        let parent = event.target.parentElement;
        parent.classList.remove("focused")
    }
}