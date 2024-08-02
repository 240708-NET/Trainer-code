# JavaScript HTTP

## Promises 

A **Promise** is an object representing the eventual completion (or failure) of an asynchronous operation and its resulting value. 

Promises are used to handle asynchronous operations in a more manageable way than traditional callback functions.

```javascript

const myPromise = new Promise((resolve, reject) => {
    setTimeout(() => {
        const success = true; // Simulate success or failure
        if (success) {
            resolve("Operation completed successfully!");
        } else {
            reject("Operation failed.");
        }
    }, 1000);
});

myPromise
    .then((message) => {
        console.log(message); // Handle success
    })
    .catch((error) => {
        console.error(error); // Handle error
    });

```


**Key Concepts:**
- **Pending**: The initial state of a promise. The operation is not yet completed.
- **Fulfilled**: The state when the operation completes successfully.
- **Rejected**: The state when the operation fails.

### Chaining Promises
Promises can be chained to perform multiple asynchronous operations in sequence. Each .then() returns a new promise, allowing for chaining.

## Callback functions
**Callback function** - is a function that you pass as an argument to another function

<i >The main idea is that you use callbacks to specify <b style="color:#23CDF8">what should happen after a certain task is done</b>, making your code more flexible and reusable.</i>

Common example:

```javascript

addEventListener("click", myCallback);
```

```javascript
// Define a function that takes another function as a parameter
function processData(data, callback) {
    // Do something with the data
    console.log("Processing data: " + data);
    
    // Call the callback function with the result
    callback(data);
}

// Define a callback function
function displayResult(result) {
    console.log("Result: " + result);
}

// Call processData and pass displayResult as the callback
processData("Some data", displayResult);

```

## Fetch API
This is a **modern JavaScript API** that allows you to make network requests to servers and handle responses. It provides a more powerful and flexible way to interact with resources over HTTP than older methods like XMLHttpRequest.

**NOTE**: before we used **axios library** to handle this, but right now we have fetch, that is **NATIVE API to js.**

The Fetch API is used to make HTTP requests and handle responses in a simpler, more readable manner. It returns promises, which makes it easy to use with modern asynchronous patterns, such as async/await.

```javascript
fetch('https://jsonplaceholder.typicode.com/posts')
    .then(response => response.json())  // Convert response to JSON
    .then(data => console.log(data))     // Handle the data
    .catch(error => console.error('Error:', error)); // Handle errors


```
**Response** Object - represents our response, it has methods:
- **.ok**: A boolean indicating whether the response was successful (status code in the range 200-299).
- **.status**: The HTTP status code of the response.
- **.statusText**: The HTTP status message.
- **.headers**: The headers of the response.
- **.json()**: A method to parse the response body as JSON.
- **.text()**: A method to parse the response body as plain text.
- **.blob()**: A method to parse the response body as a Blob object (e.g., for binary data).


## Async Await

**Async** and **Await** introduced in ES8 (ECMAScript 2017). 

The <b style="color:#FFDE59">async</b> keyword is used to declare an asynchronous function. 

```javascript
async function myAsyncFunction() {
     return "Data fetched"; // This is wrapped in a promise
}
fetchData().then(data => console.log(data)); // Logs: Data fetched
```

The <b style="color:#FFDE59">await</b> can only be used inside an async function. It pauses the execution of the async function until the promise is resolved or rejected.


```javascript
async function fetchData() {
    try {
        let response = await fetch('https://jsonplaceholder.typicode.com/posts');
        if (!response.ok) {
            throw new Error('Network response was not ok');
        }
        let data = await response.json();
        return data;
    } catch (error) {
        console.error('Error:', error);
    }
}

fetchData();

```

## JSON

JSON stands for JavaScript Object Notation. It is a lightweight data-interchange format that is easy for humans to read and write and easy for machines to parse and generate.

```json
{
    "key1": "value1",
    "key2": "value2",
    "key3": {
        "subKey1": "subValue1"
    }
}
```

#### Convert a JSON string into a JavaScript objects

```javascript

const jsonString = '{"name": "John", "age": 30}';
const obj = JSON.parse(jsonString);
console.log(obj.name); // Output: John
console.log(obj.age);  // Output: 30

```
#### Stringifying JavaScript Objects

```javascript
const obj = {
    name: "Alice",
    age: 25
};

const jsonString = JSON.stringify(obj);
console.log(jsonString); // Output: {"name":"Alice","age":25}


```

# JS Advanced

## This keyword
The  <b style="color:#FFDE59">this</b> keyword in JavaScript is a special identifier that refers to the context in which a function or method is executed. Its value depends on how and where it is used. 

- Global Contex

```javascript
console.log(this); // In a browser, this logs the `window` object
```

- Function Context

```javascript
function show() {
    console.log(this);
}

show(); // Logs the global object (`window` in browsers)
//In strict mode 
//In non-strict mode its refers to global window

```

- Object 

When a function is called as a method of an object, this refers to the object the method is called on.

```javascript
const person = {
    name: "Alice",
    greet: function() {
        console.log(`Hello, ${this.name}`);
    }
};

person.greet(); // Logs: Hello, Alice
```

- Event Handlers

```javascript
document.querySelector('button').addEventListener('click', function() {
    console.log(this); // Logs the button element
});

```

## Strict Mode

Strict mode is a way to opt into a restricted version of the language that helps catch common errors and improve code quality. 

```javascript
"use strict";

var x = 10; // Strict mode is enabled for this script

function myFunction() {
    "use strict";
    var y = 20; // Strict mode is enabled only for this function
}


```

Key Points of strict mode:

- Eliminates ``this`` Coercion

```javascript
"use strict";

function show() {
    console.log(this);
}
show(); // Logs: undefined
```

- Disallows Undeclared Variables
- Prevents Duplicate Parameter Names


## Arrow Functions

Arrow functions are a concise way to write functions in JavaScript, introduced in ECMAScript 6 (ES6). 

```javascript
const square = x => x * x;
console.log(square(5)); // Output: 25

const add = (a, b) => a + b;
console.log(add(3, 4)); // Output: 7

```

# JEST testing

Jest is a popular testing framework for JavaScript that simplifies the process of writing and running tests. 

Official website: https://jestjs.io/

```javascript
npm install --save-dev jest

//add to your package.json
"scripts": {
  "test": "jest"
}

```
```javascript
// sum.js
function sum(a, b) {
  return a + b;
}
module.exports = sum;

// sum.test.js
const sum = require('./sum');

test('adds 1 + 2 to equal 3', () => {
  expect(sum(1, 2)).toBe(3);
});

```

Execute your tests using the ```npm test``` or command.
