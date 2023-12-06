CREATE TABLE [dbo].[Category$] (
    [category_id] INT           IDENTITY (1, 1) NOT NULL,
    [code]        INT           NULL,
    [name]        VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([category_id] ASC)
);

