# CSS


CSS (Cascading Style Sheets) is a stylesheet language used to describe the presentation of a document written in HTML or XML. CSS controls the layout, colors, fonts, and overall appearance of web pages. It separates the content from the design, making web development more manageable and flexible.

### External CSS

External CSS involves linking an external stylesheet to your HTML document. 

This method is preferred for maintaining a clean separation between content (HTML) and presentation (CSS)

**Create an External CSS File:** Write your CSS rules in a separate .css file. For example, create a file named styles.css.

```css
/* styles.css */
body {
  font-family: Arial, sans-serif;
  background-color: #f4f4f4;
}

```

```html
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
  <link rel="stylesheet" href="styles.css"> <!--here is the link>

```

### Internal CSS

```html
<!-- index.html -->
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
  <style>
    body {
      font-family: Arial, sans-serif;
      background-color: #f4f4f4;
    }

    h1 {
      color: #333;
      text-align: center;
    }

    .container {
      width: 80%;
      margin: 0 auto;
    }
  </style>
</head>
<body>
  <div class="container">
    <h1>Welcome to My Website</h1>
    <p style="font-size:20px">This is a paragraph styled with internal CSS.</p>
  </div>
</body>
</html>

```

## CSS Selectors

1. Element Selector 
```css 
p {
  color: blue;
}
```
2.  Class Selector
```css 
.myClassName{
  color: blue;
}
```
3. ID Selector
```css 
#myIdName{
  color: blue;
}
```
4. Attribute Selector
```css 
input[type="text"] {
  border: 1px solid #ccc;
}
```
5. Pseudo-Classes
```css 
a:hover {
  color: red;
}
```
6. Pseudo-Elements
```css 
p::first-line {
  font-weight: bold;
}
```

### CSS Properties

1. **Text properties**

`<color>`: Sets the text color.
`<font-size>`: Sets the size of the font.
`<font-family>`: Specifies the font family.
`<text-align:>` Aligns text (left, center, right, justify).

```css
p {
  color: #333;
  font-size: 16px;
  font-family: 'Verdana', sans-serif;
  text-align: center;
}

```

2. **Box Model**
The box model consists of margins, borders, padding, and the content itself.

- `<width>` and `<height>`: Define the size of the element.
- `<padding>`: Space between content and border.
- `<border>`: Surrounds padding and content.
- `<margin>`: Space outside the border.

```css
div {
  width: 300px;
  height: 200px;
  padding: 10px;
  border: 1px solid black;
  margin: 20px;
}


```

3. **Background Properties**
-  `<background-color>`: Sets the background color.
-  `<background-image>`: Sets an image as the background.
-  `<background-size>`: Specifies the size of the background image.
-  `<background-position>`: Defines the position of the background image.

Link: https://www.w3schools.com/Css/
https://developer.mozilla.org/en-US/docs/Web/CSS/Reference


### Cascading Nature of CSS
Specificity is a measure of how specific a selector is. The more specific a selector, the higher its priority in the cascade.

**Cascade Order**

- **Inline Styles**: Highest priority.
- **ID Selectors**: Higher priority than class, attribute, and pseudo-class selectors.
- **Class, Attribute, and Pseudo-class Selectors**: Higher priority than element and pseudo-element selectors.
- **Element and Pseudo-element Selectors**: Lowest priority among specific selectors.
- **Source Order**: Within selectors of the same specificity, later rules override earlier ones.
- **!important:** Highest priority for individual properties.

## Responsive Web Design

 1. **Media Queries**

Media queries are a fundamental feature of CSS that allows you to apply different styles based on the characteristics of the device or viewport, such as its width, height, resolution, and orientation.

```css
@media (max-width: 600px) {
  body {
    font-size: 14px;
  }
}
```
2.**Viewport Meta Tag**
The viewport meta tag helps control the layout on mobile browsers. It ensures that your web page scales correctly and fits the screen size.

```html
<meta name="viewport" content="width=device-width, initial-scale=1.0">

```
3. **Fluid Layouts**
Fluid layouts use relative units like percentages instead of fixed units like pixels. This allows elements to resize proportionally based on the viewport size.

```css
.container {
  width: 80%; /* 80% of the viewport width */
  margin: 0 auto; /* Center the container */
}

.column {
  width: 50%; /* 50% of the container width */
}

```

## Grid and FlexBox

CSS Grid and Flexbox are two modern layout systems that offer powerful tools for designing complex and responsive web layouts. 


```css
```css
.container {
  display: grid;
  grid-template-columns: 1fr 2fr 1fr; /* Defines three columns */
  grid-template-rows: auto; /* Defines row heights */
  gap: 10px; /* Gap between grid items */
}

```

Grid works in x and y axes

### Flexbox
Flexbox (Flexible Box Layout) is a one-dimensional layout system that allows you to align items along a row or column. It’s ideal for simpler layouts or when you need to align elements within a single dimension.

```css
.container {
  display: flex;
  flex-direction: row; /* or column */
  justify-content: center; /* Align items on the main axis */
  align-items: center; /* Align items on the cross axis */
  gap: 10px; /* Gap between items */
}


```

Link: https://flexboxfroggy.com/


### CSS Variables
CSS Variables, also known as CSS Custom Properties, are a feature introduced in CSS that allows you to define reusable values that can be used throughout your stylesheet. They help make your CSS more maintainable, flexible, and easier to manage.

```css
:root {
  --primary-color: #3498db;
  --font-size: 16px;
}

/*To use it*/

body {
  color: var(--primary-color);
  font-size: var(--font-size);
}

```
