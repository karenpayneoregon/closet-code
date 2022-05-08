USE [ForumExample]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 5/8/2022 5:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[BookCategory] [int] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookCategory]    Script Date: 5/8/2022 5:18:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_BookCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BookCategory] ON 
GO
INSERT [dbo].[BookCategory] ([Id], [CategoryName]) VALUES (1, N'SpaceTravel')
GO
INSERT [dbo].[BookCategory] ([Id], [CategoryName]) VALUES (2, N'Adventure')
GO
INSERT [dbo].[BookCategory] ([Id], [CategoryName]) VALUES (3, N'Romance')
GO
INSERT [dbo].[BookCategory] ([Id], [CategoryName]) VALUES (4, N'Sports')
GO
INSERT [dbo].[BookCategory] ([Id], [CategoryName]) VALUES (5, N'Automobile')
GO
SET IDENTITY_INSERT [dbo].[BookCategory] OFF
GO
