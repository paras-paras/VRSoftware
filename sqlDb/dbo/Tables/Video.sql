CREATE TABLE [dbo].[Video] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Title]       VARCHAR (500)   NULL,
    [Description] VARCHAR (MAX)   NULL,
    [Genre]       VARCHAR (500)   NULL,
    [Cost]        DECIMAL (18, 2) NULL,
    [ReleaseDate] DATETIME        NULL,
    [Date]        DATETIME        NULL,
    CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED ([Id] ASC)
);

