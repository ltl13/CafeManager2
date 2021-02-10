﻿CREATE DATABASE CafeManager
GO

USE CafeManager
GO


CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Kter',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

INSERT INTO dbo.Account
( 
	UserName ,
    DisplayName ,
    PassWord ,
    Type
)
VALUES  
( 
	N'a',
	N'Admin',
	N'1',
	1
)
INSERT INTO dbo.Account
( 
	UserName ,
    DisplayName ,
    PassWord ,
    Type
)
VALUES  
( 
	N'luan',
	N'Luân',
	N'130201',
	0
)
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE	UserName = @userName
END
GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

DECLARE @i INT = 1
WHILE (@i <= 10)
BEGIN
	INSERT dbo.TableFood (name) VALUES (N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO
--Thêm Cagetory
--delete from dbo.FoodCategory
INSERT INTO dbo.FoodCategory (name) VALUES (N'Cafe')
INSERT INTO dbo.FoodCategory (name) VALUES (N'Sinh tố')
INSERT INTO dbo.FoodCategory (name) VALUES (N'Nước ép')
INSERT INTO dbo.FoodCategory (name) VALUES (N'Nước ngọt')
INSERT INTO dbo.FoodCategory (name) VALUES (N'Cooktail')
--Thêm Food
--delete from dbo.Food
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Capuchino', 1, 35000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Latte', 1, 35000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Macchiato', 1, 40000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Espresso', 1, 25000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Sinh tố dâu', 2, 35000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Sinh tố bơ', 2, 40000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Sinh tố mãng cầu', 2, 35000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Sinh tố xoài', 2, 35000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Nước ép táo', 3, 35000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Nước ép dứa', 3, 35000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Nước ép cà chua', 3, 35000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Coke', 4, 25000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Pepsi', 4, 25000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Redbull', 4, 25000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Sting', 4, 25000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Old Fashioned', 5, 60000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Negroni', 5, 60000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Whiskey Sour', 5, 65000)
INSERT INTO dbo.Food (name, idCategory, price) VALUES (N'Dry Martini', 5, 75000)

SELECT * FROM dbo.FoodCategory
select * from dbo.Food