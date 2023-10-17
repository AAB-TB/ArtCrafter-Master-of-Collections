CREATE TABLE CollectionItem
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(MAX),
    PurchaseDate DATE,
    PurchasePrice DECIMAL(18, 2),
    SalePrice DECIMAL(18, 2),
    Description NVARCHAR(MAX), -- Add the Description column
    ImageFilePath NVARCHAR(MAX),
    CategoryID INT FOREIGN KEY REFERENCES Category(CategoryID)
);
CREATE TABLE Category
(
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(MAX)
);