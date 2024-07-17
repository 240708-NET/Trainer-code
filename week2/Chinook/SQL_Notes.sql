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
*/


-- JOIN

-- INNER, OUTER, LEFT, RIGHT, CROSS
-- Maybe good to visualize as Venn Diagrams

-- JOIN will hilight the importance of NULL in SQL
-- JOIN - combining entries/records of multiple tables to gather fields from the different entries into one result
-- INNER JOIN - returns the overlapping fields/results from tables
-- OUTER JOIN - 
-- LEFT JOIN - 
-- RIGHT JOIN - 
-- CROSS JOIN - 
-- SELF JOIN - 

-- KEYS
-- Primary Key - a NOT NULL, UNIQUE identifier for the entry of the table that other tables can reference
-- Foreign Key - a field owned by an entry/another row that references the primary key of an entry 