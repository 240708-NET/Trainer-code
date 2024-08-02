import { NextPage } from 'next';


const Home: NextPage = () => {

    return(
        <div>
            <h1>Weather App</h1>
            <form id="myForm">
                <input type="text" name="city" required placeholder="Type your city"  id="city" />
                <button id="sbBtn">Get Weather</button>
            </form>
            <section id="result_container">
                <ul></ul>
            </section>
        </div>
    )
}


export default Home;