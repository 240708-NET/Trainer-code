
export const Dashboard = ({username} : {username:string}) => {

    return (
        <div>
            <h1>Welcome, {username}!</h1>
            <p>This is your dashboard.</p>
        </div>
    )
}