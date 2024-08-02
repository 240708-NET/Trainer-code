import { AppProps } from 'next/app';
import '../styles/style.css'
import React from 'react';


function myApp({Component, pageProps}: AppProps) {

    return <Component {...pageProps} />
}

export default myApp;