-- On the Chinook DB, practice writing queries with the following exercises

-- BASIC CHALLENGES
-- List all customers (full name, customer id, and country) who are not in the USA
SELECT firstName, lastName As fullName, customerId, country FROM [MyDatabase].[dbo].[customer] 
WHERE Country != 'USA'; 

SELECT FirstName + ' ' + LastName AS CustomerName, CustomerId, Country 
    FROM [MyDatabase].[dbo].[Customer]
    WHERE Country != 'USA';
    
-- List all customers from Brazil
SELECT FirstName + ' ' + LastName AS FullName, CustomerId, Country
    FROM [MyDatabase].[dbo].[Customer]
    WHERE Country = 'Brazil'; -- Jean-Luc :)
    
-- List all sales agents
 SELECT * FROM [MyDatabase].[dbo].[Employee] WHERE Title LIKE '%Agent';
 SELECT * FROM [MyDatabase].[dbo].[Employee] WHERE Title = 'Sales Support Agent';

-- Retrieve a list of all countries in billing addresses on invoices
SELECT BillingCountry from [MyDatabase].[dbo].[Invoice] GROUP BY BillingCountry;

-- Retrieve how many invoices there were in 2009, and what was the sales total for that year?
SELECT * FROM [MyDatabase].[dbo].[Invoice];
SELECT COUNT(*) FROM [MyDatabase].[dbo].[Invoice] WHERE YEAR(InvoiceDate) = 2009; 
SELECT SUM(Total) AS Sales_Total FROM [MyDatabase].[dbo].[Invoice] WHERE YEAR(InvoiceDate) = 2009; 

    -- (challenge: find the invoice count sales total for every year using one query)
SELECT COUNT(*) as '2009', SUM(Total) as 'Total'
FROM [MyDatabase].[dbo].[Invoice]
WHERE YEAR(InvoiceDate) = '2009';

SELECT YEAR(InvoiceDate) as 'Year', SUM(Total) as 'Total'
FROM [MyDatabase].[dbo].[Invoice]
GROUP BY YEAR(InvoiceDate);

SELECT YEAR(InvoiceDate) AS Year, COUNT(InvoiceId) AS InvoiceCount, SUM(Total) AS SalesTotal
    FROM [MyDatabase].[dbo].[Invoice]
    GROUP BY YEAR(InvoiceDate)
    ORDER BY (Year); -- Jean-Luc :)

-- how many line items were there for invoice #37
SELECT * FROM [MyDatabase].[dbo].[InvoiceLine] WHERE InvoiceId = 37;

SELECT COUNT(*)
    FROM [MyDatabase].[dbo].[InvoiceLine]
    WHERE InvoiceId = 37;

-- how many invoices per country? BillingCountry  # of invoices -
SELECT CONCAT(i.BillingCountry, ' #', COUNT(*), ' of invoices') FROM [MyDatabase].[dbo].[Invoice] i
    GROUP BY i.BillingCountry

-- Retrieve the total sales per country, ordered by the highest total sales first.
SELECT BillingCountry , SUM(Total) AS Country_Sum FROM [MyDatabase].dbo.[Invoice] 
            GROUP BY BillingCountry 
                ORDER By Country_Sum DESC;
                    -- By Chike Egbuchulam


-- JOINS CHALLENGES
-- Every Album by Artist
SELECT * FROM [MyDatabase].[dbo].[Album];
SELECT * FROM [MyDatabase].[dbo].[Artist];

SELECT Album.Title, Artist.Name
    FROM [MyDatabase].[dbo].[Album] AS Album
        INNER JOIN [MyDatabase].[dbo].[Artist] AS Artist
            ON Album.ArtistId = Artist.ArtistId;   

SELECT Album.Title, Artist.Name FROM Album, Artist
    WHERE Album.ArtistId = Artist.ArtistId;

-- All songs of the rock genre
SELECT * FROM [MyDatabase].[dbo].[Genre];
SELECT * FROM [MyDatabase].[dbo].[Track];

SELECT Track.Name, Artist.Name
    FROM [MyDatabase].[dbo].[Track] AS Track
        INNER JOIN [MyDatabase].[dbo].[Genre] AS Genre
            ON Track.GenreId = Genre.GenreId
        INNER JOIN [MyDatabase].[dbo].[Album] AS Album
            ON Track.AlbumId = Album.AlbumId
        INNER JOIN [MyDatabase].[dbo].[Artist] AS Artist 
            ON Album.ArtistId = Artist.ArtistId
    WHERE Genre.Name = 'Rock';

SELECT Artist.Name as 'Artist', Track.Name as 'Track', Genre.Name AS 'Genre'
    FROM [MyDatabase].[dbo].[Track] AS Track
        INNER JOIN [MyDatabase].[dbo].[Genre] AS Genre
            ON Track.GenreId = Genre.GenreId
            AND Genre.Name = 'Rock'
        INNER JOIN [MyDatabase].[dbo].[Album] AS Album
            ON Track.AlbumId = Album.AlbumId
        INNER JOIN [MyDatabase].[dbo].[Artist] AS Artist
            ON Album.ArtistID = Artist.ArtistID
            ORDER BY Artist.Name;

-- Show all invoices of customers from brazil (mailing address not billing)

-- Show all invoices together with the name of the sales agent for each one

-- Which sales agent made the most sales in 2009?

-- How many customers are assigned to each sales agent?

-- Which track was purchased the most ing 20010?

-- Show the top three best selling artists.

-- Which customers have the same initials as at least one other customer?



-- ADVACED CHALLENGES
-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?

-- 2. which artists did not record any tracks of the Latin genre?

-- 3. which video track has the longest length? (use media type table)

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.


-- DML exercises

-- 1. insert two new records into the employee table.

-- 2. insert two new records into the tracks table.

-- 3. update customer Aaron Mitchell's name to Robert Walter

-- 4. delete one of the employees you inserted.

-- 5. delete customer Robert Walter.
