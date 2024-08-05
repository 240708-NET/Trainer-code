'use client';
import Image from "next/image";
import styles from "./page.module.css";
import { Header } from "./components/Header";
import { useState } from "react";
import { LoginForm } from "./components/LoginForm";
import { Dashboard } from "./components/Dashboard";

export default function Home() {

  const [currentUserName, setcurrentUserName] = useState("Vlada");


  const handleLogin = () => {
    setcurrentUserName("Vlada")
  }

  const handleLogout = () => {
    setcurrentUserName("User")
  }

  return (
    <>
        <Header username={currentUserName} onLogout={handleLogout} onLogin = {handleLogin}></Header>
        
        {
          currentUserName === "User" ? <LoginForm></LoginForm> : <Dashboard username={currentUserName}></Dashboard>
        }
        
    </>

  );
}
