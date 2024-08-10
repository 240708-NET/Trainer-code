import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';

import App from './App';
import About from './About';
import Post from './Post';

import reportWebVitals from './reportWebVitals';
import {
  createBrowserRouter,
  RouterProvider
} from 'react-router-dom'

const router = createBrowserRouter([
  {
    path: '/',
    //exact: true,
    element: <App />
  },
  {
    path: '/about',
    element: <About />
  },
  {
    path:'/post',
    element: <Post />
  },
  {
    path:'/post/:id',
    element: <Post />
  }
]);

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <RouterProvider router={router}></RouterProvider>
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
