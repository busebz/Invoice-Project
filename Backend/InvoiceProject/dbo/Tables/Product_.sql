CREATE TABLE [dbo].[Product$] (
    [productid]   INT           IDENTITY (1, 1) NOT NULL,
    [code]        INT           NULL,
    [name]        VARCHAR (255) NULL,
    [categoryid]  INT           NULL,
    [color]       VARCHAR (255) NULL,
    [width]       INT           NULL,
    [height]      INT           NULL,
    [price]       INT           NULL,
    [create_date] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([productid] ASC)
);

