//const form = document.getElementById('#myForm');

const buttn = document.getElementById('sbBtn');
buttn.addEventListener('click', function(e){
    e.preventDefault();
    //console.log('SUBMIT');
    //const location = e.target.elements['city'].value;
    const location = document.querySelector("#city").value;
    const apiKey = 'YOUR API'; //BAD PRACTICE
    const url = `https://api.openweathermap.org/data/2.5/forecast?q=${location}&cnt=2&units=metric&appid=${apiKey}`;

    fetch(url)
       .then(response => response.json())
       .then(data => {

        if(data.cod === "200"){
            const weather  = data.list[1];
            const date = new Date().toLocaleDateString();
            console.log(weather);
        }

       })
       .catch(error => console.error('Error:', error));
})