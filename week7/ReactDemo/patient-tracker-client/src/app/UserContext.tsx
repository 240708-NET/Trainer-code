"use client"

import {useState, useContext, createContext } from 'react';
 const UserContext = createContext(null); // default value

export const UserProvider = ({ children }) => {

    const [username, setUsername] = useState("User"); // initialize user with default value

    return(
        <UserContext.Provider value={{ username, setUsername }}>
            {children}
        </UserContext.Provider>
    )
}


export default UserContext;