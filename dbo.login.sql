CREATE TABLE [dbo].[login] (
    [username]     NCHAR (10) NOT NULL,
    [password]     NCHAR (10) NOT NULL,
    [account_type] INT        DEFAULT ((0)) NOT NULL,
    [uid] NCHAR(10) NOT NULL,
    PRIMARY KEY CLUSTERED ([uid])
);

