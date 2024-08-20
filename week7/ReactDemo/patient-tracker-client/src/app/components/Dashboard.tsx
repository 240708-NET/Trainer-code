import UserContext from "../UserContext";
import { useContext, useEffect, useState } from "react";

interface User{
    username: string,
    roleId: number
}

type UserList = User[]

export const Dashboard = () => {

    const { username } = useContext(UserContext);
    const [userList, setUserList] = useState(null);

    useEffect(() => {

        //Call our backend here
        fetch(`${process.env.NEXT_PUBLIC_HOST}/api/User/ListAllUsers`, 
            {
            method: 'GET',
            headers:{
                'Content-Type': 'application/json'
            }
        })
        .then(response => response.json())
        .then(data => {
            setUserList(data);
        })
        .catch(err => console.error(err))

    }, [])

    return (
        <div>
            <h1>Welcome, {username}!</h1>
            <ul>
                {
                    userList.map((user, index) => {
                        return <li key={index}>{user.username}</li>
                    })
                }
            </ul>
           
        </div>
    )
}