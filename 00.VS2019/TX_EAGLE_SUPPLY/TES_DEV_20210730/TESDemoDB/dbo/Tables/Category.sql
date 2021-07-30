CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryName] NVARCHAR(50) NOT NULL, 
    [CategoryDescription] NVARCHAR(200) NOT NULL, 
    [ModifiedUserId] INT NULL,
    [ModifiedHostName] NVARCHAR(50) DEFAULT HOST_NAME(),
    [ModifiedDate] DATETIME NULL DEFAULT GETDATE()
)
