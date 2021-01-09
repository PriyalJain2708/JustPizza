USE [Demo]
GO
/****** Object:  Table [dbo].[PizzaDetailList]    Script Date: 1/9/2021 2:27:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PizzaDetailList](
	[Pizza_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[state] [nvarchar](50) NOT NULL,
	[zipCode] [int] NOT NULL,
	[category] [nvarchar](50) NOT NULL,
	[rating] [nvarchar](50) NOT NULL,
	[reviewCount] [nvarchar](50) NOT NULL,
	[imageSrc1] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Pizza_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDetailList]    Script Date: 1/9/2021 2:27:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetailList](
	[UserName] [nvarchar](50) NOT NULL,
	[DOB] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Paswd] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PizzaDetailList] ON 

INSERT [dbo].[PizzaDetailList] ([Pizza_id], [name], [address], [city], [state], [zipCode], [category], [rating], [reviewCount], [imageSrc1]) VALUES (5, N'MarginOtto Pizzeria', N'1010 Paddington Way', N'Flavortown', N'NY', 10101, N'Italian', N'5', N'90', N'https://s3.amazonaws.com/codecademy-content/programs/react/ravenous/pizza.jpg')
SET IDENTITY_INSERT [dbo].[PizzaDetailList] OFF
GO
