## Database Structure

**Database** - structured collection of data that is organized in such a way that it can be easily accessed, managed, and updated. 

## Types of Databases
Databases can be categorized based on their data model and architecture. 

- **Relational Databases**: Organize data into tables with rows and columns, using structured query language (SQL) for querying and manipulation (e.g., MySQL, PostgreSQL, Oracle).

- **NoSQL Databases**: Designed for handling unstructured, semi-structured, or rapidly changing data (e.g., MongoDB, Cassandra, Redis).


## DB Structure

- **Schema**:  defines the structure of the database. It includes descriptions of tables (entities), columns (attributes), relationships between tables (foreign keys), and other database objects (indexes, views, procedures).

- **Table**: collection of related data organized into rows (also known as tuples) and columns (also known as attributes or fields).

```sql
CREATE TABLE [IF NOT EXISTS] table_name(  
    column_definition1,  
    column_definition2,  
    ........,  
    table_constraints  
);

CREATE TABLE Books (
    Book_ID INT PRIMARY KEY,
    Title VARCHAR(100),
    Author VARCHAR(50),
    Genre VARCHAR(50),
    Publisher VARCHAR(50),
    Publish_Year INT,
    ISBN VARCHAR(20)
);

/*ADD A NEW VALUE*/
INSERT INTO table_name VALUE("Mr.Bean", "comedy", "Mr.ABC", 2019);

/*DELETE TABLE FROM DB*/

DROP TABLE table_name;
/*DELETE ALL RECORDS FROM THE TABLE*/
TRUNCATE TABLE table_name;

/*MODIFY TABLE*/

ALTER TABLE table_name
ADD column_name datatype; /*Add a new column*/

ALTER TABLE table_name
DROP column_name datatype; /*Remove a column*/

ALTER TABLE table_name
MODIFY column_name datatype; /*Modify a column*/

```

- **Constraints**: Constraints are rules and conditions applied to data within the database to enforce data integrity and consistency.

**Examples**: 
- primary keys (unique identifiers for each row), 
- foreign keys (to establish relationships between tables), 
- unique constraints (ensuring values in a column are unique), 
-  check constraints (validating data values against specified conditions).

## Data Modeling

**Entity Relationship Diagram (ERD)** - entity Relationship Diagram is a graphical representation depicting the relationships among data objects within a database. These entities, such as people, objects or concepts relate to one another within the database.


## SQL (Structured Query Language)

**SQL** is a standard language for interacting with relational databases. It allows users to perform various operations such as:

- Data Querying: Retrieve specific data from the database.
- Data Manipulation: Insert, update, and delete records.
- Data Definition: Define and modify the structure of tables and schemas.
- Data Control: Grant and revoke permissions on objects


## SQL Datatypes

- Character: stores fixed number of bytes
```sql
middle_initial char(1);
```
- Variable-length character types: stores variabls number of bytes
```sql
middle_initial varchar(20);
```
- Numeric:  store type of numbers either whole or fractional
```sql
annual_income decimal(10,2);
avg_temp float(10);
age int;
annual_income decimal(10,2);
```
- Date (format YYYY-MM-DD)
```sql
dob date
```
- Time (format HH:MM:SS)
```sql
received_at time
```
- Timestamp (format YYYY-MM-DD HH:MM:SS.)

```sql
created_at timestamp;
```


## Normalization
Process used to organize a database schema into tables and columns to reduce redundancy and dependency, thereby improving data integrity and efficiency of the database. 

#### Normalization forms

1. First Normal Form (1NF)
    Each row needs to have a primary key, and each field needs to contain a single value.
    **Objective**: Eliminate repeating groups and ensure each column contains atomic (indivisible) values.
    **Key Points:**
    - Each table cell should contain a single value.
    - Columns should be identified uniquely (usually by a primary key).
    - There should be no repeating groups or arrays of data.

2. Second Normal Form (2NF)

    **Objective**: Remove partial dependencies by ensuring that non-key attributes are fully dependent on the primary key.
   Any column that is not the primary key needs to depend on the primary key. If it doesn't, we need to solve that.
    **Key Points:**
    - The table should be in 1NF.
    - All non-key attributes should be fully dependent on the primary key.
    - No partial dependencies, where part of a composite key determines the values of other columns.
4. Third Normal Form (3NF)

    **Objective**: Eliminate transitive dependencies by ensuring that non-key attributes are not dependent on other non-key attributes.

    **Key Points:**
    - The table should be in 2NF.
    - All non-key attributes should be directly dependent on the primary key.
     A "transitive functional dependency" means that every attribute that is not the primary key is dependent on only the primary key.
    - No transitive dependencies (occurs when a non-key attribute in a table is functionally dependent on another non-key attribute, rather than directly on the primary key), where a non-key attribute depends on another non-key attribute.

## Multiplicity & Cardinality

**Cardinality** in database design refers to the relationship between rows of two tables.
efines the number of instances of one entity that can or must be associated with each instance of another entity

- One-to-One (1:1)
- One-to-Many 
- Many-to-One (N:1)
- Many-to-Many


**Multiplicity** - specify the minimum and maximum number of instances that can participate in a relationship

- **Minimum Multiplicity**: possible range of associations between one entity and another. It can be 0 (optional participation) or 1 (mandatory participation).

Example:

- **Entities**:  Student, Course
- **Relationship**: Enrollment (Many-to-Many)

**Cardinality**: 
A student can enroll in many courses, and each course can have many students enrolled (Many-to-Many relationship)

**Multiplicity**:
- Minimum Multiplicity: A student must enroll in at least one course (1).
- Maximum Multiplicity: A student can enroll in many courses (many).

## Constraints 

- **Primary key**:  constraint that is used to uniquely identify each record in a table.
Primary keys must contain values that are UNIQUE and NOT NULL. 

**A table can have only a single primary key.**


- **Composite key** - a combination of columns used to uniquely identify a table.

- **Foreign key** - a field (or collection of fields) in one table, that refers to the PRIMARY KEY in another table.

- **Unique key** - constraint is used to ensure every value of a column is different. This means that each row must have a distinct value in the specified column.

- **Secondary Alternate key** - candidate key is a column or a combination of columns that uniquely identifies each row in a table.

```sql
CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    Barcode VARCHAR(20) UNIQUE,
    Name VARCHAR(100),
    Description TEXT,
    Price DECIMAL(10, 2)
);

```
- **ProductID** is the primary key of the table.
- **Barcode** is a candidate key since the column is marked as UNIQUE, ensuring each value in that column is unique.



### DML Language

Data Modification Language is the SQL language subset used for modifying data in the database.

```
INSERT
UPDATE
DELETE
```

- **Update**

```sql
UPDATE TABLE_NAME
SET column1 = value1, column2 = value2, columnN = valueN
WHERE [condition]

--- Examples ---

UPDATE employees
SET department_name = 'Tech'
WHERE department_name = 'QC'
```

- **Delete**

 Used to remove a specific record from a table or relation. generally includes **WHERE** clause. 
 
**If you NOT specify WHERE clause, it will remove ALL records from the table**

```sql
DELETE FROM TABLE_NAME
WHERE [condition];

--Example--
DELETE FROM enrollment
WHERE student_id = 'student1@uni.edu' AND course_id = 101;

```
- **Insert**

 Add a new record into the table within your database. 
 **INSERT** is always followed by the INTO keyword as well.

 ```sql
INSERT INTO TABLE_NAME (column1, column2, columnN)
VALUES (value1, value2, valueN);

---Example---

INSERT INTO products (product_id, p_name, quantity, p_description, category_id)
VALUES (42,'Supercomputer: Deep Thought', 1, 'Answers the ultimate question of Life, the Universe and Everything', 7)

 ```


