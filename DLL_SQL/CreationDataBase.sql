IF DB_ID('MYDATABASE') IS NULL
CREATE DATABASE MYDATABASE
USE MASTER 
ALTER DATABASE MYDATABASE SET SINGLE_USER;
ALTER DATABASE MYDATABASE COLLATE LATIN1_GENERAL_100_CI_AI
ALTER DATABASE MYDATABASE COLLATE ARABIC_CI_AS;   --Add Collate Arabic language
ALTER DATABASE MYDATABASE SET MULTI_USER;
GO
USE MYDATABASE
GO
------------------------------
------------------------------

------Creation Tables

-- Table Items
CREATE TABLE [MYDATABASE].[DBO].[ITEMS](

ID 						INT NOT NULL IDENTITY(1,1),
ITEM_NUMBER 			INT NULL,
ITEM_CODE 				VARCHAR(MAX) NULL,
ITEM_NAME 				VARCHAR(MAX) NULL,
ITEM_CONSUMER_PRICE 	FLOAT(53) NULL,
CONSTRAINT PK_ITEMS PRIMARY KEY CLUSTERED (ID ASC)
);
GO
-- Table Customers
CREATE TABLE [MYDATABASE].[DBO].[CUSTOMERS](
ID 						INT NOT NULL IDENTITY(1,1),
CUSTOMER_SERIAL 		INT NULL,
CUSTOMER_FIRST_NAME 	VARCHAR(MAX) NULL, 
CUSTOMER_SECOUND_NAME 	VARCHAR(MAX) NULL,
CUSTOMER_LAST_NAME 		VARCHAR(MAX) NULL,
CUSTOMER_CIVIL_ID 		VARCHAR(MAX) NULL,
CUSTOMER_PHONE_NUMBER 	VARCHAR(MAX) NULL
CONSTRAINT PK_CUSTOMERS PRIMARY KEY CLUSTERED (ID ASC)
);
GO
-- Table Suppliers
CREATE TABLE [MYDATABASE].[DBO].[SUPPLIERS](
ID INT NOT NULL IDENTITY(1,1),
SUPPLIER_SERIAL INT NULL,
SUPPLIER_NAME VARCHAR(MAX) NULL,
SUPPLIER_PHONE_NUMBER VARCHAR(MAX) NULL,
CONSTRAINT PK_SUPPLIERS PRIMARY KEY CLUSTERED (ID ASC)
);
GO

------Creation StoreProcedure
--StoreProcedure Items
CREATE PROC [DBO].[ITEM_MAX_NUMBER]  ---ITEM_MAX_NUMBER
AS
SELECT MAX(ITEM_NUMBER) FROM ITEMS 
GO

CREATE PROC [DBO].[ITEM_SAVE]        ---ITEM_SAVE
@ITEM_NUMBER INT,
@ITEM_CODE VARCHAR(MAX),
@ITEM_NAME VARCHAR(MAX),
@ITEM_CONSUMER_PRICE FLOAT(53)
AS
INSERT INTO [ITEMS]
			([ITEM_NUMBER]
			,[ITEM_CODE]
			,[ITEM_NAME]
			,[ITEM_CONSUMER_PRICE])
		VALUE
			(@ITEM_NUMBER
			,@ITEM_CODE
			,@ITEM_NAME
			,@ITEM_CONSUMER_PRICE)
		GO

CREATE PROC [DBO].[ITEM_UPDATE]       ---ITEM_UPDATE
@ITEM_NUMBER INT,
@ITEM_CODE VARCHAR(MAX),
@ITEM_NAME VARCHAR(MAX),
@ITEM_CONSUMER_PRICE FLOAT(53)
AS
UPDATE [ITEMS]
		SET
		[ITEM_CODE] = @ITEM_CODE
		[ITEM_NAME] = @ITEM_NAME
		[ITEM_CONSUMER_PRICE] = @ITEM_CONSUMER_PRICE
WHERE ITEM_NUMBER = @ITEM_NUMBER
GO

CREATE PRO [DBO].[ITEM_DELETE]           ---ITEM_DELETE
@ITEM_SERAIL 
AS 
DELETE FROM ITEMS
WHERE ITEM_SERAIL = @ITEM_SERAIL
GO

--StoreProcedure Customers
CREATE PROC [DBO].[CUSTOMER_MAX_SERIAL]       ---CUSTOMER_MAX_SERIAL
AS
SELECT MAX(CUSTOMER_SERIAL) FROM CUSTOMERS
GO

CREATE PROC [DBO].[CUSTOMER_SAVE]             ---CUSTOMER_SAVE
@CUSTOMER_SERIAL INT,
@CUSTOMER_FIRST_NAME VARCHAR(MAX),
@CUSTOMER_SECOUND_NAME VARCHAR(MAX),
@CUSTOMER_LAST_NAME VARCHAR(MAX),
@CUSTOMER_CIVIL_ID VARCHAR(MAX),
@CUSTOMER_PHONE_NUMBER VARCHAR(MAX)
AS
INSERT INTO [CUSTOMERS]
			([CUSTOMER_SERIAL]
			,[CUSTOMER_FIRST_NAME]
			,[CUSTOMER_SECOUND_NAME]
			,[CUSTOMER_LAST_NAME]
			,[CUSTOMER_PHONE_NUMBER])
		VALUE 
			(@CUSTOMER_SERIAL
			,@CUSTOMER_FIRST_NAME
			,@CUSTOMER_LAST_NAME
			,@CUSTOMER_CIVIL_ID
			,@CUSTOMER_PHONE_NUMBER)
		GO

CREATE PROC [DBO].[CUSTOMER_UPDATE]          ---CUSTOMER_UPDATE
@CUSTOMER_SERIAL INT,
@CUSTOMER_FIRST_NAME VARCHAR(MAX),
@CUSTOMER_SECOUND_NAME VARCHAR(MAX),
@CUSTOMER_LAST_NAME VARCHAR(MAX),
@CUSTOMER_CIVIL_ID VARCHAR(MAX),
@CUSTOMER_PHONE_NUMBER VARCHAR(MAX)
AS
UPDATE [CUSTOMERS]
		SET
		CUSTOMER_FIRST_NAME = @CUSTOMER_FIRST_NAME
		CUSTOMER_SECOUND_NAME = @CUSTOMER_SECOUND_NAME
		CUSTOMER_LAST_NAME = @CUSTOMER_LAST_NAME
		CUSTOMER_CIVIL_ID = @CUSTOMER_CIVIL_ID
		CUSTOMER_PHONE_NUMBER = @CUSTOMER_PHONE_NUMBER
WHERE CUSTOMER_SERIAL = @CUSTOMER_SERIAL
GO

CREATE PROC [DBO].[CUSTOMER_DELETE]               ---DELETE_CUSTOMERS
@CUSTOMER_SERIAL INT 
AS
DELETE FROM CUSTOMERS
WHERE CUSTOMER_SERIAL = @CUSTOMER_SERIAL
GO

--StoreProcedure SUPPLIERS 
CREATE PROC [DBO].[SUPPLIERS_MAX_SERIAL]         ---SUPPLIERS_MAX_SERIAL
AS
SELECT MAX(SUPPLIER_SERIAL) FROM SUPPLIERS
GO

CREATE PROC [DBO].[SUPPPLIER_SAVE]                ---SUPPLIER_SAVE
@SUPPLIER_SERIAL INT,
@SUPPLIER_NAME AS VARCHAR(MAX),
@SUPPLIER_PHONE_NUMBER VARCHAR(MAX)
AS
INSERT INTO [SUPPLIERS]
			([SUPPLIER_SERIAL]
			,[SUPPLIER_NAME]
			,[SUPPLIER_PHONE_NUMBER])
		VALUE
			(@SUPPLIER_SERIAL
			,@SUPPLIER_NAME
			,@SUPPLIER_PHONE_NUMBER)
		GO

CREATE PROC [DBO].[SUPPLIER_UPDATE]               ---SUPPLIER_UPDATE
@SUPPLIER_SERIAL INT,
@SUPPLIER_NAME VARCHAR(MAX),
@SUPPLIER_PHONE_NUMBER VARCHAR(MAX)
AS
UPDATE [SUPPLIERS]
		SET
		[SUPPLIER_NAME] = @SUPPLIER_NAME
		[SUPPLIER_PHONE_NUMBER] = @SUPPLIER_PHONE_NUMBER
WHERE SUPPLIER_SERIAL = @SUPPLIER_SERIAL
GO

CREATE PROC [DBO].[SUPPLIER_DELETE]               ---SUPPLIER_DELETE
@SUPPLIER_SERIAL INT 
AS
DELETE FROM SUPPLIERS
WHERE SUPPLIER_SERIAL = @SUPPLIER_SERIAL
GO
