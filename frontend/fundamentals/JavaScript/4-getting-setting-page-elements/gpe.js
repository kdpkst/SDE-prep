// querySelector() returns the first HTML element
const elem1 = document.querySelector("p");
const elem2 = document.querySelector("#myP");
const elem3 = document.querySelector("ol > .item");
const elem4 = document.querySelector("li:nth-child(2)");
console.log(elem1);
console.log(elem2);
console.log(elem3);
console.log(elem4);

// querySelectorAll() returns an array of all HTML elements
const allParagraph = document.querySelectorAll("p");
const allListItems = document.querySelectorAll("ol > li");
console.log(allParagraph);
console.log(allListItems);