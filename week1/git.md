## Version Control Systems

### What is the VCS?

It is software tools that help manage changes to source code, documents, or any set of files over time.

#### Key aspects and benefits:

- **Tracking Changes**: records changes made to files
- **Versioning**: stores multiple versions of files. So we can compare them and revert to previous states
- **Collaboration**: enables multiple developers to work on the same codebase simultaneously.
- **Backup and Recovery**: By storing every change, VCS acts as a backup system.


## Centralized and Desentrilized VCS

**Centralized** Single central repository that stores all versions of files. 
Developers check out a working copy of files from the central repository to their local machines. They make changes locally and then commit those changes back to the central repository.

**Decentralized / Distributed** - each developer has a complete copy (clone) of the entire repository, including its history, on their local machine. No need for network access to explore history.

## GIT

Git is a **decentralized/Distributed** Control Version System. 

**Git Repository** -  tracks and saves the history of all changes made to the files in a Git project. 

- To set up: https://git-scm.com/
- Configure

```
git config --global user.name "Your Name"
git config --global user.email "email@example.com"

```

### Three States

- Modified (you changed the file, but have not ocmmited to database yet)
- Staged (marked a modified file in its current version to go into your next snapshot)
- Commited (data is safely stored in your local database)

### Three Main Sections of a Git project

- Working Tree: a signle checkout of one version of the project on your local machine. Set of files and folders a developer can add, edit and remove.
- Staging area. This is a file in Git directory, that stores info about what will go into your next commit. (another name is index)
- Git directory. Place where git stores the metadata and objects db for your project. This is what is copied when you clone a repository

### Git workflow

- You modify files in your working directory
- You selectively stage just those changes you want to be part of your next commit, which add onlt those changes to the staging area
- You commit the changes, which takes the files as they are and stores that snapshot in Git directory.


### Basic GIT Commands

- Initializing a Repository

```bash
git init
```


- Tracking Changes

```bash

```
- Committing Changes

```bash
git add .
git commit -m "Your message goes here"



```
- Branching and Merging

**Branch**

```
```


**Merge Conflicts**

```bash

```

- Working with Remotes

```

```

### .gitignore 


**Always make sure you don't track sensitive info**, such as connection strings, API keys, and others.

Example of a typical workflow:

```bash


```
