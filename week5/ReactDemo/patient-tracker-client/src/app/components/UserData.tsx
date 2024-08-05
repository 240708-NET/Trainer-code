'use client'

import { useState } from "react";
import HeaderStyle from '../styles/HeaderStyle.module.css';


// One line props passing
export const UserData = ({username}:{username:string}) => {

    return(
        <div id={HeaderStyle.userDataContainer}>
             <h3>Welcome, {username}</h3>
        </div>
       
    )
}