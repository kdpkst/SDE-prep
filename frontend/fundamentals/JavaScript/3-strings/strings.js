const name = "Jax";
const age = 23;
const greeting = "Hello! my name is " + name + ". I am " + age + ".";
const betterGreeting = `Hello! my name is ${name}. I am ${age}.`;

console.log(greeting);
console.log(betterGreeting);

// numbers to strings
const num = 10;
const str = `${num}`;

// strings to numbers
const strInt = 40;
const numInt = parseInt(strInt);
const strFloat = 7.4461;
const numFloat = parseFloat(strFloat);

// useful functions and properties of strings
const myString = "How are you doing?";
console.log(myString.length);
// slice(start, end) with start inclusive and end exclusive 
console.log(myString.slice(4, 9));
console.log(myString.indexOf("r"));
console.log(myString.charAt(6));
console.log(myString.toLowerCase());




