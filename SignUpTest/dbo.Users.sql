CREATE TABLE [dbo].[Users] (
    [UserId]   INT          IDENTITY (1, 1) NOT NULL,
    [UserName] VARCHAR (16) NOT NULL,
    [Password] VARCHAR (25) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);