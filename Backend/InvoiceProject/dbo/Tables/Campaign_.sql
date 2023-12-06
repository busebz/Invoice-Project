CREATE TABLE [dbo].[Campaign$] (
    [campaignid]    INT           IDENTITY (1, 1) NOT NULL,
    [accountid]     INT           NULL,
    [name]          VARCHAR (255) NULL,
    [discount_rate] INT           NULL,
    [start_date]    DATETIME      NULL,
    [end_date]      DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([campaignid] ASC)
);

