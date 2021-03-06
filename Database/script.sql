USE [Demo]
GO
/****** Object:  Table [dbo].[tbl_pizzadetails]    Script Date: 1/12/2021 1:00:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_pizzadetails](
	[Pizza_id] [int] NOT NULL,
	[imageSrc] [varchar](500) NULL,
	[name] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[city] [varchar](100) NULL,
	[state] [varchar](100) NULL,
	[zipCode] [int] NULL,
	[category] [varchar](100) NULL,
	[rating] [int] NULL,
	[reviewCount] [int] NULL,
 CONSTRAINT [PK_tbl_pizzadetails] PRIMARY KEY CLUSTERED 
(
	[Pizza_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 1/12/2021 1:00:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetails](
	[UserName] [varchar](50) NULL,
	[DateOfBirth] [varchar](255) NULL,
	[City] [varchar](255) NULL,
	[Password] [varchar](255) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_pizzadetails] ([Pizza_id], [imageSrc], [name], [address], [city], [state], [zipCode], [category], [rating], [reviewCount]) VALUES (1, N'https://s3.amazonaws.com/codecademy-content/programs/react/ravenous/pizza.jpg', N'MarginOtto Pizzeria', N'1010 Paddington Way', N'Flavortown', N'NY', 10101, N'Italian', 5, 90)
GO
INSERT [dbo].[UserDetails] ([UserName], [DateOfBirth], [City], [Password]) VALUES (N'Mahima', N'1996', N'Bhilai', N'mahima1')
INSERT [dbo].[UserDetails] ([UserName], [DateOfBirth], [City], [Password]) VALUES (N'Priyal', N'1996', N'Bhilai', N'priyal1')
INSERT [dbo].[UserDetails] ([UserName], [DateOfBirth], [City], [Password]) VALUES (N'Bob', N'0', N'Durg', N'Bob1')
INSERT [dbo].[UserDetails] ([UserName], [DateOfBirth], [City], [Password]) VALUES (N'Bob', N'27-11-2000', N'Durg', N'Bob1')
INSERT [dbo].[UserDetails] ([UserName], [DateOfBirth], [City], [Password]) VALUES (N'Rahul', N'28-04-1993', N'Bhopal', N'12345')
INSERT [dbo].[UserDetails] ([UserName], [DateOfBirth], [City], [Password]) VALUES (N'Rahul1', N'28-04-1993', N'Bhopal', N'12345')
GO
