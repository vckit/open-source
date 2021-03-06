USE [dbMed]
GO
/****** Object:  Table [dbo].[District]    Script Date: 14.12.2021 21:39:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[District](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TItle] [nvarchar](50) NOT NULL,
	[Count] [int] NOT NULL,
	[IDPolyclinic] [int] NULL,
 CONSTRAINT [PK_District] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 14.12.2021 21:39:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[DateOfBirth] [date] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[INN] [nvarchar](50) NOT NULL,
	[IDPolyclinic] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 14.12.2021 21:39:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[MedicalCardNumber] [char](20) NOT NULL,
	[CodeDisease] [char](10) NOT NULL,
	[TitleInsuranceCompany] [nvarchar](50) NOT NULL,
	[TitleDisease] [nvarchar](100) NOT NULL,
	[IDPolyclinic] [int] NOT NULL,
	[IDDistrict] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Polyclinic]    Script Date: 14.12.2021 21:39:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Polyclinic](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NumberPolyclinic] [nchar](10) NOT NULL,
	[AddressPolyclinic] [nvarchar](50) NOT NULL,
	[ReportingYear] [date] NOT NULL,
	[NSWHE] [int] NOT NULL,
	[NSWSSE] [int] NOT NULL,
	[CountSupportStaf] [int] NOT NULL,
 CONSTRAINT [PK_Polyclinic] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PolyclinicDistrict]    Script Date: 14.12.2021 21:39:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PolyclinicDistrict](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPolyclinic] [int] NOT NULL,
	[IDDistrict] [int] NOT NULL,
 CONSTRAINT [PK_PolyclinicDistrict] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SignIn]    Script Date: 14.12.2021 21:39:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SignIn](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[IDEmployee] [int] NOT NULL,
 CONSTRAINT [PK_SignIn] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[District] ON 

INSERT [dbo].[District] ([ID], [TItle], [Count], [IDPolyclinic]) VALUES (1, N'Test', 100, 1)
INSERT [dbo].[District] ([ID], [TItle], [Count], [IDPolyclinic]) VALUES (2, N'Test 2', 2000, 2)
INSERT [dbo].[District] ([ID], [TItle], [Count], [IDPolyclinic]) VALUES (4, N'das', 200, 3)
SET IDENTITY_INSERT [dbo].[District] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (7, N'gfsdg', N'gdfgd', N'gdfgdf', CAST(N'0001-01-01' AS Date), N'thevckit@gmail.com', N'123412', 1)
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (8, N'fsdfs', N'fdsfs', N'fsdfs', CAST(N'0001-01-01' AS Date), N'abdulkhak1m@mail.ru', N'3432', 1)
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (9, N'Привет', N'Првиет', N'Привет', CAST(N'0001-01-01' AS Date), N'thevckit@gmail.com', N'1234', 1)
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (10, N'a', N'a', N'a', CAST(N'0001-01-01' AS Date), N'abdulkhak1m@mail.ru', N'12345', 1)
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (11, N'fs', N'fsd', N'fsd', CAST(N'0001-01-01' AS Date), N'thevckit@gmail.com', N'124', 1)
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (12, N'FA', N'FSD', N'FS', CAST(N'0001-01-01' AS Date), N'abdulkhak1m@mail.ru', N'1243', 1)
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (13, N'fsd', N'fsd', N'fs', CAST(N'0001-01-01' AS Date), N'thevckit@gmail.com', N'12415', 1)
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (14, N'dsf', N'fdsfs', N'fsfs', CAST(N'0001-01-01' AS Date), N'thevckit@gmail.com', N'124145', 1)
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (15, N'gdfgd', N'fsdffd', N'fdf', CAST(N'0001-01-01' AS Date), N'abdulkhak1m@mail.ru', N'432432', 1)
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (16, N'fdsfs', N'fdsfs', N'fsdfs', CAST(N'0001-01-01' AS Date), N'thevckit@gmail.com', N'12452', 1)
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (17, N'Абдулхаким', N'Магомедов', N'Салимсолтанович', CAST(N'0001-01-01' AS Date), N'thevckit@gmail.com', N'14134', 1)
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [MiddleName], [DateOfBirth], [Email], [INN], [IDPolyclinic]) VALUES (18, N'gfsdg', N'gdfgd', N'gdfgdf', CAST(N'0001-01-01' AS Date), N'thevckit@gmail.com', N'123412', 2)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([ID], [FirstName], [LastName], [MiddleName], [Address], [DateOfBirth], [MedicalCardNumber], [CodeDisease], [TitleInsuranceCompany], [TitleDisease], [IDPolyclinic], [IDDistrict]) VALUES (1, N'Test', N'test', N'test', N'test', CAST(N'2001-01-01' AS Date), N'124                 ', N'213       ', N'test', N'test', 1, 1)
INSERT [dbo].[Patient] ([ID], [FirstName], [LastName], [MiddleName], [Address], [DateOfBirth], [MedicalCardNumber], [CodeDisease], [TitleInsuranceCompany], [TitleDisease], [IDPolyclinic], [IDDistrict]) VALUES (2, N'fsd', N'fdsf', N'fdsf', N'fdsfs', CAST(N'1999-01-01' AS Date), N'42134               ', N'41        ', N'fnm,asd', N'fnmd,s', 2, 1)
INSERT [dbo].[Patient] ([ID], [FirstName], [LastName], [MiddleName], [Address], [DateOfBirth], [MedicalCardNumber], [CodeDisease], [TitleInsuranceCompany], [TitleDisease], [IDPolyclinic], [IDDistrict]) VALUES (3, N'fsd', N'fsd', N'fs', N'fsdfs', CAST(N'1999-01-01' AS Date), N'412                 ', N'432       ', N'fsa', N'fds', 1, 1)
INSERT [dbo].[Patient] ([ID], [FirstName], [LastName], [MiddleName], [Address], [DateOfBirth], [MedicalCardNumber], [CodeDisease], [TitleInsuranceCompany], [TitleDisease], [IDPolyclinic], [IDDistrict]) VALUES (4, N'fsdf', N'fdsfs', N'fdsf', N'fdsfsd', CAST(N'0001-01-01' AS Date), N'21312               ', N'41        ', N'rwer', N'rewrw', 1, 1)
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
SET IDENTITY_INSERT [dbo].[Polyclinic] ON 

INSERT [dbo].[Polyclinic] ([ID], [NumberPolyclinic], [AddressPolyclinic], [ReportingYear], [NSWHE], [NSWSSE], [CountSupportStaf]) VALUES (1, N'100       ', N'Teset', CAST(N'2001-01-01' AS Date), 100, 100, 100)
INSERT [dbo].[Polyclinic] ([ID], [NumberPolyclinic], [AddressPolyclinic], [ReportingYear], [NSWHE], [NSWSSE], [CountSupportStaf]) VALUES (2, N'120       ', N'Test', CAST(N'2002-02-02' AS Date), 1000, 90, 10)
INSERT [dbo].[Polyclinic] ([ID], [NumberPolyclinic], [AddressPolyclinic], [ReportingYear], [NSWHE], [NSWSSE], [CountSupportStaf]) VALUES (3, N'1234      ', N'teset', CAST(N'1999-01-01' AS Date), 230, 19, 1)
INSERT [dbo].[Polyclinic] ([ID], [NumberPolyclinic], [AddressPolyclinic], [ReportingYear], [NSWHE], [NSWSSE], [CountSupportStaf]) VALUES (4, N'2         ', N'dsf', CAST(N'1998-01-01' AS Date), 10, 10, 10)
INSERT [dbo].[Polyclinic] ([ID], [NumberPolyclinic], [AddressPolyclinic], [ReportingYear], [NSWHE], [NSWSSE], [CountSupportStaf]) VALUES (5, N'1000      ', N'г.Махачкала', CAST(N'2002-05-20' AS Date), 10, 10, 10)
INSERT [dbo].[Polyclinic] ([ID], [NumberPolyclinic], [AddressPolyclinic], [ReportingYear], [NSWHE], [NSWSSE], [CountSupportStaf]) VALUES (6, N'fdsaf     ', N'fdsfa', CAST(N'0001-01-01' AS Date), 10, 110, 110)
INSERT [dbo].[Polyclinic] ([ID], [NumberPolyclinic], [AddressPolyclinic], [ReportingYear], [NSWHE], [NSWSSE], [CountSupportStaf]) VALUES (7, N'dasf      ', N'fdsf', CAST(N'0001-01-01' AS Date), 120, 210, 120)
INSERT [dbo].[Polyclinic] ([ID], [NumberPolyclinic], [AddressPolyclinic], [ReportingYear], [NSWHE], [NSWSSE], [CountSupportStaf]) VALUES (8, N'fds       ', N'fdsf', CAST(N'0001-01-01' AS Date), 10, 110, 110)
INSERT [dbo].[Polyclinic] ([ID], [NumberPolyclinic], [AddressPolyclinic], [ReportingYear], [NSWHE], [NSWSSE], [CountSupportStaf]) VALUES (9, N'fdsf      ', N'fsdfs', CAST(N'0001-01-01' AS Date), 110, 110, 110)
SET IDENTITY_INSERT [dbo].[Polyclinic] OFF
GO
SET IDENTITY_INSERT [dbo].[PolyclinicDistrict] ON 

INSERT [dbo].[PolyclinicDistrict] ([ID], [IDPolyclinic], [IDDistrict]) VALUES (1, 1, 1)
INSERT [dbo].[PolyclinicDistrict] ([ID], [IDPolyclinic], [IDDistrict]) VALUES (2, 2, 1)
INSERT [dbo].[PolyclinicDistrict] ([ID], [IDPolyclinic], [IDDistrict]) VALUES (4, 4, 4)
INSERT [dbo].[PolyclinicDistrict] ([ID], [IDPolyclinic], [IDDistrict]) VALUES (8, 5, 1)
INSERT [dbo].[PolyclinicDistrict] ([ID], [IDPolyclinic], [IDDistrict]) VALUES (9, 9, 2)
SET IDENTITY_INSERT [dbo].[PolyclinicDistrict] OFF
GO
SET IDENTITY_INSERT [dbo].[SignIn] ON 

INSERT [dbo].[SignIn] ([ID], [Username], [Password], [IDEmployee]) VALUES (20, N'a', N'a', 17)
SET IDENTITY_INSERT [dbo].[SignIn] OFF
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Polyclinic] FOREIGN KEY([IDPolyclinic])
REFERENCES [dbo].[Polyclinic] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Polyclinic]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_District] FOREIGN KEY([IDDistrict])
REFERENCES [dbo].[District] ([ID])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_District]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Polyclinic] FOREIGN KEY([IDPolyclinic])
REFERENCES [dbo].[Polyclinic] ([ID])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Polyclinic]
GO
ALTER TABLE [dbo].[PolyclinicDistrict]  WITH CHECK ADD  CONSTRAINT [FK_PolyclinicDistrict_District] FOREIGN KEY([IDDistrict])
REFERENCES [dbo].[District] ([ID])
GO
ALTER TABLE [dbo].[PolyclinicDistrict] CHECK CONSTRAINT [FK_PolyclinicDistrict_District]
GO
ALTER TABLE [dbo].[PolyclinicDistrict]  WITH CHECK ADD  CONSTRAINT [FK_PolyclinicDistrict_Polyclinic] FOREIGN KEY([IDPolyclinic])
REFERENCES [dbo].[Polyclinic] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PolyclinicDistrict] CHECK CONSTRAINT [FK_PolyclinicDistrict_Polyclinic]
GO
ALTER TABLE [dbo].[SignIn]  WITH CHECK ADD  CONSTRAINT [FK_SignIn_Employee] FOREIGN KEY([IDEmployee])
REFERENCES [dbo].[Employee] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SignIn] CHECK CONSTRAINT [FK_SignIn_Employee]
GO
