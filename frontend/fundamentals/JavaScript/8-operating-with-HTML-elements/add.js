const para = document.createElement("p");
para.innerText = "Paragraph starts here...";
para.style.color = "green";
para.style.fontFamily = "Arial";

const div = document.querySelector(".container");
div.appendChild(para);
