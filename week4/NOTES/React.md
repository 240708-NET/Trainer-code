# React

React is a popular open-source **JavaScript library** for building user interfaces, particularly for single-page applications (SPAs) where the user experience is dynamic and interactive. 

Features:

- Component-Based Architecture
 UI is built using small, reusable pieces called components. Each component has its own HTML structure, behavior (JS/TS) and style

- Virtual DOM
React uses virtual DOM to optimize performance,

- JSX (JavaScript XML)

React components are typically written using JSX, a syntax extension that allows you to write HTML-like code within JavaScript. 

```jsx
function Greeting({ name }) {
  return <h1>Hello, {name}!</h1>;
}
```

## Single Page Applications
A **Single Page Application (SPA)** is a type of web application or website that interacts with the user by dynamically rewriting the current page, rather than loading entire new pages from the server. 

- Single HTML page
- Dynamic Content Loading
- Client-Side Routing
- State Management

Link: https://developer.mozilla.org/en-US/docs/Glossary/SPA

## Webpack

**Webpack** is a module bundler for JavaScript applications. 

Its primary purpose is to **bundle various assets**, such as JavaScript, CSS, images, and HTML files, into a single or a few output files. 

This bundling helps optimize the delivery of these assets to the browser, improving load times and overall performance.

Link: https://webpack.js.org/

## Library vs Framework

A **library** is a collection of pre-written code that developers can use to perform common tasks. Libraries provide specific functionality that can be integrated into your project as needed. You have the control over when and how to use the library within your application.

- You control the flow and decide when to use library's functionality
- More flexibility and can be combined with other libraries or frameworks.

A **framework** is a more comprehensive tool that provides a structured foundation for building applications. Frameworks define the architecture and offer built-in conventions and patterns for developing your application.

- The framework controls the flow and dictates how things should be done.
- Provides a more rigid structure but with comprehensive tools and conventions.

