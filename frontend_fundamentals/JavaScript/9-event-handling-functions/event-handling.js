function handleButton1Click(event) {
    alert(event);
}

// can get the element using `this` 
function handleButton2Click() {
    console.log(this);
}

const button1 = document.querySelector("#b1");
const button2 = document.querySelector("#b2");
button1.addEventListener("click", handleButton1Click);
button2.addEventListener("click", handleButton2Click);