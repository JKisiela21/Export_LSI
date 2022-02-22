CREATE TABLE [dbo].[Exports] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [ExportName] VARCHAR (100) NOT NULL,
    [ExportDate] DATETIME      NOT NULL,
    [UserName]   VARCHAR (100) NOT NULL,
    [Place]      VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

