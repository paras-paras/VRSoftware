CREATE TABLE [dbo].[Rental] (
    [Id]           INT      IDENTITY (1, 1) NOT NULL,
    [CustomerId]   INT      NULL,
    [VideoId]      INT      NULL,
    [IssuedDate]   DATETIME NULL,
    [ReturnedDate] DATETIME NULL,
    [IsReturned]   BIT      NULL,
    [Date]         DATETIME NULL,
    CONSTRAINT [PK_Rental] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Rental_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Rental_Video] FOREIGN KEY ([VideoId]) REFERENCES [dbo].[Video] ([Id]) ON DELETE CASCADE
);

