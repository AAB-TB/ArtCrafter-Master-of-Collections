CREATE TABLE Category
(
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(MAX)
);

CREATE TABLE CollectionItem
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(MAX),
    PurchaseDate DATE,
    PurchasePrice DECIMAL(18, 2),
    PurchaseLocation NVARCHAR(MAX),
    SaleDate DATE,
    SalePrice DECIMAL(18, 2),
    SaleLocation NVARCHAR(MAX),
    FrontImageFilePath NVARCHAR(MAX),
    BackImageFilePath NVARCHAR(MAX),
    SignatureImageFilePath NVARCHAR(MAX),
    Description NVARCHAR(MAX),
    CategoryID INT FOREIGN KEY REFERENCES Category(CategoryID)
);
