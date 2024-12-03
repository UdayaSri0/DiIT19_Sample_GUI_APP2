create database ProDiIT19GUI;

use ProDiIT19GUI

create table Users (
	UserID INT IDENTITY(1,1) PRIMARY KEY,
	Username NVARCHAR(60) NOT NULL,
	Password NVARCHAR(60) NOT NULL,
	Role NVARCHAR(20) NOT NULL
);

INSERT INTO Users (Username, Password, Role) VALUES ('Udaya@gmail.com', 'Udaya@123', 'Admin');
INSERT INTO Users (Username, Password, Role) VALUES ('user@gmail.com', 'user@123', 'User');