type Task = {
    description:string,
    dueDate: string
}

const toDoList: Task[] = [];


const form = document.querySelector<HTMLFormElement>('form');
// Create output for the result
const outputContainer = document.querySelector<HTMLUListElement>('#output_container');

//Grab our input element
const taskInput = document.querySelector<HTMLInputElement>('#task');


if(form){
    form.addEventListener('submit', (event: Event) => {
        event.preventDefault();
        //console.log("test");

        const target = event.target as HTMLFormElement;

        const taskDescription = target.elements.namedItem('task') as HTMLInputElement;
        const taskDueDate = target.elements.namedItem('dueDate') as HTMLInputElement;

        if(taskDescription && taskDueDate){
            const newTask: Task = {
                description: taskDescription.value,
                dueDate: taskDueDate.value
            }

            toDoList.push(newTask);

            if(outputContainer){
                outputContainer.innerHTML = "";
                toDoList.forEach((task) => {
                    const listItem = document.createElement('li');
                    listItem.textContent = `${task.description} - Due Date: ${task.dueDate}`;
                    outputContainer.appendChild(listItem);
                })

            }
        }


    })
}
