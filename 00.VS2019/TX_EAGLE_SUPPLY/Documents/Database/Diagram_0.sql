/*
   Saturday, July 10, 20211:15:30 AM
   User: 
   Server: (localdb)\MSSQLLocalDB
   Database: IMSDB_DEV
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ProductCategory
	DROP CONSTRAINT DF__ProductCa__Creat__239E4DCF
GO
ALTER TABLE dbo.ProductCategory
	DROP CONSTRAINT DF__ProductCa__Modif__24927208
GO
CREATE TABLE dbo.Tmp_ProductCategory
	(
	Id int NOT NULL,
	Name nvarchar(50) NOT NULL,
	Description nvarchar(200) NULL,
	CreatedDate datetime NOT NULL,
	ModifiedDate datetime NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_ProductCategory SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Tmp_ProductCategory ADD CONSTRAINT
	DF__ProductCa__Creat__239E4DCF DEFAULT (getdate()) FOR CreatedDate
GO
ALTER TABLE dbo.Tmp_ProductCategory ADD CONSTRAINT
	DF__ProductCa__Modif__24927208 DEFAULT (getdate()) FOR ModifiedDate
GO
IF EXISTS(SELECT * FROM dbo.ProductCategory)
	 EXEC('INSERT INTO dbo.Tmp_ProductCategory (Id, Name, Description, CreatedDate, ModifiedDate)
		SELECT Id, Name, Description, CreatedDate, ModifiedDate FROM dbo.ProductCategory WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.ProductCategory
GO
EXECUTE sp_rename N'dbo.Tmp_ProductCategory', N'ProductCategory', 'OBJECT' 
GO
ALTER TABLE dbo.ProductCategory ADD CONSTRAINT
	PK__ProductC__3214EC070CDE5B15 PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Product
	(
	Id int NOT NULL,
	Name varchar(50) NOT NULL,
	Description varchar(200) NULL,
	SafetyStockLevel smallint NOT NULL,
	ReorderPoint smallint NOT NULL,
	StandardCost money NOT NULL,
	ListPrice money NULL,
	ProductCategoryId int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Product ADD CONSTRAINT
	PK_Product PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Product ADD CONSTRAINT
	FK_Product_ProductCategory FOREIGN KEY
	(
	ProductCategoryId
	) REFERENCES dbo.ProductCategory
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Product SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
