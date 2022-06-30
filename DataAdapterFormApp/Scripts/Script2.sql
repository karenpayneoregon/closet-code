USE [ForumExample]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 6/13/2022 6:43:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[HiredDate] [date] NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[employee] ON 
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (1, N'Anne', N'Adams', NULL)
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (2, N'Yelena', N'Lebow', NULL)
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (3, N'Greg', N'Lief', CAST(N'2020-10-11' AS Date))
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (4, N'Mary', N'Smith', NULL)
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (5, N'Mary', N'Smith', NULL)
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (6, N'Ken', N'Jones', CAST(N'2020-10-25' AS Date))
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (7, N'Mary', N'Smith', NULL)
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (8, N'Ken', N'Jones', CAST(N'2020-10-25' AS Date))
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (9, N'Mary', N'Smith', NULL)
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (10, N'Ken', N'Jones', CAST(N'2020-10-25' AS Date))
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (11, N'Karen', N'Payne', CAST(N'2021-08-07' AS Date))
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (12, N'Karen', N'Payne', CAST(N'2021-08-07' AS Date))
GO
INSERT [dbo].[employee] ([id], [FirstName], [LastName], [HiredDate]) VALUES (13, N'Karen', N'Payne', CAST(N'2021-08-07' AS Date))
GO
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
