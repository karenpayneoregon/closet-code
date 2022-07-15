--- Create a database named NorthWind2020 then run the following script

USE [NorthWind2020]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 11/26/2021 9:37:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryIdentifier] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (1, N'Argentina')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (2, N'Austria')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (3, N'Belgium')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (4, N'Brazil')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (5, N'Canada')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (6, N'Denmark')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (7, N'Finland')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (8, N'France')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (9, N'Germany')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (10, N'Ireland')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (11, N'Italy')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (12, N'Mexico')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (13, N'Norway')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (14, N'Poland')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (15, N'Portugal')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (16, N'Spain')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (17, N'Sweden')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (18, N'Switzerland')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (19, N'UK')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (20, N'USA')
GO
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (21, N'Venezuela')
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
