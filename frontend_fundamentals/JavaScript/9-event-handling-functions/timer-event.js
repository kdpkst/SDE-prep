function sayHello() {
    alert("Have a nice day!");
}

function sayHello_() {
    alert("Good day, mate!")
}

// function will be called once after x millisecond
const timer = setTimeout(sayHello, 2000);
// function will be invoked repeatedly every x millisecond
const timer_ = setInterval(sayHello_, 4000);

// () => {} is an arrow function (a shorthand way to write a function) 
setTimeout(() => {
    clearTimeout(timer);
    clearInterval(timer_);
    alert("All timers are cleared!");
}, 10000);