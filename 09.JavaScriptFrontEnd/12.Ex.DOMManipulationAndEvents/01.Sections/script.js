function create(words) {
   let content = document.getElementById("content");
   
   words.forEach(word => {
      let div = document.createElement("div");
      let p = document.createElement("p");
      
      p.style.display = "none"
      p.textContent = word;

      div.appendChild(p);
      content.appendChild(div)
   });

   let divs = Array.from(content.children);
   divs.forEach(div => {
      div.addEventListener("click", (e)=>{
         let target = e.target.firstChild;
         target.style.display = "block"
      })
   });
}