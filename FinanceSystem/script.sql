USE [dbFinanceApp]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 28.11.2021 21:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employe]    Script Date: 28.11.2021 21:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone] [nchar](13) NOT NULL,
 CONSTRAINT [PK_Employe] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 28.11.2021 21:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[IDDepartments] [int] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requisites]    Script Date: 28.11.2021 21:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requisites](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TitleBank] [nvarchar](50) NOT NULL,
	[CardNumber] [nvarchar](50) NOT NULL,
	[ActiveDate] [date] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Requisites] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SignIn]    Script Date: 28.11.2021 21:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SignIn](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[IDEmploye] [int] NOT NULL,
 CONSTRAINT [PK_SignIn] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 28.11.2021 21:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[IDGroup] [int] NOT NULL,
	[Phone] [nchar](13) NOT NULL,
	[IDRequisites] [int] NOT NULL,
	[IDType] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 28.11.2021 21:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DateTransaction] [date] NOT NULL,
	[IDStudent] [int] NOT NULL,
	[Scholarship] [money] NOT NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 28.11.2021 21:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Scholarship] [money] NOT NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([ID], [Title]) VALUES (1, N'Информационные системы и программирование')
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Employe] ON 

INSERT [dbo].[Employe] ([ID], [FirstName], [LastName], [Patronymic], [Email], [Phone]) VALUES (1, N'Title 1', N'Title 1', N'Title 1', N'Title@gmail.com', N'+79998887777 ')
INSERT [dbo].[Employe] ([ID], [FirstName], [LastName], [Patronymic], [Email], [Phone]) VALUES (2, N'fdas', N'fdsafdasf', N'fdasfa', N'thevckit@gmail.com', N'34432        ')
INSERT [dbo].[Employe] ([ID], [FirstName], [LastName], [Patronymic], [Email], [Phone]) VALUES (3, N'fkjaldskjfs', N'kjflkadjsf', N'fkdjaskl', N'abdulkhak1m@mail.ru', N'+79234343434 ')
SET IDENTITY_INSERT [dbo].[Employe] OFF
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([ID], [Title], [IDDepartments]) VALUES (1, N'8', 1)
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
SET IDENTITY_INSERT [dbo].[Requisites] ON 

INSERT [dbo].[Requisites] ([ID], [TitleBank], [CardNumber], [ActiveDate], [Name]) VALUES (1, N'fdsfs', N'3214124', CAST(N'0001-01-01' AS Date), N'fadsfsad')
INSERT [dbo].[Requisites] ([ID], [TitleBank], [CardNumber], [ActiveDate], [Name]) VALUES (2, N'fdsf324423', N'43242', CAST(N'0001-01-01' AS Date), N'fdafd')
INSERT [dbo].[Requisites] ([ID], [TitleBank], [CardNumber], [ActiveDate], [Name]) VALUES (3, N'fsdfs', N'432423', CAST(N'0001-01-01' AS Date), N'fdfsd')
INSERT [dbo].[Requisites] ([ID], [TitleBank], [CardNumber], [ActiveDate], [Name]) VALUES (4, N'qqqqq', N'111111111111', CAST(N'0001-01-01' AS Date), N'qqqqqqqqqqqq')
INSERT [dbo].[Requisites] ([ID], [TitleBank], [CardNumber], [ActiveDate], [Name]) VALUES (5, N'Сбербанк', N'82378621876412', CAST(N'0001-01-18' AS Date), N'Ivanov Ivan')
INSERT [dbo].[Requisites] ([ID], [TitleBank], [CardNumber], [ActiveDate], [Name]) VALUES (6, N'Сбербанк', N'412412412412412', CAST(N'0001-01-01' AS Date), N'VALERIA')
SET IDENTITY_INSERT [dbo].[Requisites] OFF
GO
SET IDENTITY_INSERT [dbo].[SignIn] ON 

INSERT [dbo].[SignIn] ([ID], [Username], [Password], [IDEmploye]) VALUES (2, N'user', N'user', 1)
SET IDENTITY_INSERT [dbo].[SignIn] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [Patronymic], [IDGroup], [Phone], [IDRequisites], [IDType]) VALUES (2, N'fafa', N'fdsa', N'fds', 1, N'43124        ', 2, 1)
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [Patronymic], [IDGroup], [Phone], [IDRequisites], [IDType]) VALUES (5, N'Иванов', N'Иван', N'Иванович', 1, N'+79288887766 ', 5, 2)
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [Patronymic], [IDGroup], [Phone], [IDRequisites], [IDType]) VALUES (6, N'Дибкина', N'Валерия', N'Валентиновна', 1, N'+98876354664 ', 6, 3)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[Transaction] ON 

INSERT [dbo].[Transaction] ([ID], [DateTransaction], [IDStudent], [Scholarship]) VALUES (5, CAST(N'2021-11-28' AS Date), 2, 1300.0000)
INSERT [dbo].[Transaction] ([ID], [DateTransaction], [IDStudent], [Scholarship]) VALUES (8, CAST(N'2021-11-28' AS Date), 2, 1300.0000)
INSERT [dbo].[Transaction] ([ID], [DateTransaction], [IDStudent], [Scholarship]) VALUES (11, CAST(N'2021-11-28' AS Date), 2, 1300.0000)
INSERT [dbo].[Transaction] ([ID], [DateTransaction], [IDStudent], [Scholarship]) VALUES (14, CAST(N'2021-11-28' AS Date), 2, 1300.0000)
INSERT [dbo].[Transaction] ([ID], [DateTransaction], [IDStudent], [Scholarship]) VALUES (17, CAST(N'2021-11-28' AS Date), 2, 1300.0000)
INSERT [dbo].[Transaction] ([ID], [DateTransaction], [IDStudent], [Scholarship]) VALUES (20, CAST(N'2021-11-28' AS Date), 2, 1300.0000)
INSERT [dbo].[Transaction] ([ID], [DateTransaction], [IDStudent], [Scholarship]) VALUES (21, CAST(N'2021-11-28' AS Date), 5, 900.0000)
INSERT [dbo].[Transaction] ([ID], [DateTransaction], [IDStudent], [Scholarship]) VALUES (22, CAST(N'2021-11-28' AS Date), 6, 0.0000)
SET IDENTITY_INSERT [dbo].[Transaction] OFF
GO
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([ID], [Title], [Scholarship]) VALUES (1, N'Отличник', 1300.0000)
INSERT [dbo].[Type] ([ID], [Title], [Scholarship]) VALUES (2, N'Хорошист', 900.0000)
INSERT [dbo].[Type] ([ID], [Title], [Scholarship]) VALUES (3, N'Троечник', 0.0000)
SET IDENTITY_INSERT [dbo].[Type] OFF
GO
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_Departments] FOREIGN KEY([IDDepartments])
REFERENCES [dbo].[Departments] ([ID])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_Departments]
GO
ALTER TABLE [dbo].[SignIn]  WITH CHECK ADD  CONSTRAINT [FK_SignIn_Employe] FOREIGN KEY([IDEmploye])
REFERENCES [dbo].[Employe] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SignIn] CHECK CONSTRAINT [FK_SignIn_Employe]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Group] FOREIGN KEY([IDGroup])
REFERENCES [dbo].[Group] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Group]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Requisites] FOREIGN KEY([IDRequisites])
REFERENCES [dbo].[Requisites] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Requisites]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Type] FOREIGN KEY([IDType])
REFERENCES [dbo].[Type] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Type]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Student] FOREIGN KEY([IDStudent])
REFERENCES [dbo].[Student] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Student]
GO
