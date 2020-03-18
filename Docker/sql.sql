CREATE TABLE [pessoa] (
    [Id] int NOT NULL IDENTITY,
    [Full_name] nvarchar(max) NULL,
    [Birth_date] datetime2 NOT NULL,
    [Gender] int NOT NULL,
    CONSTRAINT [PK_pessoa] PRIMARY KEY ([Id])
);

GO
