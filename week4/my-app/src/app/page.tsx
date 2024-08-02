import Image from "next/image";
import pageStyle from "./page.module.css";
import { Header } from "./components/Header";

interface User{

  name: string;
  age: number;
  email: string;
}

export default function Home() {

  const username:string = "Michael";

  /** 
  const sum = (a:number, b:number) => {
    return a * b;
  }
*/


  const UserList: User[] = [
    {
      name: "John Doe",
      age: 30,
      email: "john.doe@example.com"
    },
    {
      name: "Jane Smith",
      age: 28,
      email: "jane.smith@example.com"
    },
    {
      name: "Mike Johnson",
      age: 35,
      email: "mike.johnson@example.com"
    }
  ]

  return (
    
    <main>
      <Header></Header>
      { 
      //I WANT to make a comment here 
      }
      <h1 id={pageStyle.newHeading}>Hello {username}</h1>
      <h3>My user list</h3>
      {
        UserList.map((user, index) => (
          <div key={index}>
            <h4>{user.name}</h4>
            <p>Age: {user.age}</p>
            <p>Email: {user.email}</p>
          </div>
        ))
      }

    </main>
   
  );
}
