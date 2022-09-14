CREATE DATABASE RestaurantManagement
GO

USE RestaurantManagement
GO
-- Account
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Account
(
	AccountName NVARCHAR(100) NOT NULL,
	Password NVARCHAR(200) NOT NULL,
	FullName NVARCHAR(1000) NOT NULL,
	Email NVARCHAR(1000) NULL,
	Tell NVARCHAR(200) NULL,
	DateCreated SMALLDATETIME NULL,
	CONSTRAINT PK_Account_1 PRIMARY KEY CLUSTERED
		(
			AccountName ASC
		) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
		ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- BillDetails
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE BillDetails
(
	ID INT IDENTITY(1, 1) NOT NULL,
	InBillID INT NOT NULL,
	FoodID INT NOT NULL,
	Quantity INT NOT NULL,
	CONSTRAINT PK_InBillInfo PRIMARY KEY CLUSTERED
		(
			ID ASC
		)
	WITH ( PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY=OFF, ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


-- Bills
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Bills
(
	ID INT IDENTITY (1,1) NOT NULL,
	Name NVARCHAR(1000) NOT NULL,
	TableID INT NOT NULL,
	Amount INT NOT NULL,
	Discount FLOAT NULL,
	Tax FLOAT NULL,
	Status BIT NOT NULL,
	CheckOutDate SMALLDATETIME NOT NULL,
	Account NVARCHAR(100) NOT NULL,

	CONSTRAINT PK_InBill PRIMARY KEY CLUSTERED
	(
		ID ASC
	) WITH (PAD_INDEX =OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--Category
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Category
(
	ID INT IDENTITY (1,1) NOT NULL,
	Name NVARCHAR(1000) NOT NULL,
	Type INT NOT NULL,

	CONSTRAINT PK_FoodCategory PRIMARY KEY CLUSTERED
	(
		ID ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


-- Food
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Food
(
	ID INT IDENTITY(1,1) NOT NULL,
	Name NVARCHAR(1000) NOT NULL,
	Unit NVARCHAR(100) NOT NULL,
	FoodCategoryID INT NOT NULL,
	Price INT NOT NULL,
	Notes NVARCHAR(3000) NULL,

	CONSTRAINT PK_FoodStuffs PRIMARY KEY CLUSTERED
	(
		ID ASC
	) WITH (PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF, ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


-- Role
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Role
(
	ID INT IDENTITY (1,1) NOT NULL,
	RoleName NVARCHAR(1000) NOT NULL,
	Path NVARCHAR(3000) NULL,
	Notes NVARCHAR(3000) NULL,

	CONSTRAINT PK_Role PRIMARY KEY CLUSTERED
	(
		ID ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF,
	ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



-- RoleAccount
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE RoleAccount
(
	RoleID INT NOT NULL,
	AccountName NVARCHAR(100) NOT NULL,
	Actived BIT NOT NULL,
	Notes NVARCHAR(3000) NULL,

	CONSTRAINT PK_RoleAccount PRIMARY KEY CLUSTERED
	(
		RoleID ASC,
		AccountName ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



-- Table
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Table]
(
	ID int IDENTITY(1,1) NOT NULL,
	Name NVARCHAR(1000) NULL,
	Status INT NOT NULL,
	Capacity INT NULL,

	CONSTRAINT PK_Table PRIMARY KEY CLUSTERED
	(	ID ASC
	) WITH (PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF, ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



--Nhập dữ liệu cho Account
INSERT dbo.Account (AccountName, Password, FullName, Email, Tell, DateCreated)
VALUES
(   N'lgcong',                  -- AccountName - nvarchar(100)
    N'Legiacong',                  -- Password - nvarchar(200)
    N'Lê Gia Công',                  -- FullName - nvarchar(1000)
    N'Conglg@dlu.edu.vn',                  -- Email - nvarchar(1000)
    N'',                  -- Tell - nvarchar(200)
    '' -- DateCreated - smalldatetime
    )

INSERT dbo.Account (AccountName, Password, FullName, Email, Tell, DateCreated)
VALUES
(   N'pttnga',                  -- AccountName - nvarchar(100)
    N'phanthithanhnga',                  -- Password - nvarchar(200)
    N'Phan Thị Thanh Nga',                  -- FullName - nvarchar(1000)
    N'ngaptt@dlu.edu.vn',                  -- Email - nvarchar(1000)
    N'',                  -- Tell - nvarchar(200)
    '' -- DateCreated - smalldatetime
    )

INSERT dbo.Account (AccountName, Password, FullName, Email, Tell, DateCreated)
VALUES
(   N'tdquy',                  -- AccountName - nvarchar(100)
    N'thaiduyquy',                  -- Password - nvarchar(200)
    N'Thái Duy Quý',                  -- FullName - nvarchar(1000)
    N'quytd@dlu.edu.vn',                  -- Email - nvarchar(1000)
    N'',                  -- Tell - nvarchar(200)
    '' -- DateCreated - smalldatetime
    )

INSERT dbo.Account (AccountName, Password, FullName, Email, Tell, DateCreated)
VALUES
(   N'ttplinh',                  -- AccountName - nvarchar(100)
    N'tranthiphuonglinh',                  -- Password - nvarchar(200)
    N'Trần Thị Phương Linh',                  -- FullName - nvarchar(1000)
    N'linhttp@dlu.edu.vn',                  -- Email - nvarchar(1000)
    N'',                   -- Tell - nvarchar(200)
    '' -- DateCreated - smalldatetime
    )



-- Nhập dữ liệu cho BillDetails
SET IDENTITY_INSERT dbo.BillDetails ON
INSERT dbo.BillDetails
(
    ID, InBillID, FoodID, Quantity
)
VALUES
(   
	1, --ID - int
	1, -- InBillID - int
    3, -- FoodID - int
    2  -- Quantity - int
    )

INSERT dbo.BillDetails
(
    ID, InBillID, FoodID, Quantity
)
VALUES
(   
	2, --ID - int
	1, -- InBillID - int
    4, -- FoodID - int
    1  -- Quantity - int
    )

SET IDENTITY_INSERT dbo.BillDetails OFF

--Nhập dữ liệu cho bills
SET IDENTITY_INSERT dbo.Bills ON
INSERT dbo.Bills
(
	ID,
    Name,
    TableID,
    Amount,
    Discount,
    Tax,
    Status,
    CheckOutDate,
    Account
)
VALUES
(   1,					   -- ID - int
	N'Hóa đơn thanh toán',                   -- Name - nvarchar(1000)
    5,                     -- TableID - int
    150000,                     -- Amount - int
    0.05,                   -- Discount - float
    0,                   -- Tax - float
    1,                  -- Status - bit
    '', -- CheckOutDate - smalldatetime
    N'tdquy'                    -- Account - nvarchar(100)
    )
SET IDENTITY_INSERT dbo.Bills OFF



-- Nhập dữ liệu cho Category
SET IDENTITY_INSERT dbo.Category ON
INSERT dbo.Category (ID,Name, Type) VALUES (1,N'Khai vị', 1)
INSERT dbo.Category (ID,Name, Type) VALUES (2,N'Hải sản', 1)
INSERT dbo.Category (ID,Name, Type) VALUES (3,N'Gà', 1)
INSERT dbo.Category (ID,Name, Type) VALUES (4,N'Cơm', 1)
INSERT dbo.Category (ID,Name, Type) VALUES (5,N'Thịt', 1)
INSERT dbo.Category (ID,Name, Type) VALUES (6,N'Rau', 1)
INSERT dbo.Category (ID,Name, Type) VALUES (8,N'Canh', 1)
INSERT dbo.Category (ID,Name, Type) VALUES (9,N'Lẩu', 1)
INSERT dbo.Category (ID,Name, Type) VALUES (10,N'Bia', 0)
INSERT dbo.Category (ID,Name, Type) VALUES (11,N'Nước ngọt', 0)
INSERT dbo.Category (ID,Name, Type) VALUES (12,N'Cà phê', 0)
INSERT dbo.Category (ID,Name, Type) VALUES (13,N'Trà đá', 0)
SET IDENTITY_INSERT dbo.Category OFF


-- Nhập dữ liệu cho bảng Food
SET IDENTITY_INSERT dbo.Food ON
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (1,N'Rau muống xào tỏi', N'Đĩa', 6, 20000, N'')
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (2,N'Cơm chiên dương châu', N'Đĩa nhỏ', 4, 35000, N'3 người ăn')
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (3,N'Cơm chiên dương châu', N'Đĩa lớn', 4, 40000, N'4 người ăn')
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (4,N'Ếch thui rơm', N'Đĩa', 2, 70000, N'')
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (5,N'Sò lông nướng mỡ hành', N'Đĩa', 2, 80000, N'')
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (6,N'Càng cua hấp', N'Đĩa', 2, 100000, N'')
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (7,N'Canh cải', N'Tô', 8, 20000, N'')
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (8,N'Gà nướng muối ớt', N'Con', 3, 180000, N'')
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (9,N'Bia 333', N'Chai', 10, 12000, N'')
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (10,N'Bia Heniken', N'Chai', 10, 20000, N'')
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (11,N'Súp cua', N'Đĩa', 5, 25000, N'Theo thời giá')
INSERT dbo.Food (ID,Name,Unit,FoodCategoryID,Price,Notes)
VALUES (12,N'Thịt kho', N'Đĩa', 5, 25000, N'Theo thời giá')
SET IDENTITY_INSERT dbo.Food OFF


-- Nhập dữ liệu cho Role
SET IDENTITY_INSERT dbo.Role ON

INSERT dbo.Role(ID,RoleName,Path,Notes) VALUES (1,N'Adminstrator',N'', N'')
INSERT dbo.Role(ID,RoleName,Path,Notes) VALUES (2,N'Kế toán',N'', N'')
INSERT dbo.Role(ID,RoleName,Path,Notes) VALUES (3,N'Nhân viên thanh toán',N'', N'')
INSERT dbo.Role(ID,RoleName,Path,Notes) VALUES (4,N'Nhân viên phục vụ',N'', N'')
SET IDENTITY_INSERT dbo.Role OFF


-- Nhập dữ liệu cho RoleAccount
INSERT dbo.RoleAccount (RoleID,AccountName,Actived,Notes)
VALUES (1,N'lgcong',1,N'')
INSERT dbo.RoleAccount (RoleID,AccountName,Actived,Notes)
VALUES (1,N'pttnga',1,N'')
INSERT dbo.RoleAccount (RoleID,AccountName,Actived,Notes)
VALUES (1,N'tdquy',1,N'')
INSERT dbo.RoleAccount (RoleID,AccountName,Actived,Notes)
VALUES (1,N'ttplinh',1,N'')
INSERT dbo.RoleAccount (RoleID,AccountName,Actived,Notes)
VALUES (3,N'lgcong',0,N'')
INSERT dbo.RoleAccount (RoleID,AccountName,Actived,Notes)
VALUES (3,N'pttnga',0,N'')
INSERT dbo.RoleAccount (RoleID,AccountName,Actived,Notes)
VALUES (3,N'tdquy',1,N'')
INSERT dbo.RoleAccount (RoleID,AccountName,Actived,Notes)
VALUES (3,N'ttplinh',1,N'')



-- Nhập dữ liệu cho table
SET IDENTITY_INSERT dbo.[Table] ON
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (1,N'01',0,4)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (2,N'02',0,4)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (4,N'03',0,4)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (5,N'04',0,6)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (6,N'05',0,8)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (8,N'06',0,8)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (1002,N'07',0,8)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (1003,N'08',0,12)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (1004,N'09',0,12)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (1005,N'10',0,15)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (1006,N'VIP.1',0,20)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (1007,N'VIP.2',0,20)
INSERT dbo.[Table] (ID,Name,Status,Capacity)
VALUES (1008,N'VIP.3',0,20)
SET IDENTITY_INSERT dbo.[Table] OFF


ALTER TABLE dbo.BillDetails ADD CONSTRAINT DF_InBillDetails_amount DEFAULT ((0)) FOR Quantity
GO

ALTER TABLE dbo.Food ADD CONSTRAINT DF_Food_Price DEFAULT ((0)) FOR Price
GO

ALTER TABLE dbo.BillDetails WITH CHECK ADD CONSTRAINT FK_InBillInfo_FoodStuffs FOREIGN KEY (FoodID)
REFERENCES dbo.Food (ID)
GO

ALTER TABLE dbo.BillDetails CHECK CONSTRAINT FK_InBillInfo_FoodStuffs
GO

ALTER TABLE dbo.BillDetails WITH CHECK ADD CONSTRAINT FK_InBillInfo_InBill FOREIGN KEY(InBillID)
REFERENCES dbo.Bills (ID)
GO

ALTER TABLE dbo.BillDetails CHECK CONSTRAINT FK_InBillInfo_Inbill
GO

ALTER TABLE dbo.Bills WITH CHECK ADD CONSTRAINT FK_InBill_Table FOREIGN KEY(TableID)
REFERENCES dbo.[Table] (ID)
GO

ALTER TABLE dbo.Bills CHECK CONSTRAINT FK_InBill_Table
GO

ALTER TABLE dbo.Food WITH CHECK ADD CONSTRAINT FK_FoodStuffs_FoodCategory FOREIGN KEY(FoodCategoryID)
REFERENCES dbo.Category (ID)
GO

ALTER TABLE dbo.Food CHECK CONSTRAINT FK_FoodStuffs_FoodCategory
GO

ALTER TABLE dbo.RoleAccount WITH CHECK ADD CONSTRAINT FK_RoleAccount_Account FOREIGN KEY (AccountName)
REFERENCES dbo.Account (AccountName)
GO

ALTER TABLE dbo.RoleAccount CHECK CONSTRAINT FK_RoleAccount_Account
GO

ALTER TABLE dbo.RoleAccount WITH CHECK ADD CONSTRAINT FK_RoleAccount_Role FOREIGN KEY(RoleID)
REFERENCES dbo.Role(ID)
GO

ALTER TABLE dbo.RoleAccount CHECK CONSTRAINT FK_RoleAccount_Role
GO

CREATE PROCEDURE InsertFood
@ID INT OUTPUT,
@Name NVARCHAR(3000),
@Unit NVARCHAR(3000),
@FoodCategoryID INT,
@Price INT,
@Notes NVARCHAR(3000)
AS
	INSERT INTO dbo.Food(Name,Unit,FoodCategoryID,Price,Notes)
	VALUES(@Name,@Unit,@FoodCategoryID,@Price,@Notes)

	SELECT @ID = SCOPE_IDENTITY()
GO

SELECT f.Name,f.Price,bd.Quantity,f.Price * bd.Quantity AS Amount FROM dbo.Food f, dbo.BillDetails bd, dbo.Bills b
WHERE bd.FoodID = f.ID AND bd.InBillID = b.ID AND bd.InBillID = 1

SELECT SUM(f.Price * bd.Quantity) FROM dbo.Food f, dbo.BillDetails bd, dbo.Bills b
WHERE bd.FoodID = f.ID AND bd.InBillID = b.ID AND bd.InBillID = 1


-- Bước 5 
-- Lấy hết thông tin bằng lệnh select * from
SELECT * FROM dbo.Food
SELECT * FROM dbo.Category
SELECT * FROM dbo.[Table]
SELECT * FROM dbo.Bills
SELECT * FROM dbo.BillDetails
SELECT * FROM dbo.RoleAccount
SELECT * FROM dbo.Role
SELECT * FROM dbo.Account

-- Lấy thông tin có điều kiện Select * From [Table] where [column] = value 
SELECT * FROM dbo.Food WHERE Price < 100000

-- Thêm dữ liệu vào bảng bằng lệnh Insert into [Table] value (...)
INSERT INTO dbo.Food
(Name,Unit,FoodCategoryID,Price,Notes)
VALUES(   N'Hủ tiếu',N'Tô',8,30000,N'Hủ tiếu thơm ngon')

-- Cập nhật dữ liệu bằng lệnh Update [table] Set ...
UPDATE dbo.Food SET Price = 40000 WHERE ID = 13
SELECT * FROM dbo.Food
GO
--Xóa dữ liệu bằng Delete from [Table]
--   DELETE FROM dbo.Food


-- Các thủ tục 
-- Food
CREATE PROCEDURE Food_Insert 
@ID int output,
@Name nvarchar(3000), 
@Unit nvarchar(3000), 
@FoodCategoryID int, 
@Price int,  
@Notes nvarchar(3000)
AS
	INSERT INTO Food (Name, Unit, FoodCategoryID, Price,  Notes)
	VALUES ( @Name, @Unit, @FoodCategoryID, @Price,  @Notes)

	SELECT @ID = SCOPE_IDENTITY()
go

declare @ID int
exec Food_Insert @ID,N'Hủ tiếu lv2','Tô',8,50000,NULL
select * from Food

drop procedure Food_Insert
GO


-- Table
CREATE PROCEDURE Table_Insert 
(
	@ID int output,
	@Name nvarchar(1000),
	@Status int ,
	@Capacity int
)
AS
	INSERT INTO [Table] (Name, Status, Capacity)
	VALUES ( @Name, @Status, @Capacity)
	SELECT @ID = @@IDENTITY;
GO


DECLARE @ID int
EXEC Table_Insert @ID,'Alo',0,8
SELECT * FROM dbo.[Table]
DROP PROCEDURE Table_Insert
GO


-- Bill
CREATE PROCEDURE Bills_Insert
(
	@ID int output,
	@Name nvarchar(1000),
	@TableID int,
	@Amount int,
	@Discount float,
	@Tax float,
	@Status bit,
	@CheckoutDate smalldatetime,
	@Account nvarchar(100)
)
AS  
	if (not exists(select Name from dbo.Bills where Name = @Name))
	INSERT INTO Bills (Name,TableID,Amount,Discount,Tax,Status,CheckoutDate,Account)
	VALUES (@Name,@TableID,@Amount,@Discount,@Tax,@Status,@CheckoutDate,@Account)
	select @ID = @@IDENTITY
GO 
DECLARE @ID int 
EXEC Bills_Insert @ID, 'Hóa đơn thanh toán',4,330000,0.2,0,1,0,'lgcong'
SELECT * FROM dbo.Bills
GO

-- BillDetails
CREATE PROCEDURE BillDetails_Insert -- Bảng billDetails
(
	@ID int,
	@InvoiceID int,
	@FoodID int,
	@Quantity int
)
AS 
	INSERT INTO BillDetails (ID,InBillID,FoodID,Quantity)
	VALUES (@ID,@InvoiceID,@FoodID,@Quantity)
	select @ID = @@IDENTITY
GO 
DECLARE @ID int

SELECT * FROM BillDetails
GO

-- Account
CREATE PROCEDURE Account_Insert 
(
	@AccountName nvarchar(100),
	@Password nvarchar(200),
	@FullName nvarchar(1000),
	@Email nvarchar(1000),
	@Tell nvarchar(200),
	@DateCreated smalldatetime
)
AS
BEGIN
	if(not exists (select AccountName from dbo.Account where AccountName = @AccountName))
		insert into dbo.Account(AccountName,Password,FullName,Email,Tell,DateCreated)
					values (@AccountName,@Password,@FullName,@Email,@Tell,@DateCreated)
END
GO

EXEC Account_Insert 'ntn','trungnguyen',N'Nguyễn Trung Nguyên','1914626@dlu.edu.vn',NULL,NULL
SELECT * FROM Account
DROP PROCEDURE Account_Insert;
GO


-- Role
CREATE PROCEDURE Role_Insert
(
	@ID int output,
	@RoleName nvarchar(1000),
	@Path nvarchar(3000),
	@Notes nvarchar(3000)
)
AS
BEGIN
	insert into [Role] (RoleName,Path,Notes)
	values (@RoleName,@Path,@Notes)
	SELECT @ID = SCOPE_IDENTITY()
END
GO
DECLARE @ID int
EXEC dbo.Role_Insert @ID,N'Nhân viên phục vụ',NULL,NULL
SELECT * FROM dbo.Role

drop procedure dbo.Role_Insert
GO

-- Role Account
CREATE PROCEDURE RollAccout_Insert 
(
	@RoleID int ,
	@AccountName nvarchar(100) ,
	@Actived bit ,
	@Notes nvarchar(3000)
)
AS  
	INSERT INTO [RoleAccount] (RoleID,AccountName,Actived,Notes)
	VALUES (@RoleID,@AccountName,@Actived,@Notes)
GO

EXEC RollAccout_Insert 4,'pttnga',1,NULL
DROP PROCEDURE RollAccout_Insert
GO


-- Category
-- Lấy hết dữ liệu
CREATE PROCEDURE Category_All
AS
BEGIN 
	SELECT * FROM dbo.Category
END
GO 
EXEC Category_All;
DROP PROCEDURE Category_All
GO


-- Lấy hết dữ liệu theo ID
CREATE PROCEDURE Category_GetAll
(
	@ID int
)
AS 
BEGIN
	SELECT * FROM dbo.Category WHERE ID = @ID
END
GO
EXEC Category_GetAll;
DROP PROCEDURE Category_GetAll
GO 


--Thêm dữ liệu vào
CREATE PROCEDURE Category_Insert
(
	@Name nvarchar(1000),
	@Type int
)
AS
BEGIN
	IF (NOT EXISTS (SELECT Name FROM dbo.Category WHERE Name = @Name))
		INSERT INTO dbo.Category
		(
		    Name,
		    Type
		)
		VALUES
		(   @Name, -- Name - nvarchar(1000)
		    @Type -- Type - int
		    )
END
GO
EXEC Category_Insert N'Dưa hấu', 1
DROP PROCEDURE Category_Insert;
GO


-- Cập nhật
-- Category
CREATE PROCEDURE Category_Update -- Bảng category
(
	@ID int,
	@Name nvarchar(1000),
	@Type int
)
AS 
BEGIN 
	UPDATE dbo.Category
	SET [Name] = @Name, [Type] = Type
	WHERE ID = @ID
END 
GO 


--Table
CREATE PROCEDURE Table_Update
(
	@ID int,
	@Name nvarchar(1000),
	@Status int ,
	@Capacity int
)
AS 
BEGIN
	UPDATE dbo.[Table]
	SET [Name] = @Name, [Status] = @Status, [Capacity] = @Capacity 
	WHERE ID = @ID
END
GO


-- Food
CREATE PROCEDURE Food_Update 
(
	@ID int,
	@Name nvarchar(3000), 
	@Unit nvarchar(3000), 
	@FoodCategoryID int, 
	@Price int,  
	@Notes nvarchar(3000)
)
AS
	UPDATE dbo.[Food]
	SET [Name] = @Name, [Unit] = @Unit, [FoodCategoryID] = @FoodCategoryID, [Price] = @Price, [Notes] = @Notes
	WHERE ID = @ID
GO

-- Bills
CREATE PROCEDURE Bills_Update -- Bảng Bills
(
	@ID int output,
	@Name nvarchar(1000),
	@TableID int,
	@Amount int,
	@Discount float,
	@Tax float,
	@Status bit,
	@CheckoutDate smalldatetime,
	@Account nvarchar(100)
)
AS
	UPDATE dbo.Bills
	SET [Name] = @Name, TableID = @TableID, Amount = @Amount, Discount = @Discount, Tax = @Tax, [Status] = @Status, [CheckoutDate] = @CheckoutDate, Account = @Account
	WHERE ID = @ID
GO


-- Bill Details
CREATE PROCEDURE BillDetails_Update
(
	@ID int,
	@InvoiceID int,
	@FoodID int,
	@Quantity int
)
AS
	UPDATE dbo.BillDetails
	SET InBillID = @InvoiceID, FoodID = @FoodID, Quantity = @Quantity
	WHERE ID = @ID -- Bảng BillDetails
GO

-- Account
CREATE PROCEDURE Account_Update 
(
	@AccountName nvarchar(100),
	@Password nvarchar(200),
	@FullName nvarchar(1000),
	@Email nvarchar(1000),
	@Tell nvarchar(200),
	@DateCreated smalldatetime
)
AS
	UPDATE dbo.Account
	SET AccountName = @AccountName, [Password] = @Password, FullName =@FullName, Email = @Email, Tell = @Tell, DateCreated = @DateCreated
GO


-- Role
CREATE PROCEDURE Role_Update -- Bảng role
(
	@ID int output,
	@RoleName nvarchar(1000),
	@Path nvarchar(3000),
	@Notes nvarchar(3000)
)
AS
	UPDATE dbo.[Role]
	SET RoleName = @RoleName, [Path] = @Path, Notes = @Notes
GO


CREATE PROCEDURE RollAccount_Update
(
	@RoleID int ,
	@AccountName nvarchar(100) ,
	@Actived bit ,
	@Notes nvarchar(3000)
)
AS
	UPDATE dbo.RoleAccount
	SET RoleID = @RoleID, AccountName = @AccountName, Actived = @Actived, Notes = @Notes
GO



--Thủ tục xóa
--category
CREATE PROCEDURE Category_Delete
(
	@ID int
)
AS
BEGIN
	DELETE FROM Category
	WHERE ID = @ID
END
GO

EXEC Category_Delete 1
DROP PROCEDURE Category_Delete;
GO



--food
CREATE PROCEDURE Food_Delete
(
	@ID int,
	@Name nvarchar(3000), 
	@Unit nvarchar(3000), 
	@FoodCategoryID int, 
	@Price int,  
	@Notes nvarchar(3000)
)
AS
	DELETE FROM Food
	WHERE ID = @ID
GO


--Bill
CREATE PROCEDURE Bills_Delete
(
	@ID int output,
	@Name nvarchar(1000),
	@TableID int,
	@Amount int,
	@Discount float,
	@Tax float,
	@Status bit,
	@CheckoutDate smalldatetime,
	@Account nvarchar(100)
)
AS
	DELETE FROM Bills
	WHERE ID = @ID
GO


--BillDetails
CREATE PROCEDURE BillDetails_Delete
(
	@ID int,
	@InvoiceID int,
	@FoodID int,
	@Quantity int
)
AS
	DELETE FROM BillDetails
	WHERE ID = @ID
GO

--Account
CREATE PROCEDURE Account_Delete
(
	@AccountName nvarchar(100),
	@Password nvarchar(200),
	@FullName nvarchar(1000),
	@Email nvarchar(1000),
	@Tell nvarchar(200),
	@DateCreated smalldatetime
)
AS
	DELETE FROM Account
	WHERE AccountName = @AccountName
GO


--Role
CREATE PROCEDURE Role_Delete
(
	@ID int output,
	@RoleName nvarchar(1000),
	@Path nvarchar(3000),
	@Notes nvarchar(3000)
)
AS
	DELETE FROM [Role]
	WHERE ID = @ID
GO


--role account
CREATE PROCEDURE RollAccount_Delete
(
	@RoleID int ,
	@AccountName nvarchar(100) ,
	@Actived bit ,
	@Notes nvarchar(3000)
)
AS
	DELETE FROM RoleAccount
	WHERE RoleID = @RoleID
GO

-- Viết một thủ tục _GetAll để lấy dữ liệu của tất cả các bảng, truyền vào tên bảng
CREATE PROC _GetAll
(
	@TableName nvarchar(50)
)
AS
BEGIN
	DECLARE @SQL nvarchar(1000) set @SQL = ''
	SET @SQL = @SQL + 'select * from ' + @TableName
	EXEC(@SQL)
END
GO


-- Viết một thủ tục _GetByID để lấy dữ liệu của tất cả các bảng có ID là kiểu int, khóa chính và tự tăng. Tham số truyền vào ID và tên bảng. 
CREATE PROC _GetByID
(
	@ID int,
	@TableName nvarchar(1000)
)
AS
BEGIN
	DECLARE @sql nvarchar(1000)
	SET @sql ='select * from ' + @TableName +' Where ID = ' + CAST(@ID as nvarchar)
	EXEC (@sql)
END
GO


-- Viết thủ tục _delete để xóa dữ liệu của bất kỳ bảng nào có ID là kiểu int, khóa chính và tự tăng.Tham số truyền vào là ID và tên bảng 

CREATE PROC _Delete
(
	@ID int,
	@TableName nvarchar(1000)
)
AS
BEGIN
	DECLARE @sql nvarchar(1000)
	SET @sql='Delete from ' +@TableName + 'Where ID='+CAST(@ID as nvarchar)
	EXEC(@sql)
END
GO
-- Viết thủ tục để khi thêm quyền vào bảng Role thì tự động gán hết quyền cho các User (Insert vào bảng UserRole, nhưng để Active = false)

-- Viết hàm tính số tiền bán được theo ngày
CREATE PROC UpdateBill
AS 
BEGIN 
	UPDATE dbo.[Bills]
	SET Amount = (select SUM(Quantity * Price)
				  from BillDetails bd, Food f
				  where bd.FoodID = f.id
				  group by bd.InBillID)
END
GO

CREATE FUNCTION SumOnDate(@Day INT) RETURNS INT
AS
BEGIN
	DECLARE @Sum int = 0
	SET @Sum = (select SUM(Amount)
				from Bills
				where DAY(CheckoutDate) = @Day
				group by CheckoutDate)
	RETURN @sum
END
GO 
EXEC dbo.UpdateBill
PRINT dbo.SumOnDate(2)
GO

--  Viết hàm đếm số lượng món ăn bán được theo ngày
CREATE FUNCTION CountFoodInDay(@Day int) RETURNS INT
AS
BEGIN
	DECLARE @Count int
	SET @Count = (select count(distinct bd.FoodID)
				  from Bills b, BillDetails bd
				  where b.ID = bd.InBillID and day(CheckoutDate) = @Day
				  group by b.ID)
	RETURN @count
END
GO


-- Viết thủ tục thống kê số tiền bán được theo từng loại món ăn, theo ngày
CREATE PROC SumOnDateCategoryAndDay
(
	@CategoryName nvarchar(1000),
	@Day int
)
AS
BEGIN
	select c.Name, sum(Price * Quantity) as SumOnDateCategory
	from Bills b, BillDetails bd, Food f, Category c
	where b.ID = bd.InBillID and bd.FoodID = f.ID and f.FoodCategoryID = c.ID and c.Name = @CategoryName and DAY(CheckoutDate) = @Day
	group by c.Name
END
GO
EXEC dbo.SumOnDateCategoryAndDay N'Cơm', 2





