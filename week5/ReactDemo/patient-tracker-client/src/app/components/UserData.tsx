'use client'

import { useState, useContext  } from "react";
import HeaderStyle from '../styles/HeaderStyle.module.css';
import UserContext from "../UserContext";

// One line props passing
export const UserData = () => {

    const { username, setUsername } = useContext(UserContext);
    return(
        <div id={HeaderStyle.userDataContainer}>
             <h3>Welcome, {username}</h3>
        </div>
       
    )
}