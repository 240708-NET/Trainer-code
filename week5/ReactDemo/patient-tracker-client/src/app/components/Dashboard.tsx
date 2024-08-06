import UserContext from "../UserContext";
import { useContext } from "react";
export const Dashboard = () => {

    const { username } = useContext(UserContext);

    return (
        <div>
            <h1>Welcome, {username}!</h1>
            <p>This is your dashboard.</p>
        </div>
    )
}