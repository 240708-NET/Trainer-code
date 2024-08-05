'use client';
import { useState } from "react";
import { UserData } from "./UserData"
import HeaderStyle from '../styles/HeaderStyle.module.css';

interface HeaderProps{
    username: string; 
    onLogout: () => void;
    onLogin: () => void;
}

export const Header:React.FC<HeaderProps> = (props) => {

    const [isUserLogged, setUserLoginStatus] = useState(true);

    const handleUserLoging = () =>{

        if(isUserLogged){
            setUserLoginStatus(false);
            props.onLogout();
            
        }
        else{
            setUserLoginStatus(true);
            props.onLogin();
        }
    }

    return(
        <header id={HeaderStyle.header}>
            <UserData username ={props.username}></UserData>
            <nav>
                <ul>
                    <li className={HeaderStyle.li}>Home</li>
                    <li className={HeaderStyle.li}>About</li>
                    <li className={HeaderStyle.li}>Contacts</li>
                </ul>
            </nav>
            
            <button onClick={handleUserLoging}>{isUserLogged ? "Logout": "Login"}</button>
        </header>
    )
}
