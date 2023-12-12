function editElement(element, match,replaceWord) {
    const content = element.textContent;
    const matcher = new RegExp(match, "g");
    const edited = content.replace(matcher, replaceWord);

    element.textContent = edited
}