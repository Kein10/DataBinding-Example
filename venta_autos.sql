-- FORO 02 - 16.06.19
-- KEVIN ALEXANDER OSORT FLORES - 31811451
-- Crear base de datos
USE master;
GO

IF EXISTS (
		SELECT *
		FROM sys.databases
		WHERE NAME = 'autos'
		)
	DROP DATABASE autos
GO

CREATE DATABASE autos
GO


use autos
go

create table Vehicle_Categories
(
	Vehicle_Category_Code int identity
		constraint PK_Vehicle_Categories
			primary key,
	Vehicle_Category_Description varchar(50) not null
)
go

create unique index IX_Vehicle_Categories
	on Vehicle_Categories (Vehicle_Category_Code)
go

create unique index IX_Vehicle_Categories_1
	on Vehicle_Categories (Vehicle_Category_Description)
go


INSERT INTO autos.dbo.Vehicle_Categories (Vehicle_Category_Code, Vehicle_Category_Description) VALUES (1, 'Deluxe');
INSERT INTO autos.dbo.Vehicle_Categories (Vehicle_Category_Code, Vehicle_Category_Description) VALUES (3, 'Rural');
INSERT INTO autos.dbo.Vehicle_Categories (Vehicle_Category_Code, Vehicle_Category_Description) VALUES (2, 'Town');
