import { FormEvent, useState } from 'react';
import LoginStyle from '../styles/LoginForm.module.css'

interface RegistrationData{
    Username:string;
    Password:string;
    RoleId: number;
}

const RegistrationForm = () => {

    const [ registrationInfo, setRegistrationInfo] = useState<RegistrationData>({
        Username:"",
        Password:"",
        RoleId:0
    })

    const [notification, setNotification] = useState(null);


    function handleFormSubmission(event: FormEvent<HTMLFormElement>): void {
        
        event.preventDefault();
        fetch(`${process.env.NEXT_PUBLIC_HOST}/api/User/CreateUser`, {
            method: 'POST',
            headers:{
                'Content-Type':'application/json'
            },
            body: JSON.stringify(registrationInfo)
        })
        .then(response => response.text())
        .then(data => {
            setNotification(data);
        })
        .catch(err => console.log(err))

    }

    return(
        <form className={LoginStyle.form} onSubmit = {handleFormSubmission}>
            <h1>Registration Form</h1>
            {
                notification && (<p>{notification}</p>)
            }
            <label>Username</label>
            <input type="text" onChange = {(e) => setRegistrationInfo(prevState => ({...prevState, username:e.target.value}))} required></input>
            <label>Password</label>
            <input type="password" onChange = {(e) => setRegistrationInfo(prevState => ({...prevState, password:e.target.value}))}required></input>
            <label>Role Id</label>

            <input type="number" onChange = {(e) => setRegistrationInfo(prevState => ({...prevState, roleId:parseInt(e.target.value)}))} min="1" max="3"></input>
            <input type = "submit" value="Submit"></input>
        </form>
    )
}

export default RegistrationForm;