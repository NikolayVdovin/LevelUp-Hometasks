USE [Store]
GO

/****** Object:  Table [dbo].[ShopItemCategories]    Script Date: 26.02.2023 21:50:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ShopItemCategories](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nchar](100) NOT NULL,
	[Description] [nchar](300) NULL,
 CONSTRAINT [PK_ShopItemCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

