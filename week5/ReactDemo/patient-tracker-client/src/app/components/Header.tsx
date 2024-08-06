'use client';
import { useContext, useEffect, useState } from "react";
import UserContext from "../UserContext";
import { UserData } from "./UserData"
import HeaderStyle from '../styles/HeaderStyle.module.css';

interface HeaderProps{
    onLogout: () => void;
}

export const Header:React.FC<HeaderProps> = (props) => {


    const {username, setUsername} = useContext(UserContext);
    const [isUserLogged, setUserLoginStatus] = useState(username != "User");

    
    useEffect(() => {
        setUserLoginStatus(username !== "User");
    }, [username])
    

    const onLogout = () =>{
        setUsername("User");
        setUserLoginStatus(false);
    }
    return(
        <header id={HeaderStyle.header}>
            <UserData></UserData>
            <nav>
                <ul>
                    <li className={HeaderStyle.li}>Home</li>
                    <li className={HeaderStyle.li}>About</li>
                    <li className={HeaderStyle.li}>Contacts</li>
                </ul>
            </nav>
                    { //Conditional rendering
                        isUserLogged && (
                            <button onClick={onLogout}>Logout</button>)                  
                    }

        </header>
                

    )
    
}
