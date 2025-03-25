let person = {
    name: "Walter White",
    age: 52,
    job: "cook",
    spouse: "Skyler",
    PhoneNumbers: [
        {type: "home", number: "212-55-1234"},
        {type: "mobile", number: "123-456-7908"}
    ],
    quote: "Say my name"
}

const walterStr = JSON.stringify(person);
console.log(walterStr);
const walter = JSON.parse(walterStr);
console.log(walter);

const body = document.querySelector("body");
const heading = document.createElement("h1"); 
heading.textContent = "Breaking Bad leading role info";
body.appendChild(heading);

for (let key in walter) {
    let para = document.createElement("p");
    para.textContent = `${key}: ${walter[key]}`;
    body.appendChild(para);
}