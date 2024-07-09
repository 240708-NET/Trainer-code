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
git status  // check status of file
git add . // Adding files to the staging area:
```
- Committing Changes

```bash
git commit -m "Commit message" // Committing staged changes 
```
- Branching and Merging

**Branch**

When we working on a new feature, we need to make sure our current version is not going to be affected, and our code will not break. So we have branching. To checkout to new branch we use a command:
```
git branch branch-name // Creating a new branch
git checkout branch-name // Switching branches 
```

Merging is a way of putting a forked history back together again. The git merge command lets you take the independent lines of development created by git branch and integrate them into a single branch.

**Merge Conflicts**
When multiple developers push their code to the remote repo without pulling the most updated version we might have a merge conflict.
In this case, we can resolve it using Bash. 

```bash
git branch branch-name // Creating a new branch
git checkout branch-name // Switching branches 
git merge branch-name // Merging branches
```

- Working with Remotes

```
git clone <remote-url> // Cloning a remote repository
git remote add origin <remote-url> // Adding a remote

```

### .gitignore 

Used to specify files and directories that Git should ignore. When Git scans your working directory for changes to track, it looks at all files unless they are specified in .gitignore.

 - "*" is used as a wildcard match.
- / is used to ignore pathnames relative to the .gitignore file.
- "#" is used to add comments to a .gitignore file.
- ** can be used to match any number of directories.
- ! to negate a file that would be ignored.



**Always make sure you don't track sensitive info**, such as connection strings, API keys, and others.

Example of a typical workflow:

```bash
git pull origin <branch-name> // get new updates from the remote repository

After you made some changes, you can add it to staging area and commit

git add .
git commit -m "My first commit"
git push origin <branch-name>

```
