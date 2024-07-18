-- DDL and DML Demo --

CREATE database DemoDB;

use DemoDB;
GO;


/*make sure to add GO to separate queries, otherwise you will have syntax error!!*/
CREATE SCHEMA test;
GO;


CREATE table DemoTable(
    demo_id INT IDENTITY(1,1) PRIMARY KEY,
    demo_name VARCHAR(255) NOT NULL,
    demo_date TIMESTAMP
)

/*Create demo tables in different schema*/
CREATE table test.DemoTable(
    demo_id INT IDENTITY(1,1) PRIMARY KEY,
    demo_name VARCHAR(255) NOT NULL,
    demo_date TIMESTAMP
)

/*Select from test schema*/
select * from test.DemoTable;


-- Add a new column
ALTER table DemoTable 
ADD demo_description VARCHAR (255) NOT NULL;


-- Alter column name

EXEC sp_rename 'dbo.DemoTable.new_column_name', 'demo_descr', 'COLUMN';

-- ALTER TABLE

ALTER TABLE DemoTable
ADD demo_description varchar(250);

    
ALTER TABLE DemoTable
ALTER COLUMN demo_name VARCHAR(100);

ALTER TABLE Employees
DROP COLUMN demo_description;



-- Data manipulation languages

-- Insert Values
INSERT INTO DemoTable (demo_name, new_column_name) 
VALUES ('my Value', 'testing');

INSERT INTO DemoTable (demo_name, new_column_name) 
VALUES ('Second Value', 'Sql is the best');

select * from DemoTable;

-- Update 
Update DemoTable
SET new_column_name = 'My new value!!!'
WHERE demo_id = 1;

-- Delete
Delete From DemoTable WHERE demo_id = 2;


-- Truncate 
TRUNCATE TABLE DemoTable;

-- DELETE / DROP TABLE

DROP TABLE DemoTable;




