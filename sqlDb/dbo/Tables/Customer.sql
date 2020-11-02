CREATE TABLE [dbo].[Customer] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (100) NULL,
    [LastName]  VARCHAR (100) NULL,
    [Phone]     VARCHAR (100) NULL,
    [Address]   VARCHAR (500) NULL,
    [Date]      DATETIME      NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC)
);

