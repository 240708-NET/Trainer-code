# Introduction to HTML

## 1. Introduction to HTML

**What is HTML?**
- HTML stands for HyperText Markup Language.
- It is the standard language for creating webpages.
- HTML describes the structure of webpages using a system of tags and attributes.

**Why Learn HTML?**
- HTML is foundational for web development.
- It allows you to create structured documents that can be displayed in web browsers.
- Understanding HTML is essential for building websites and web applications.

## 2. Basic Structure of an HTML Document

An HTML document is made up of elements, which are defined by tags. Here’s a basic template:

```html
<!DOCTYPE html>
<html>
<head>
    <title>Document Title</title>
</head>
<body>
    <h1>Welcome to HTML</h1>
    <p>This is a paragraph.</p>
</body>
</html>

```

- **!DOCTYPE html**: Declares the document type and version of HTML.
- **html**: Root element that contains the whole HTML document.
- **head**: Contains meta-information about the document (e.g., title, character set).
- **title**: Sets the title of the document (displayed in the browser’s title bar or tab).
- **body**: Contains the content of the document that is visible to users.
- **h1**: Defines a top-level heading.
- **p**: Defines a paragraph.


# Common HTML Tags

## Structure
- `<html>`: Root element of an HTML document.
- `<head>`: Contains meta-information about the HTML document.
- `<title>`: Specifies the title of the document (shown in the browser's title bar or tab).
- `<body>`: Contains the content of the HTML document.

## Text Formatting
- `<h1>` to `<h6>`: Headings (e.g., `<h1>` is the largest, `<h6>` is the smallest).
- `<p>`: Paragraph.
- `<strong>`: Defines important text (bold).
- `<em>`: Defines emphasized text (italic).
- `<br>`: Line break.
- `<hr>`: Horizontal rule (line).

## Links and Images
- `<a>`: Anchor (hyperlink).
- `<img>`: Embeds an image.

## Lists
- `<ul>`: Unordered list.
  - `<li>`: List item.
- `<ol>`: Ordered list.
  - `<li>`: List item.

## Tables
- `<table>`: Defines a table.
- `<tr>`: Defines a table row.
- `<th>`: Defines a table header cell.
- `<td>`: Defines a table data cell.

## Forms
- `<form>`: Defines an HTML form for user input.
- `<input>`: Defines an input control.
- `<textarea>`: Defines a multi-line text input control.
- `<button>`: Defines a clickable button.
- `<select>`: Defines a drop-down list.
- `<option>`: Defines an option in a drop-down list.

## Semantics
- `<div>`: Defines a division or section.
- `<span>`: Defines a section in a document (inline).
- `<header>`: Defines a header for a document or section.
- `<footer>`: Defines a footer for a document or section.
- `<article>`: Defines an independent, self-contained content.
- `<section>`: Defines a section in a document.
- `<nav>`: Defines navigation links.
- `<aside>`: Defines content aside from the content it is placed in.

## Multimedia
- `<audio>`: Defines sound content.
- `<video>`: Defines video content.
- `<source>`: Specifies multiple media resources for elements like `<video>` and `<audio>`.

## Scripts
- `<script>`: Defines client-side JavaScript.
- `<noscript>`: Defines an alternative content for users who have disabled scripts.

## Meta Information
- `<meta>`: Defines metadata about an HTML document.
- `<link>`: Defines the relationship between a document and an external resource (most used for linking stylesheets).

## Styles
- `<style>`: Defines style information (CSS) for a document.


## HTML Document Structure and Dom

- An HTML document follows a specific structure that is fundamental to creating web pages. Here’s a basic outline of the structure:

```html
<!DOCTYPE html>  
<!-- that defines this document as HTML5. It helps the browser to render the page correctly.-->
<html lang="en"><!--Root element that wraps the entire HTML document. The lang attribute specifies the language of the document..-->
<head> <!--Contains meta-information about the document. -->
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document Title</title>
    <link rel="stylesheet" href="styles.css">
    <script src="script.js" defer></script>
</head>
<body>
    <header>
        <h1>Welcome to My Website</h1>
    </header>
    <nav>
        <ul>
            <li><a href="#home">Home</a></li>
            <li><a href="#about">About</a></li>
            <li><a href="#contact">Contact</a></li>
        </ul>
    </nav>
    <main>
        <section id="home">
            <h2>Home Section</h2>
            <p>This is the home section.</p>
        </section>
        <section id="about">
            <h2>About Section</h2>
            <p>This is the about section.</p>
        </section>
        <section id="contact">
            <h2>Contact Section</h2>
            <p>This is the contact section.</p>
        </section>
    </main>
    <footer>
        <p>&copy; 2024 My Website</p>
    </footer>
</body>
</html>


```

**Content Sections:** The `<header>`, `<nav>`, `<main>`, and `<footer>` elements define the layout and structure of the content. They also called semantic tags


### DOM (Document Object Model)
The Document Object Model (DOM) is a programming interface for web documents. It represents the document as a tree structure where each node corresponds to a part of the document.

- **Tree Structure**: The DOM represents the HTML document as a tree of nodes, where each node represents an element, attribute, or piece of text. For example:

- **Nodes**:  The DOM tree is composed of different types of nodes: 
    - Element Nodes (`div`, `p`)
    - Text Nodes (text within elements)
    - Attribute Nodes (`id`, `class`)


The DOM allows you to manipulate the structure, style, and content of a document using JavaScript. 

For example, you can change an element's content, modify its attributes, or add new elements dynamically.

```js
// Example: Changing the content of an element with the id "home"
document.getElementById('home').innerHTML = 'Updated content!';

```

### Elements and attributes

HTML elements are the building blocks of an HTML document. An element typically consists of a **start tag, content, and an end tag**. Some elements can be self-closing.

```html
<ul>
  <li>Item 1</li>
  <li>Item 2</li>
</ul>

```

#### HTML Attributes

Attributes provide additional information about an HTML element. They are always included in the opening tag and are written as name-value pairs.

```html
<div id="uniqueId">Content</div>

<p class="text-primary">This is a primary text.</p>

<a href="https://www.example.com">Example</a>

<img src="image.jpg" alt="Description">

<input type="text" placeholder="Enter text">

<input type="submit" value="Submit">

<form action="/submit" method="post">
  <!-- form elements here -->
</form>

```

### Inline and Block Elements

**Block elements**, or block-level elements, generally start on a new line and take up the full width available to them. 
Examples: `<h1>-<h6>`, `<p>`, `<div>`, `<ul>`, `<section>`, `<article>`, `<header>`

**Inline elements** do not start on a new line. They only take up as much width as necessary, and they flow within the content of a block element. Inline elements are often used for formatting text and other small parts of a web page.
Examples: `<a>`, `<span>`, `<strong>`, `<img>`

```html
<div>
  <p>This is a <strong>bold</strong> paragraph with a <a href="#">link</a>.</p>
</div>

```


### HTML Forms

HTML forms are essential for collecting user input on web pages. They allow users to submit data that can be processed by a server or used in various ways. Forms are used in various scenarios, such as user registrations, logins, surveys, and feedback.


### Basic structure

```html

<form action="/submit" method="post">
    <!-- Form elements go here -->
    <input type="text" name="username" placeholder="Enter your username">
    <input type="password" name="password" placeholder="Enter your password">
    <input type="submit" value="Submit">
</form>

```
`<form>` - This tag defines the start and end of the form. It contains attributes that specify where and how the form data should be sent.

`<action>` - Specifies the URL to which the form data will be sent when the form is submitted. If omitted, the data will be submitted to the same URL as the form.

#### Form elements

- `<input>`

    ```html
    <input type="text" name="username" placeholder="Enter your username">
    <input type="password" name="password" placeholder="Enter your password">
    <input type="checkbox" name="subscribe" value="newsletter"> Subscribe to newsletter
    <input type="radio" name="gender" value="male"> Male
    <input type="radio" name="gender" value="female"> Female
    <input type="submit" value="Submit">

    ```

- `<textarea >`

```html
<textarea name="comments" rows="4" cols="50" placeholder="Enter your comments"></textarea>

```

- `<select>`. We can allow user to choose one or multiple options 

**Single-Selection Drop-Down List**
```html
<select name="country">
  <option value="us" selected>United States</option>
  <option value="ca">Canada</option>
  <option value="uk">United Kingdom</option>
</select>
```

**Multi-Selection Drop-Down List**

```html
<label for="multiSelect">Choose your favorite fruits:</label>
<select id="multiSelect" name="fruits" multiple>
  <option value="apple">Apple</option>
  <option value="orange">Orange</option>
  <option value="banana">Banana</option>
  <option value="grape">Grape</option>
</select>

```
We use `multiple` to allow users to select multiple options

- `<fieldset>`

```html
<fieldset>
  <legend>Personal Information</legend>
  <input type="text" name="firstName" placeholder="First Name">
  <input type="text" name="lastName" placeholder="Last Name">
</fieldset>
```

### HTML Validation

```html
<form>
  <label for="name">Name:</label>
  <input type="text" id="name" name="name" required>
  <input type="number" id="age" name="age" min="1" max="100" required>
  <label for="phone">Phone:</label>
<input type="text" id="phone" name="phone" pattern="\d{3}-\d{3}-\d{4}" placeholder="123-456-7890" required>
  <input type="submit" value="Submit">
</form>


```