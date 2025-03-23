function sayHi() {
    alert("Hi~~");
}

const startButton = document.querySelector("#b1");
const stopButton = document.querySelector("#b2");
let timer = null;

startButton.addEventListener("click", function() {
    if (timer == null) {
        timer = setInterval(sayHi, 2000);
    }
});

stopButton.addEventListener("click", function() {
    if (timer != null) {
        clearInterval(timer);
        timer = null;
    }
});

