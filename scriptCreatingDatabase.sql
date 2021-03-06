USE [MateuszThomasZad4]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 03.12.2017 19:59:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](63) NOT NULL,
	[Surname] [nvarchar](63) NOT NULL,
	[PhoneNumber] [nchar](9) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Documents]    Script Date: 03.12.2017 19:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documents](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TitleNotification] [nvarchar](255) NOT NULL,
	[ClientID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[TypeNotificationID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Items]    Script Date: 03.12.2017 19:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](127) NOT NULL,
	[Brand] [nvarchar](31) NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Passwords]    Script Date: 03.12.2017 19:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passwords](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Passwords] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TypeNotification]    Script Date: 03.12.2017 19:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeNotification](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_TitleNotification] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 03.12.2017 19:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nchar](10) NOT NULL,
	[FirstName] [nvarchar](63) NOT NULL,
	[Surname] [nvarchar](63) NOT NULL,
	[PasswordID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (1, N'Adam', N'Nowak', N'699230962')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (2, N'Patryk', N'Kowalski', N'899302938')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (3, N'Szymon', N'Wiśniewski', N'789203948')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (4, N'Kamil', N'Szymański', N'655354729')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (5, N'Marta', N'Dąbrowska', N'544029384')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (6, N'Karolina', N'Kowalczyk', N'877928512')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (7, N'Patryk', N'Kozłowski', N'599381039')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (8, N'Dominika', N'Woźniak', N'788940281')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (9, N'Filip', N'Wojciechowski', N'845928301')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (10, N'Marcin', N'Kwiatkowski', N'688291029')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (11, N'Tomasz', N'Grabowski', N'892919191')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (12, N'Jan', N'Piotrowski', N'633292929')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (13, N'Wiktor', N'Mazur', N'855192938')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (14, N'Bartek', N'Krawczyk', N'843293921')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (15, N'Kamil', N'Zieliński', N'829231823')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (16, N'Radosław', N'Dąbrowksi', N'721812312')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (17, N'Justyna', N'Kamińska', N'623129312')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (18, N'Anna', N'Wójcik', N'821231319')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (19, N'Adam', N'Kowalski', N'677130298')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (20, N'Alicja', N'Kwiatkowska', N'859324932')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (21, N'Szymon', N'Marciniak', N'789211148')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (22, N'Kamil', N'Marciniak', N'789112248')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (23, N'Kamil', N'Kowalski', N'789332248')
INSERT [dbo].[Clients] ([ID], [FirstName], [Surname], [PhoneNumber]) VALUES (24, N'Marta', N'Trafas', N'544029384')
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Documents] ON 

INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (2, N'Laptop uszkodzony do naprawy', 1, 1, 1, 1, N'Sprzęt do naprawy w ciągu dwóch dni.')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (3, N'Laptop po okresie gwarancji', 2, 1, 2, 2, N'Zdzwonić do klienta po wycenie kosztu naprawy.')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (6, N'Laptop uszkodzony ', 4, 2, 4, 4, N'Sprawdzić dziąłanie touchpada.')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (13, N'Laptop na gwarancji', 22, 2, 9, 15, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (14, N'Laptop na gwarancji 2', 23, 2, 7, 20, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (15, N'Brak sterowników', 17, 2, 15, 7, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (17, N'Laptop na gwarancji 3', 18, 4, 12, 12, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (18, N'Laptop na gwarancji 4', 19, 3, 11, 10, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (20, N'Laptop po okresie gwarancji 2', 20, 2, 2, 7, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (21, N'Laptop uszkodzony do naprawy 2', 21, 1, 8, 8, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (22, N'Laptop uszkodzony 2', 15, 1, 10, 10, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (23, N'Laptop uszkodzony 3', 16, 2, 3, 11, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (24, N'Laptop 1', 11, 2, 6, 14, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (25, N'Laptop na gwarancji 5', 16, 3, 13, 17, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (26, N'Laptop na gwarancji 6', 22, 3, 14, 12, N'brak')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (27, N'Podejrzenie braku sterowników ', 24, 2, 5, 6, N'Sprawdzic sterowniki')
INSERT [dbo].[Documents] ([ID], [TitleNotification], [ClientID], [UserID], [TypeNotificationID], [ItemID], [Description]) VALUES (29, N'Laptop 2', 8, 3, 2, 13, N'brak')
SET IDENTITY_INSERT [dbo].[Documents] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (1, N'LATITUDE E7440', N'Dell')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (2, N'ThinkPad W540', N'Lenovo')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (3, N'ThinkPad W530', N'Lenovo')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (4, N'ThinkPad T540', N'Lenovo')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (6, N'Precission M4800', N'Dell')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (7, N'Latitude E6430', N'Dell')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (8, N'Predator 21X', N'Acer')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (9, N'Inspiron 5567', N'Dell')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (10, N'Precision M6800', N'Dell')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (11, N'ThinkPad T430', N'Lenovo')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (12, N'Latitude E6440', N'Dell')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (13, N'Latitude E6420', N'Dell')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (14, N'Latitude E6430', N'Dell')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (15, N'Precission M6700', N'Dell')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (16, N'Thinkpad T440s', N'Lenovo')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (17, N'Latitude e6530', N'Dell')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (18, N'ThinkPad T410', N'Lenovo')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (19, N'Aspire R7', N'Acer')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (20, N'Aspire 5', N'Acer')
INSERT [dbo].[Items] ([ID], [Name], [Brand]) VALUES (21, N'Spin 1', N'Acer')
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Passwords] ON 

INSERT [dbo].[Passwords] ([ID], [Password]) VALUES (1, N'8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918')
INSERT [dbo].[Passwords] ([ID], [Password]) VALUES (2, N'25F43B1486AD95A1398E3EEB3D83BC4010015FCC9BEDB35B432E00298D5021F7')
INSERT [dbo].[Passwords] ([ID], [Password]) VALUES (3, N'B508F84EC91E4D4AD20A7D99054B2F1E1B3AB311E45EDBD639376EF99B73DF60')
INSERT [dbo].[Passwords] ([ID], [Password]) VALUES (4, N'CAA915FF212F314B9013A3611EDCA986D5FB8D7CB90F3226176B7364C247AE10')
SET IDENTITY_INSERT [dbo].[Passwords] OFF
SET IDENTITY_INSERT [dbo].[TypeNotification] ON 

INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (1, N'Uszkodzone zawiasy.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (2, N'Pęknięta matryca.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (3, N'Zalany.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (4, N'Uszkodzona klawiatura.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (5, N'Uszkodzona kamerka internetowa.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (6, N'Peknięta obudowa.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (7, N'Uszkodzone zasilanie.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (8, N'Nie uruchamia się.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (9, N'Konserwacja systemu chłodzenia.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (10, N'Uszkodzony port USB.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (11, N'Uszkodzony port HDMI.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (12, N'Nie działające podświetlenie klawiatury.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (13, N'Uszkodzony twardy dysk.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (14, N'Uszkodzony napęd DVD.')
INSERT [dbo].[TypeNotification] ([ID], [Type]) VALUES (15, N'Problem z wyswietlaniem obrazu.')
SET IDENTITY_INSERT [dbo].[TypeNotification] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Login], [FirstName], [Surname], [PasswordID]) VALUES (1, N'Maciej    ', N'Maciej', N'Nowak', 2)
INSERT [dbo].[Users] ([ID], [Login], [FirstName], [Surname], [PasswordID]) VALUES (2, N'Mateusz   ', N'Mateusz', N'Kowalski', 1)
INSERT [dbo].[Users] ([ID], [Login], [FirstName], [Surname], [PasswordID]) VALUES (3, N'Bartek    ', N'Bartek', N'Wolny', 3)
INSERT [dbo].[Users] ([ID], [Login], [FirstName], [Surname], [PasswordID]) VALUES (4, N'Kamil     ', N'Kamil', N'Skowroński', 4)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD  CONSTRAINT [FK_Documents_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ID])
GO
ALTER TABLE [dbo].[Documents] CHECK CONSTRAINT [FK_Documents_Clients]
GO
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD  CONSTRAINT [FK_Documents_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ID])
GO
ALTER TABLE [dbo].[Documents] CHECK CONSTRAINT [FK_Documents_Items]
GO
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD  CONSTRAINT [FK_Documents_TypeNotification] FOREIGN KEY([TypeNotificationID])
REFERENCES [dbo].[TypeNotification] ([ID])
GO
ALTER TABLE [dbo].[Documents] CHECK CONSTRAINT [FK_Documents_TypeNotification]
GO
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD  CONSTRAINT [FK_Documents_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Documents] CHECK CONSTRAINT [FK_Documents_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Passwords] FOREIGN KEY([PasswordID])
REFERENCES [dbo].[Passwords] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Passwords]
GO
