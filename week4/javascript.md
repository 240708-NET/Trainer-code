# Introduction to JavaScript

JavaScript is a high-level, versatile programming language commonly used to create interactive and dynamic web pages. It is a core technology of the web, alongside HTML and CSS, and is essential for building modern web applications.

## What is JavaScript?

JavaScript is an interpreted, object-oriented scripting language that enables you to create and control dynamic content on web pages. It allows you to interact with the user, manipulate the DOM (Document Object Model), and handle events, making web pages more interactive and responsive.

### Key Features

- **Interactivity**: Enables dynamic changes to HTML and CSS, enhancing user experience.
- **Event Handling**: Responds to user actions such as clicks, form submissions, and more.
- **Versatility**: Can be used for both client-side and server-side development (e.g., Node.js).

## Data Types

JavaScript has a set of built-in data types, which are categorized into two groups: primitive types and object types.

### Primitive Data Types

1. **String**: Represents sequences of characters.
   ```javascript
   let name = "Alice";
    ```

2. **Number**: Represents numeric values (integers and floating-point numbers).
   ```javascript
    let age = 30;
    let height = 5.9;
    ```

3. **Boolean**: 
   ```javascript
   let isStudent = true;

    ```
4. **Boolean**: 
   ```javascript
   let isStudent = true;

    ```

5. **Undefined**: Represents a variable that has been declared but not assigned a value.
   ```javascript
   let x;

    ```
6. **Null**:  Represents the intentional absence of any object value.


### Object Data Type

1. **Object**: Represents a collection of key-value pairs.

```js
let person = {
  name: "Alice",
  age: 30,
  isStudent: true
};


```

2. **Array**: A special type of object used for storing ordered collections.

```js
let colors = ["red", "green", "blue"];
```

### Type Coercion
JavaScript performs type coercion, which means it automatically converts between different data types in certain situations. **This can lead to unexpected results.**

```js
let result = "5" + 1; // "51" (string concatenation)
result = "5" - 1;     // 4 (string is coerced to a number)

```
Strict Equality: Use ``===`` and ``!==`` **to avoid type coercion issues.**


### Arrays

Arrays are list-like objects used for storing multiple values in a single variable. They are zero-indexed and can hold elements of any type. **In JavaScript, arrays serve the role of ordered collections, effectively functioning as lists.**

```js
//Create an array
let fruits = ["apple", "banana", "cherry"];
console.log(fruits[0]); // "apple"
fruits.push("orange"); // Adds "orange" to the end
fruits.pop(); // Removes the last element
fruits.forEach(function(fruit) {
  console.log(fruit);
});


```

### Functions

Functions are reusable blocks of code designed to perform specific tasks. They can take inputs (parameters) and return outputs.

```js

function addNumbers(a, b) {
  return a + b;
}

//ES6 array function

const addNumbers = (a,b) => return a + b;

//Invoke function
console.log(addNumbers(2, 3)); // 5

```

### Variable Scope
JavaScript has different types of variable scopes, which determine the visibility and lifespan of variables.


1. **Global Scope**

Variables declared outside of any function or block are in the global scope.

```js
let globalVar = "I'm global";
```

2. **Local Scope**

Variables declared within a function are in the local scope of that function.

```js
function myFunction() {
  let localVar = "I'm local";
}
```

3. **Block Scope (ES6)**
Variables declared with let or const inside a block (e.g., within {}) are block-scoped.

```js
if (true) {
  let blockScoped = "I'm block-scoped";
}
console.log(blockScoped); // ReferenceError

```

### Let and Const

- `let` and `const` are introduced in ES6 (ECMAScript 2015) and offer more control over variable declarations compared to var.

- `let`
    - Block-scoped: Variables declared with let are limited to the block in which they are defined.
    - Reassignable: You can reassign new values to variables declared with let.

- `const`
    - Block-scoped: Variables declared with const are also block-scoped.
    - Immutable Binding: You cannot reassign a new value to a variable declared with const, although the value itself (e.g., objects or arrays) can still be modified.


### Template Literals

Template literals provide a way to work with strings more effectively, allowing for multi-line strings and embedded expressions.


```js
let name = "Alice";
let greeting = `Hello, ${name}!`; // String interpolation

//Multiline strings
let message = `This is a multi-line
string in JavaScript.`;

let a = 5;
let b = 10;
let result = `The sum of ${a} and ${b} is ${a + b}.`;


```