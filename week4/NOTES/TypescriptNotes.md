# Node.JS

To install TypeScript to your device you have to use Node.JS. This is a runtime environment of JS.

**Node.js** is a tool that allows you to run JavaScript code outside of a web browser.
It is a non-standard I/O. That means When an I/O operation is initiated, Node.js doesn’t wait for it to complete. Instead, it continues executing other code and processes the I/O operation’s result via callbacks or promises once it’s finished. Node.js apps are modular, so we can split it into reusable modules

Node.js has a **package manager** ``npm``, (it's like dotnet uses **NuGet** to manage its packages).

1. Install Node.JS

Link: https://nodejs.org/en/

2. Install typeScript

```bash
npm insall -g typescript
```

3. Verify installation

```bash
tsc --version
```

If you don't want to install TS globally, you can do it locally

1. Navigate to your project
2. Install

```bash
npm install --save-dev typescript
```
3. Configure

```bash
npx tsc --init 
```
NPX - command-line utility that comes with npm and is used to execute binaries from npm packages.


To create a new Node.js project use 

```bash
npm init
```
This will create a package.json file, that contains all nessesary data (dependencies, scripts to run/test your app).

# TypeScript Intro

## JS vs TS

### JavaScript

- **Dynamically** Typed <i>(Variables do not have types and can change types at runtime.)</i>
- Supported by all modern web browsers

### TypeScript

- **Statically** Typed
- Transpiled (compiled) to JavaScript to be run in browsers or on Node.js.


### Benefits

- **Early Error Detection**

    Static type checking helps identify errors during development rather than at runtime.

- **Improved Code Quality**

    Type annotations provide better documentation and can help prevent bugs.

**When to use TypeScript:**
- Large Projects
- Long-Term Maintenance
- Team Environments




