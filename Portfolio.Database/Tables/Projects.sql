﻿CREATE TABLE [dbo].[Projects]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Title] NVARCHAR(200) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	[Base64Image] NVARCHAR(MAX) NULL, 
    [Link] NVARCHAR(200) NULL, 
    [LinkTitle] NVARCHAR(200) NULL
)
