'use client';
import Image from "next/image";
import styles from "./page.module.css";
import { Header } from "./components/Header";
import { useState, useContext } from "react";
import { LoginForm } from "./components/LoginForm";
import { Dashboard } from "./components/Dashboard";
import UserContext from "./UserContext";

export default function Home() {

  const { username, setUsername } = useContext(UserContext);

  //const [currentUserName, setcurrentUserName] = useState("Vlada");

  const handleLogout = () => {
    setUsername("User")
  }

  return (
    <>
        <Header onLogout={handleLogout}></Header>
        
        {
          username === "User" ? <LoginForm></LoginForm> : <Dashboard ></Dashboard>
        }
        
    </>

  );
}
