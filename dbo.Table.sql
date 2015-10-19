CREATE TABLE [dbo].[Table] (
    [suggestionid]    INT            NOT NULL,
    [username]        NVARCHAR (20)  NOT NULL,
    [department]      NVARCHAR (30)  NULL,
    [subject]         NCHAR (50)     NOT NULL,
    [suggestion]      NVARCHAR (MAX) NOT NULL,
    [date-time]       DATETIME       NOT NULL,
    [status]          INT            DEFAULT ((0)) NOT NULL,
    [admin1note]      NVARCHAR (MAX) NULL,
    [admin2note]      NVARCHAR (MAX) NULL,
    [admin3note]      NVARCHAR (MAX) NULL,
    [likes]           INT            DEFAULT ((0)) NOT NULL,
    [suggestion_temp] NVARCHAR (80)  NULL,
    [name] NVARCHAR(30) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([suggestionid] ASC)
);

