﻿CREATE TABLE [dbo].[Books]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY,
	[Title] NVARCHAR(100) NOT NULL,
	[Author] NVARCHAR(100) NOT NULL,
	[Description] NVARCHAR(500) NOT NULL,
	[Genre] NVARCHAR(50) NOT NULL,
	[Price] DECIMAL(16,2) NOT NULL
)
