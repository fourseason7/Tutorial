CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [EmailAddress] NVARCHAR(50) NOT NULL, 
    [PhoneNumber] NVARCHAR(50) NOT NULL, 
    [HireDate] DATETIME NULL
)
