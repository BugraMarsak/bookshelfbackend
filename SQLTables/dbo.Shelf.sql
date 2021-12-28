CREATE TABLE [dbo].[Shelf] (
    [ShelfId] INT IDENTITY (1, 1) NOT NULL,
    [UserId]  INT NOT NULL,
    [BookId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ShelfId] ASC)
);

