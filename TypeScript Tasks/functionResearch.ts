// Named function without type of return value

function addNumbers(x: number, y: number) {
    return x + y;
  }


// Named function with typed return value

function subtractNumbers(x: number, y: number): number {
  return x - y;
}


// Anonymous function

let divideNumbers = function (x: number, y: number): number {
  return x + y;
}
divideNumbers(10, 5);


// Arrow function
let multiplyNumbers = (x: number, y: number): number => x * y;
multiplyNumbers(2, 4);


// Function with rest-parameter

let addAllNumbers = (firstNumber: number, ...restOfNumbers: number[]): number => {
  let total: number =  firstNumber;
  for(let counter = 0; counter < restOfNumbers.length; counter++) {
     if(isNaN(restOfNumbers[counter])) {
        continue;
     }
     total += Number(restOfNumbers[counter]);
  }
  return total;
}
addAllNumbers(1, 5, 7, 8, 8, 5, 45, 3, 4)

console.log(subtractNumbers(18, 10));
console.log(addNumbers(3, 6));