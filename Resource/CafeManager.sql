CREATE DATABASE CafeManager
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
--Thêm bill
INSERT INTO dbo.Bill (DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), NULL, 1, 0)
INSERT INTO dbo.Bill (DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), NULl, 2, 0)
INSERT INTO dbo.Bill (DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), GETDATE(), 2, 1)
--Thêm bill info
INSERT INTO dbo.BillInfo (idBill, idFood, count) VALUES (1, 2, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count) VALUES (2, 7, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count) VALUES (1, 1, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count) VALUES (2, 9, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count) VALUES (1, 4, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count) VALUES (3, 11, 1)

CREATE PROC USP_GetUncheckBillByTableID
@tableID INT
AS
BEGIN
	SELECT * FROM dbo.Bill WHERE idTable = @tableID AND status = 0
END

CREATE PROC USP_GetListBillInfo
@idBill INT
AS
BEGIN
	SELECT * FROM dbo.BillInfo WHERE idBill = @idBill;
END

CREATE PROC USP_GetListMenuByTable
@tableID INT
AS
BEGIN
	SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo bi, dbo.Bill b, dbo.Food f
	WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.idTable = @tableID AND b.status = 0
END

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT INTO dbo.Bill (DateCheckIn, DateCheckOut, idTable, status)
	VALUES (GETDATE(), NULL, @idTable, 0)
END
GO

ALTER PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @isExistBillInfo INT = 0
	DECLARE @foodCount INT = 1
	SELECT @isExistBillInfo = id, @foodCount = count FROM dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	IF (@isExistBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo SET count = @newCount WHERE idBill = @idBill AND idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT INTO dbo.BillInfo (idBill, idFood, count)
		VALUES (@idBill, @idFood, @count)
	END
END
GO