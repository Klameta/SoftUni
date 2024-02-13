function extractText() {
    const items = document.querySelectorAll("li")
    const textArea = document.getElementById("result")
    
    for (const item of items) {
        textArea.value+=item.textContent + "\n";
    }
}