-- SQL Notes

-- Comments in SQL are noted with a "--"
/* 
multi-line comments are a thing as well
see?
*/

-- DDL - Data Definition - Creating and modifying the structure of the data/tables/database
-- DQL - Data Query - Retrieving the data in interesting ways
-- DML - Data Manipulation - Creating and modifying the data inside the established structure
-- DCL - Data Control - Access control, and server administration

-- DQL - 
--  SELECT - sorting, filtering, and gathering data from tables within the database - Select ALWAYS returns tables
CREATE DATABASE MyDatabase;
USE MyDatabase;
GO

SELECT 2; -- Select always returns a table
SELECT 2 + 2; -- the server can be pretty powerful
SELECT SYSUTCDATETIME(); -- can respond to requests with computation or calculation
select 'this is a string'; -- capitalization is a good idea, but not strictly enforced

SELECT * FROM [MyDatabase].[dbo].[Artist]; -- use SELECT to specify that we want a response, and using FROM to specify where we want the data gathered from

-- gather all of the entries from the Customer table, from the dbo schema, from the MyDatabase database
SELECT * FROM [MyDatabase].[dbo].[Customer];
SELECT * FROM Customer;

-- gather fewer columns from the Customer Table?
-- Don't use the *, or use WHERE

SELECT FirstName, LastName FROM [MyDatabase].[dbo].[Customer];
SELECT LastName, FirstName FROM [MyDatabase].[dbo].[Customer];
SELECT LastName + ', ' + FirstName AS CustomerName FROM [MyDatabase].[dbo].[Customer]; -- Concatenation and Alias to make data more legible/meaningful

-- Using WHERE to filter a response
SELECT FirstName, LastName FROM [MyDatabase].[dbo].[Customer] WHERE LastName = 'Smith';
SELECT FirstName, LastName FROM [MyDatabase].[dbo].[Customer] WHERE Country = 'Canada' OR Country = 'France';

SELECT LastName + ', ' + FirstName AS CustomerName 
    FROM [MyDatabase].[dbo].[Customer] 
    WHERE Country = 'Canada' 
        OR Country = 'France'; -- SQL is not indent/whitespace sensitive, but it looks good!

-- Aggregate functions - accepts a parameter (the thing it's going to need) returns a Scalar value (just the one, not many rows and columns)
SELECT COUNT(*) 
    FROM [MyDatabase].[dbo].[Customer];


SELECT * FROM [MyDatabase].[dbo].[Invoice];

SELECT SUM(Total)
    FROM[MyDatabase].[dbo].[Invoice];

SELECT CustomerId, Count(CustomerId)
    FROM [MyDatabase].[dbo].[Invoice]
    GROUP BY CustomerId;

SELECT CustomerId, SUM(Total)
    FROM [MyDatabase].[dbo].[Invoice]
    GROUP BY CustomerId;

SELECT CustomerId, SUM(Total) AS Sum_Total
    FROM [MyDatabase].[dbo].[Invoice]
    WHERE BillingCountry = 'USA'
       -- AND SUM(Total) > 40  We can't have an aggregate in a WHERE clause
    GROUP BY CustomerId
    HAVING SUM(Total) > 40
    ORDER BY Sum_Total DESC, CustomerId;

/*
Logical order of operations:

- FROM
- WHERE
- GROUP BY
- HAVING
- SELECT
- ORDER BY

 JOINS (Maybe good to visualize as Venn Diagrams)

******* JOIN will hilight the importance of NULL in SQL **********

JOIN - combining entries/records of multiple tables to gather fields from the different entries into one resultant table 
INNER JOIN -
    The INNER JOIN keyword returns only rows with a match in both tables.
    Returns the overlapping fields/results from tables where the foreign and primary keys match.
    Any entry from a table with no matching foreign key will not be returned.

LEFT JOIN - 
    The LEFT JOIN keyword returns all records from the "LEFT" table in the command,
    even if there are no matches in the "RIGHT" table.

RIGHT JOIN - 
    The RIGHT JOIN keyword returns all records from the "RIGHT" table in the command,
    even if there are no matches in the "LEFT" table.

OUTER JOIN - 
    The FULL OUTER JOIN keyword returns all matching records from both tables whether the other table matches or not.
    So, if there are rows in "A" that do not have matches in "B",
    or if there are rows in "B" that do not have matches in "A", those rows will be listed as well.

CROSS JOIN - 
    CROSS JOIN returns a combination of each row in the left table paired with each row in the right table. 
    If table A is the four suits, and table B is the face value of the cards,
    a CROSS JOIN is the full deck of cards where for every suit there is a card of each value.

SELF JOIN - 
    Joins in SQL, a self join is a regular join that is used to join a table with itself.
    It allows us to combine the rows from the same table based on some specific conditions.
    It allows us to retrieve data or information which involves comparing records within the same table.

KEYS -
Primary Key 
    - A NOT NULL, UNIQUE identifier for the entry of the table that other tables can reference
Foreign Key
    - A field owned by an entry/another row that references the primary key of an entry 

*/