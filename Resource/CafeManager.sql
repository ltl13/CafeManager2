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

ALTER PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT INTO dbo.Bill (DateCheckIn, DateCheckOut, idTable, status, discount)
	VALUES (GETDATE(), NULL, @idTable, 0, 0)
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
		IF (@count > 0)
			INSERT INTO dbo.BillInfo (idBill, idFood, count)
			VALUES (@idBill, @idFood, @count)
	END
END
GO

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = idBill FROM inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE @idBill = id AND status = 0
	UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = id FROM inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE @idBill = id
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE @idTable = id
END
GO

ALTER TABLE dbo.Bill
ADD discount INT
UPDATE dbo.Bill SET discount = 0 

ALTER PROC USP_SwitchTable
@idTable1 INT, @idTable2 INT
AS
BEGIN
	DECLARE @idBill1 INT = 0
	DECLARE @idBill2 INT = 0
	SELECT @idBill1 = id FROM dbo.Bill WHERE idTable = @idTable1 AND STATUS = 0
	SELECT @idBill2 = id FROM dbo.Bill WHERE idTable = @idTable2 AND STATUS = 0
	IF (@idBill1 != 0 AND @idBill1 != @idBill2 AND @idBill2 != 0)
	BEGIN
		UPDATE dbo.BillInfo SET idBill = @idBill2 WHERE idBill = @idBill1
		DELETE FROM dbo.Bill WHERE id = @idBill1 AND status = 0
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable2
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
	END
	IF (@idBill1 != 0 AND @idBill2 = 0)
	BEGIN
		UPDATE dbo.Bill SET idTable =  @idTable2 WHERE id = @idBill1
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable2
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
	END
END
GO

alter proc USP_GetListBillByDate
@checkIn date, @checkOut date, @page int
as
begin
	declare @pageRow int = 9
	declare @exceptRow int = (@page - 1) * @pageRow
	;with BillShow as 
	(select b.id, t.name as [Bàn], b.total as [Tổng tiền(VND)], DateCheckIn as [Ngày check in], DateCheckOut as [Ngày check out], discount [Giảm giá(%)]
	from dbo.Bill as b, dbo.TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1
	and t.id = b.idTable)
	select top (@pageRow) * from BillShow
	where id not in
	(select top (@exceptRow) id from BillShow)
end
go

create proc USP_UpdateAccount
@userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100), @newPassword nvarchar(100)
as
begin
	declare @isRightPass int
	select @isRightPass = count(*) from dbo.Account where UserName = @userName and PassWord = @password
	if (@isRightPass = 1)
	begin
		if (@newPassword = null or @newPassword = '')
		begin
			update dbo.Account set DisplayName = @displayName where UserName = @userName
		end
		else
			update dbo.Account set DisplayName = @displayName, PassWord = @newPassword where UserName = @userName
	end
end
go

create trigger UTG_DeleteBillInfo
on dbo.BillInfo for delete
as
begin
	declare @idBillInfo int
	declare @idBill int
	select @idBillInfo = id, @idBill = idBill from deleted
	declare @count int = 0
	select @count = count(*) from dbo.BillInfo where idBill = @idBill
	if (@count = 0)
		delete dbo.Bill where id = @idBill
end
go

create trigger UTG_DeleteBill
on dbo.Bill for delete
as
begin
	declare @idBill int
	declare @idTable int
	select @idBill = id, @idTable = idTable from deleted
	declare @count int = 0
	select @count = count(*) from dbo.Bill where id = @idBill and status = 0
	if (@count = 0)
		update dbo.TableFood set status = N'Trống' where id = @idTable
end
go

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END

create proc USP_GetNumBillByDate
@checkIn date, @checkOut date
as
begin
	select count(*) from dbo.Bill
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and status = 1
end
go