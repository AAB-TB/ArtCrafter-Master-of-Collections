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
    SalePrice DECIMAL(18, 2),
    FrontImageFilePath NVARCHAR(MAX), -- Add the FrontImageFilePath column
    BackImageFilePath NVARCHAR(MAX),  -- Add the BackImageFilePath column
    Description NVARCHAR(MAX),
    CategoryID INT FOREIGN KEY REFERENCES Category(CategoryID)
);
