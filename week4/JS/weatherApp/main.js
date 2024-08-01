//const form = document.getElementById('#myForm');
const result_container = document.getElementById("result_container");
const buttn = document.getElementById('sbBtn');
buttn.addEventListener('click', function(e){
    e.preventDefault();
    //console.log('SUBMIT');
    //const location = e.target.elements['city'].value;
    const location = document.querySelector("#city").value;
    const apiKey = 'DO NOT PUT YOUR API KEY HERE'; //BAD PRACTICE
    const url = `https://api.openweathermap.org/data/2.5/forecast?q=${location}&cnt=2&units=metric&appid=${apiKey}`;

    fetch(url)
       .then(response => response.json())
       .then(data => {

        if(data.cod === "200"){
            console.log(data);
            const weather  = data.list[1];
            const date = new Date().toLocaleDateString();
            const temp = weather.main.temp;
            const feelsLike = weather.main.feels_like;
            
            result_container.innerHTML = `
                <p>Date: ${date}</p>
                <p>Temperature: ${temp}</p>
                <p>Feels Like: ${feelsLike}</p>
            `
        }
        else{
            console.log("No data")
        }

       })
       .catch(error => console.error('Error:', error));
})