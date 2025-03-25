const x = 100;
// array is unbounded and can contain any kind of data in JS 
const arr = ["stuff", 4, x, 3.14];
console.log(arr[0]);
console.log(arr[3]);
console.log(arr[4]);

let vegetables = ["spinach", "potato", "eggplant"];
// elements in the gap will be set to undefined/empty
vegetables[4] = "cabbage";
// add elements to the end of an array
vegetables.push("carrot");
// add elements to the beginning
vegetables.unshift("onion");
console.log(vegetables);

let onion = vegetables.shift();
let carrot = vegetables.pop();
console.log(`Removed the first element: ${onion}`);
console.log(`Removed the last element: ${carrot}`);
console.log(`Array: ${vegetables}`);

