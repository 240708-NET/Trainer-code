 ## Advanced SQL

### Stored Procedure
 It is a prepared SQL code that you can save, reuse, and share among applications. 

Can accept parameters, return values, and be used to encapsulate and execute complex SQL logic.

#### Benefits
- **Improved Performance**: Stored procedures are compiled and stored in the database server, which can improve execution speed and reduce network traffic.
- **Modularity and Reusability**: They can be called from multiple applications or scripts, promoting code reuse and simplifying maintenance.
- **Enhanced Security**: Permissions can be granted to the stored procedure itself, reducing the risk of SQL injection attacks.
Centralized Logic: Business logic can be centralized within stored procedures, making it easier to manage and update.


```sql
CREATE PROCEDURE GetEmployeeDetails
    @EmployeeID INT
AS
BEGIN
    SELECT FirstName, LastName, Department
    FROM Employees
    WHERE EmployeeID = @EmployeeID;
END;

--Execute
EXEC GetEmployeeDetails @EmployeeID = 101;


```

### User Defined Function
Reusable SQL code blocks that accept parameters, perform calculations, and return a single value or a table of values.

```sql
CREATE FUNCTION dbo.CalculateTaxAmount
(
    @Amount DECIMAL(18, 2),
    @TaxRate DECIMAL(5, 2)
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Tax DECIMAL(18, 2);
    SET @Tax = @Amount * (@TaxRate / 100);
    RETURN @Tax;
END;

--Usage example --

SELECT dbo.CalculateTaxAmount(100, 8.5); -- Calculates tax on $100 at 8.5%

```

#### Benefits

- **Modularity**: Encapsulate business logic for reuse and maintainability.
- **Performance**: Improve query performance by reducing complex logic in queries.
- **Security**: Control access to data through functions.
- **Consistency**: Ensure consistent results for common operations.

#### Function vs Procedure

Main differecne is how they retunr values, their usage in SQL queries.

**Procedures**
- **No Return Value Requirement**: Procedures may or may not return values. If they do, it’s through OUT or INOUT parameters rather than a direct RETURN statement.
- **CALL Statement**: Procedures are called using the EXEC statement rather than being embedded directly within SQL queries.

**Functions**
- **Return Value**: Functions are designed to compute and return a single value using the RETURN statement. They encapsulate logic to calculate or derive values based on input parameters.

- **Within SQL Queries**: Functions can be used within SQL queries wherever an expression is valid. They can be part of SELECT, WHERE, ORDER BY, and other clauses.
- **Data Transformation**: Use functions for calculations, formatting data (like dates, currencies), and reusable computations.

**Use Procedures When:**

- Performing complex data manipulations, transactions, or actions that do not require returning a value directly to the caller.
- Needing to execute multiple SQL statements or procedural logic as a single unit.
- Managing tasks such as data updates, inserts, deletes, or other administrative actions.

**Use Functions When:**

- Needing to compute and return a value for use within SQL queries or applications.
- Requiring reusable calculations or transformations (e.g., formatting dates, calculating totals).
- Avoiding repetition of logic by encapsulating it into a single callable unit.

### Scalar Function
A scalar function returns a single value based on input parameters. It can be used wherever an expression can be used in SQL queries.

```sql

UCASE()	--Converts the value of a field to uppercase.
LCASE()	--Converts the value of a field to lowercase.
MID()	--Returns the substring from the text field.
LEN()	--Returns the length of the value in a text field.
ROUND()	--Used to round a numberic field to the number of decimals specified.
NOW()	--Returns the current system date and time.
FORMAT()	--Used to format how a field is to be displayed

SELECT UCASE ("Hello World") AS UpperCase_String;   -- Converting a string to uppercase:

```
### Sequence
 Object in a relational database management system (RDBMS) that generates a sequence of numeric values according to a specified pattern. 
 
Often used to generate unique identifiers for primary keys in database tables

```sql
CREATE SEQUENCE example_1
AS INT
START WITH 10
INCREMENT BY 10;
```

### Trigger

Special type of stored procedure that automatically executes in response to certain events on a particular table or view in a database. 

Triggers are defined to run before or after INSERT, UPDATE, or DELETE operations and are used to enforce business rules, perform logging, auditing, or maintain referential integrity.

```sql
-- Creating an AFTER INSERT trigger
CREATE TRIGGER trgAfterInsertEmployee
ON Employees
AFTER INSERT
AS
BEGIN
    -- Inserting into Audit table for logging purposes
    INSERT INTO AuditTrail (TableName, ActionPerformed, DateTimePerformed)
    VALUES ('Employees', 'Employee inserted', GETDATE());
END;

-- Whenever a new row is inserted into the Employees table, this trigger inserts a record into the AuditTrail table, capturing details about the operation performed.--

```

### Views

Virtual table that represents the result set of a SELECT query. Unlike physical tables, views do not store data themselves but instead derive their data from the underlying tables or other views. 

```sql
-- Creating a simple view
CREATE VIEW vwEmployees AS
SELECT EmployeeID, FirstName, LastName, Department
FROM Employees
WHERE IsActive = 1;

-- Querying data from the view
SELECT * FROM vwEmployees;

-- Dropping a view
DROP VIEW vwEmployees;

```

### Indexes
Structure associated with a table or view that speeds up the retrieval of rows from the table or view, based on the values in one or more columns.

- **Clustered Index**: Defines the physical order of data rows in a table. <span style="color:red">**Each table can have only one clustered**</span> index because it physically reorders the table rows. It is particularly effective for range queries and sorting.

- **Non-Clustered Index**: A separate structure from the data rows, containing pointers to the rows. Each table can have multiple non-clustered indexes. It is useful for improving the performance of frequently used queries that do not return large result sets.

```sql
-- Create a Non-Clustered Index on Users table
CREATE INDEX idx_UserID ON Users (userid);

-- Create a Clustered Index on Accounts table
CREATE INDEX idx_AccountID ON Accounts (accountid);

-- Cluster the Accounts table based on the idx_AccountID index
CLUSTER Accounts USING idx_AccountID;
```

Indexes are used automatically by the SQL Server query optimizer to enhance query performance. 

You do not need to explicitly use indexes in your queries

