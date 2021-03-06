----DLL TO DELTE DATABASE FORCE
USE master;
ALTER DATABASE [databasename] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE [databasename] ;
--------------------------------------------------------------------------
--------------------------------------------------------------------------
---DLL TO RENAME DATABASE 
USE master;  
GO  
ALTER DATABASE databasename
Modify Name = databasename_1
GO
--------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------TABLES
--DLL TO CREATE DATABASE
IF DB_ID('NAMEDATABASE') IS NULL
CREATE DATABASE NAMEDATABASE
USE MASTER 
ALTER DATABASE NAMEDATABASE SET SINGLE_USER;
ALTER DATABASE NAMEDATABASE COLLATE LATIN1_GENERAL_100_CI_AI
ALTER DATABASE NAMEDATABASE COLLATE ARABIC_CI_AS;   --Add Collate Arabic language
ALTER DATABASE NAMEDATABASE SET MULTI_USER;
GO
USE NAMEDATABASE
GO


