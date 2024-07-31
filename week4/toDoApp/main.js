
let ToDoList = [];

const form = document.querySelector('form');

// Create output for the result
const main = document.querySelector("main");
const output = document.createElement("section");
const unorderedList = document.createElement("ul");

main.appendChild(output);

if(ToDoList.length == 0){
    output.innerHTML = "<p>No tasks!</p>"
}
else{
    output.appendChild(unorderedList);
}

output.style.border = "2px solid red";

form.addEventListener("submit", (e) => {
    e.preventDefault();

    let myTask = {
        description: e.target.elements['task'].value,
        dueDate: document.getElementById("dueDate").value,
    }

    ToDoList.push(myTask);

    unorderedList.innerHTML = "";
    ToDoList.forEach(task => {
        const newTask = document.createElement("li");
        newTask.innerHTML = `${task.description} due date ${task.dueDate}`;
        unorderedList.appendChild(newTask);
    })

})


// Display ToDo List





