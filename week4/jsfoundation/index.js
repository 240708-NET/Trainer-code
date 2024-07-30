
const form = document.querySelector('form');
let output = document.querySelector('#output');

const submitBtn = document.querySelector("#SubmitBtn");

const addBtn = document.querySelector('#add');
const subBtn = document.querySelector('#substract');
const divBtn = document.querySelector('#divide');
const multiplyBtn = document.querySelector('#multiply');

let isActitonSet = null;

let result = document.createElement('p');
output.appendChild(result);


/**Style submit button */

submitBtn.style.backgroundColor = "#FF7F50";
submitBtn.style.margin = "10px 0 0 0";

submitBtn.addEventListener("mouseover", function(){
    submitBtn.style.backgroundColor = "#994C30";
})

submitBtn.addEventListener("mouseout", function(){
    submitBtn.style.backgroundColor = "#FF7F50";
})


form.addEventListener('submit', function(event) {
    
    result.textContent = "";
    event.preventDefault();
    //Grab value of the first number
    const firstNumber = event.target.elements['numberOne'].value;
    //const firstNumber = document.querySelector('#numberOne').value;
    const secondsNumber = event.target.elements['numberTwo'].value;

    // Display output on the screen
    if(isActitonSet != null){

        selectAction(firstNumber, secondsNumber, isActitonSet);

    }

})




// Set event listeners for 
addBtn.addEventListener('click', (e) => {
    clearElements();
    isActitonSet = "+";
    addBtn.setAttribute("class", "selectedBtn");

})

subBtn.addEventListener('click', (e) => {
    clearElements();
    isActitonSet = "-";
    subBtn.setAttribute("class", "selectedBtn");
})

divBtn.addEventListener('click', (e) => {
    clearElements();
    isActitonSet = "/";
    divBtn.setAttribute("class", "selectedBtn");
})

multiplyBtn.addEventListener('click', (e) => {
    clearElements();
    isActitonSet = "*";
    multiplyBtn.setAttribute("class", "selectedBtn");
})

/* Function to change button for internal call

function ChangeColor(event){
    //event.preventDefault(); //prevent default behavior

    //const clickedButton = document.querySelector('#add');
    console.log(event);
    //const clickedButton = event.target;
    event.style.backgroundColor = "red";

}

*/
//Old (befoe ES6) way

function selectAction (firstNumber, secondsNumber, action, output){
    //Your code goes here
    
    switch(action){
        case '+':
            //Add code to add two numbers
            result.textContent = Number(firstNumber) + Number(secondsNumber);
            break;
        case'-':
            //Add code to subtract two numbers
            result.textContent = Number(firstNumber) - Number(secondsNumber);
            break;
        case'*':
            //Add code to multiply two numbers
            result.textContent = Number(firstNumber) * Number(secondsNumber);
            break;
        case '/':
            //Add code to divide two numbers
            let outcome = Number(firstNumber) / Number(secondsNumber);
            result.textContent = Number(firstNumber) % Number(secondsNumber) == 0 ? outcome : outcome.toFixed(2);
            break;
        default:
            result.textContent = "Invalid action!";
    }
    
   
}


function clearElements(){

    const buttons = document.querySelectorAll(".selectedBtn");
    buttons.forEach(button => button.removeAttribute("class", "selectedBtn"));
}


// New way
/*
const calculate = (firstNumber, secondsNumber) => {

    return something;
}
    */


  




//Variables Scopes 

/*Global Scope -- all functions can */

let myGlobal = 6; // everyone can access me!


/*Local scope */

function myFunction() {
    let myLocal = 9; // only myFunction can access me!
}

/* ES6  Block scope*/

if(false){
    let myBlockLocal = 12; // only inside this block can access me!
}
