CREATE TABLE [dbo].[Campaigndetail$] (
    [campaigndetailid] INT IDENTITY (1, 1) NOT NULL,
    [campaignid]       INT NULL,
    [productid]        INT NULL,
    [discount_rate]    INT NULL,
    PRIMARY KEY CLUSTERED ([campaigndetailid] ASC)
);

