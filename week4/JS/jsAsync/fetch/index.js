/*
const button = document.querySelector('button');
const resultSection = document.createElement('ul');
document.body.appendChild(resultSection);

/*
button.addEventListener('click', function() {

    fetch("https://jsonplaceholder.typicode.com/posts", {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
    })

    .then((res) => res.json())
    .then((data) => {
        data.forEach(element => {
            const elementNode = document.createElement('li');
            elementNode.innerHTML = `${element.title} ${element.body}`;
            resultSection.appendChild(elementNode);
        })
    });

})




async function getMyData() {

    try{

        const response = await fetch('https://jsonplaceholder.typicode.com/posts');
      
        if(!response.ok){
            throw new Error('something went wrong');
        }

        const data = await response.json();
        console.log(data);
    }

    catch(err){
        console.error(err);
    }
}

getMyData();

*/

//JSON to JS object

/*

const jsonData = '{"name": "John", "age": 30, "city": "New York"}';
const jsonObject = JSON.parse(jsonData); // JSON to JS object

console.log(jsonObject.name);
//console.log(jsonObject);


const obj = {
    name: 'John',
    age: 30,
    city: 'New York',
}

const jsonString = JSON.stringify(obj); // JS object to JSON

*/

//Global Context
console.log(this);


// Global
function show(){ 
    console.log(this);
}

show(); // if in strict mode logs the global object in window


