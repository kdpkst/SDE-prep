const greeting = "hello world!";
// x === y is true if x equals to y and of the same type
// x !== y is true if x does not equal to y or is not the same type
console.log(greeting === "hello world!");
console.log(greeting.charAt(1) === "e");
// 42 is a number, while "42" is a string 
console.log(`42 === \"42\": ${42 === "42"}`);
// `==` checks if values are equal, but allows type conversion (Different types may be converted before comparison)
console.log(`42 == \"42\": ${42 == "42"}`);