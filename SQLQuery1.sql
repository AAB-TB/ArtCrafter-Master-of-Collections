-- Create the CollectionItem table
CREATE TABLE CollectionItem
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(MAX),
    PurchaseDate DATE,
    PurchasePrice DECIMAL(18, 2),
    SalePrice DECIMAL(18, 2),
    ImageFilePath NVARCHAR(MAX)
);

-- Create the Painting table
CREATE TABLE Painting
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    CollectionItemID INT FOREIGN KEY REFERENCES CollectionItem(ID),
    Artist NVARCHAR(MAX),
    Title NVARCHAR(MAX)
);

-- Create the Book table
CREATE TABLE Book
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    CollectionItemID INT FOREIGN KEY REFERENCES CollectionItem(ID),
    Author NVARCHAR(MAX),
    Title NVARCHAR(MAX)
);

-- Create the Sculpture table
CREATE TABLE Sculpture
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    CollectionItemID INT FOREIGN KEY REFERENCES CollectionItem(ID),
    Artist NVARCHAR(MAX),
    Title NVARCHAR(MAX)
);

-- Create the Frame table
CREATE TABLE Frame
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    CollectionItemID INT FOREIGN KEY REFERENCES CollectionItem(ID),
    Size NVARCHAR(MAX),
    IsEmpty BIT
);
