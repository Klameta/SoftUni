function search() {
  const searchTextEl = document.querySelector("#searchText");
  const searchWord = searchTextEl.value;

  let listNodes = Array.from(document.querySelector('ul li'));
  let listWords = Array.from(document.querySelectorAll("ul li")).map(
    (node) => node.textContent
  );
  listNodes.forEach((node) => {
    node.style["font-weight"] = "normal";
    node.style["text-decoration"] = "none";
  });
  let filteredWords = listWords.filter((word) => word.includes(searchWord));

  const matches = Array.from(document.querySelectorAll("ul li")).filter(
    (node) => filteredWords.includes(node.textContent)
  );
  matches.forEach((node) => {
    node.style["font-weight"] = "bold";
    node.style["text-decoration"] = "underline";
  });

  const numberOfMatches = matches.length;
  const resultNode = document.querySelector("#result");
  resultNode.textContent = `${numberOfMatches} matches found`;
}
