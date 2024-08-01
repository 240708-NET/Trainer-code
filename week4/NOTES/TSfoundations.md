# Special Types and Objects Types


### Special Types

* `unknown`: Represents any value but is safer because it’s not legal to do anything with the value.
    ```
    function f2(a: unknown) {
        a.b();    // Error: 'a' is of type 'unknown'.
    }
    ```

* `never`: Use for functions that never return a value
    ```
    function fail(msg: string): never {
        throw new Error(msg);
    }
    ```

* `any`: Use to bypass typechecking errors.
    ```
    let obj: any = { x: 0 };
    // None of the following lines of code will throw compiler errors.
    // Using `any` disables all further type checking, and it is assumed
    // you know the environment better than TypeScript.
    obj.foo();
    obj();
    obj.bar = 100;
    obj = "hello";
    ```

* `undefined` and `null`: primitive values used to signal absent or uninitialized value.


### Object Types
The fundamental way to group and pass around data.

1. Interface
    ```
    interface Person {
        name: string;
        age: number;
    }
    ```

2. Type Alias
    ```
    type Person = {
        name: string;
        age: number;
    };
    ```

3. Anonymous Type
    ```
    function greet(person: { name: string; age: number }) {
        return "Hello " + person.name;
    }
    ```
## Utility Types
Several utility types that "facilitate common type transformations".\
These are basically methods to create a new type with modified properties of an existing type.
- Awaited<Type>: Models await/async functions or the .then() method for Promises
- Partial<Type>: All properties are optional
- Required<Type>: All properties are required (Opposite of Partial)
- Readonly<Type>: All properties are readonly (useful for representing assignment expressions that will fail at runtime)
- Record<Keys, Type>: It's a dictionary
- Record<Type>: Shortcut to defining an object type with a specific
- Pick <Type, Keys>: Type based on another, 'picking' it's properties
- Omit<Type, Keys>
- Exclude<UnionType, ExcludedMembers>
- Extract<Type, Union>
- NonNullable<Type>
- Parameters<Type>
- ConstructorParameters<Type>
- ReturnType<Type>
- InstanceType<Type>: Creates a type with the instance type of constructor
- NoInfer<Type>: Blocks inferences to the contained type
- ThisParameterType<Type> Extracts the type of 'this' parameter for a function
- OmitThisParameter<Type>: Removes the 'this' parameter from type
- ThisType<Type>: Sets the type of the type when refered to as 'this'
[Intrinsic String Manipulation Types]
- Uppercase, Lowercase, Capitalize, Uncapitalize


- Omit<Type, Keys>: removes keys
- Pick<Type, Keys> removes all but specified keys
- Exclude<UnionType, ExcludedMembers>: removes types from a union
- ReturnType<Type>: extract the return type of a function type


## Union Types
- Union types are used when a value can be more than a single type.
- Union Types allow you to define a variable that can hold one of several types. This is useful when a value could be one of multiple types, giving you more flexibility in how you use that value.
- A union type is created using the | (pipe) operator between types.
```js
function foo(value: any){
    if(typeof value === "number"){
        //do thing A
    }else if(typeof value == "string"){
        //do thing B
    }else{
        throw new Error("Only accepts number or string");
    }
}

foo(42); // this will do thing A
foo("test"); // this will do thing B
foo(true); // this will be a syntax error

function boo(value: string | number){
    //do thing C
}

bar(42); // this will do thing C
bar("test"); // this will also do thing C
bar(true); //this will be a syntax error
```
 Union types can also share commom behavior.

```js
interface Bird {
  fly(): void;
  layEggs(): void;
}
 
interface Fish {
  swim(): void;
  layEggs(): void;
}

//this function returns either a Fish or a Bird
declare function getSmallPet(): Fish | Bird;

let pet = getSmallPet();
//layEggs is shared between Fish and Bird and this runs 
pet.layEggs();
//only Fish has swim(), and this is a syntax error
pet.swim();
```
# Type Guards

A type guard is some expression that performs a runtime check that guarantees the type in some scope.
They enhance type safety by checking the varible types using typeof, instanceof, or custom type guard functions.

Source: `https://www.typescriptlang.org/docs/handbook/advanced-types.html`

Without type guards, JavaScript does not allow for property accessors
``` javascript

    // Problem
    let pet = getSmallPet();  

    // You can use the 'in' operator to check
    if ("swim" in pet) {
    pet.swim();
    }
    // However, you cannot use property access
    if (pet.fly) {
    //Errors:
    //Property 'fly' does not exist on type 'Fish | Bird'.
    //Property 'fly' does not exist on type 'Fish'.
    pet.fly();
    //Errors:
    //Property 'fly' does not exist on type 'Fish | Bird'.
    //Property 'fly' does not exist on type 'Fish'.
    }

    //-----------------------------------------------------

    // Solution - using a User-Defined Type Guard
    function isFish(pet: Fish | Bird): pet is Fish {
        return (pet as Fish).swim !== undefined;
    }

    // Now, calls to both 'swim' and 'fly' are okay
    let pet = getSmallPet();
    
    if (isFish(pet)) {
    pet.swim();
    } else {
    pet.fly();
    }
    //TypeScript also knows that in the context of this if-else, if a pet cannot swim, then it is not a Fish, so it must be a Bird
```

# Built-in Type Guards

- instanceOF: built int type guard that checks if a value is an instance of a class

    ``` javascript 
    objectVariable instanceof ClassName;
    ```

- typeof :used to determine type of variable. However has a limited scope can only recognize
    - boolean
    - string
    - bigint
    - symbol
    - undefined
    - function
    - number

    ``` javascript 
    var obj = 2;
    obj typeof number;
    ```

# Keyof - "as const"

## Keyof
- Key can be String or Numeric.
- makes a unique identifier/ object, and creates a union between a collection of values.

### Documentation
Ex. 1
``` javascript
type Point = { x: number; y: number };
type P = keyof Point;
```
so, P: x | y

Ex. 2
``` javascript
type Example = {name: string; age: number; 42: boolean;};
type Keys = keyof Example; // "name" | "age" | 42
```
## "as const"
- makes an array immutable
- makes an array readonly

### Documentation
Ex. 1
``` javascript
const myArray = [1, 2, 3]; //myArray can be changed
const myArray = [1, 2, 3] as const; //myArray cannot be changed
```

Ex. 2
``` javascript
const person = { 
    name: 'John', 
    age: 30, 
    hobbies: ['reading', 'coding' 'gaming'] as const
};
```

# Target and Compiler Options

Compiler options are used to change the compiler’s default operation. The compiler options needed to compile the project along with the root files are defined by the **tsconfig.json** file. The "compilerOptions" property can be omitted, in which case the compiler’s defaults are used.

## Target

The target option specifies the version of JavaScript the TypeScript compiler should transpile your code into. By default, it’s set to ES3, but you can adjust it to match your target environment. For instance, if you’re deploying to older environments, setting it to ES5 ensures compatibility.

Default:
- ES3
Allowed:
- es3
- es5
- es6/es2015
- es2016
- es2017
- es2018
- es2019
- es2020
- es2021
- es2022
- es2023
- esnext


## Example Configuration

```sh
{
  "compilerOptions": {
    "target": "es5",
    "module": "commonjs",
    "sourceMap": true,
    "outDir": "out",
    "noImplicitAny": true,
  }
}
```


**`Target`**: The target option specifies the version of JavaScript the TypeScript compiler should transpile your code into. By default, it’s set to ES3, but you can adjust it to match your target environment. For instance, if you’re deploying to older environments, setting it to ES5 ensures compatibility.

**`Module`**: The module option determines the module system you’re using, such as CommonJS, AMD, or ES6 modules. It impacts how your compiled TypeScript code interacts with local files and node_modules.

**`SourceMap`**: When sourceMap is set to true, TypeScript generates source maps, which allow you to debug your TypeScript code even after compilation.

**`OutDir`**: The outDir option specifies the directory where the compiled JavaScript files will be placed.

**`NoImplicitAny`**: Turning on noImplicitAny however TypeScript will issue an error whenever it would have inferred any