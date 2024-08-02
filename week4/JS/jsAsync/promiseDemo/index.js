let pizzaDelivery = new Promise ((resolve, reject) =>{

    //Do something you want 

    let pizzaDelivered = true;
    
    if(pizzaDelivered){
        resolve("Pizza delivered!");
    }
    else{
        reject("Pizza delivery failed!");
    }
})
//Promise was resolved with "Pizza delivered!"


.then((message) => { // parameter 
    console.log(message); // handle success message
})
.catch((error) => {
    console.log(message) // Handle errors
});
