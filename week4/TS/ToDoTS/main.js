"use strict";
const toDoList = [];
const form = document.querySelector('form');
// Create output for the result
const outputContainer = document.querySelector('#output_container');
//Grab our input element
const taskInput = document.querySelector('#task');
if (form) {
    form.addEventListener('submit', (event) => {
        event.preventDefault();
        //console.log("test");
        const target = event.target;
        const taskDescription = target.elements.namedItem('task');
        const taskDueDate = target.elements.namedItem('dueDate');
        if (taskDescription && taskDueDate) {
            const newTask = {
                description: taskDescription.value,
                dueDate: taskDueDate.value
            };
            toDoList.push(newTask);
            if (outputContainer) {
                outputContainer.innerHTML = "";
                toDoList.forEach((task) => {
                    const listItem = document.createElement('li');
                    listItem.textContent = `${task.description} - Due Date: ${task.dueDate}`;
                    outputContainer.appendChild(listItem);
                });
            }
        }
    });
}
