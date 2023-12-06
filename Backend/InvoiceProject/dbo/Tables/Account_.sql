CREATE TABLE [dbo].[Account$] (
    [accountid]   INT           IDENTITY (1, 1) NOT NULL,
    [accountType] VARCHAR (255) NULL,
    [name]        VARCHAR (255) NULL,
    [code]        INT           NULL,
    [address]     VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([accountid] ASC)
);

