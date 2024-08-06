import LoginStyle from '../styles/LoginForm.module.css'
import UserContext from '../UserContext';
import { useContext, useState } from 'react';
export function LoginForm(){

    const { setUsername } = useContext(UserContext);
    const [currentInputValue, setCurrentInputValue] = useState("");

    const handleFormSubmit = (e) => {
        e.preventDefault();
        setUsername(currentInputValue);
    }

    return(
            <form id={LoginStyle.form} onSubmit={handleFormSubmit}>
                <h1>Login</h1>
                <label>Username:</label>
                <input type="text" required  value = {currentInputValue} onChange = {(e) => setCurrentInputValue(e.target.value)} placeholder="Type your username..."></input>

                <label>Password:</label>
                <input type="password" required></input>

                <input type="submit" value="Login"></input>
            </form>
    )
}