USE [master]
GO
/****** Object:  Database [HorseComplex]    Script Date: 14.12.2018 15:00:54 ******/
CREATE DATABASE [HorseComplex]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HorseComplex', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HorseComplex.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HorseComplex_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HorseComplex_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HorseComplex] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HorseComplex].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HorseComplex] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HorseComplex] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HorseComplex] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HorseComplex] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HorseComplex] SET ARITHABORT OFF 
GO
ALTER DATABASE [HorseComplex] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HorseComplex] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HorseComplex] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HorseComplex] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HorseComplex] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HorseComplex] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HorseComplex] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HorseComplex] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HorseComplex] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HorseComplex] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HorseComplex] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HorseComplex] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HorseComplex] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HorseComplex] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HorseComplex] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HorseComplex] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HorseComplex] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HorseComplex] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HorseComplex] SET  MULTI_USER 
GO
ALTER DATABASE [HorseComplex] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HorseComplex] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HorseComplex] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HorseComplex] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HorseComplex] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HorseComplex] SET QUERY_STORE = OFF
GO
USE [HorseComplex]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [HorseComplex]
GO
/****** Object:  User [trainer]    Script Date: 14.12.2018 15:00:54 ******/
CREATE USER [trainer] FOR LOGIN [trainer] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [stableman]    Script Date: 14.12.2018 15:00:54 ******/
CREATE USER [stableman] FOR LOGIN [stableman] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [admin]    Script Date: 14.12.2018 15:00:54 ******/
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [trainer]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [trainer]
GO
ALTER ROLE [db_datareader] ADD MEMBER [stableman]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [stableman]
GO
ALTER ROLE [db_owner] ADD MEMBER [admin]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [admin]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [admin]
GO
ALTER ROLE [db_datareader] ADD MEMBER [admin]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [admin]
GO
/****** Object:  Table [dbo].[Владельцы]    Script Date: 14.12.2018 15:00:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Владельцы](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ФИО] [varchar](100) NOT NULL,
	[Телефон] [varchar](11) NULL,
	[Почта] [varchar](50) NULL,
 CONSTRAINT [PK_Владельцы] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Закрепление лошадей]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Закрепление лошадей](
	[id лошади] [int] NOT NULL,
	[id тренера] [int] NOT NULL,
	[Время совместной работы(дни)] [int] NULL,
 CONSTRAINT [PK_Закрепление лошадей] PRIMARY KEY CLUSTERED 
(
	[id лошади] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Закрепление стойл]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Закрепление стойл](
	[id стойла] [int] NOT NULL,
	[id конюха] [int] NOT NULL,
	[Время закрепления(дни)] [int] NULL,
 CONSTRAINT [PK_Закрепление стойл] PRIMARY KEY CLUSTERED 
(
	[id стойла] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Конюхи]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Конюхи](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ФИО] [varchar](50) NOT NULL,
	[Возраст] [int] NULL,
	[Телефон] [varchar](11) NULL,
 CONSTRAINT [PK_Конюхи] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Лошади]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Лошади](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Кличка] [varchar](20) NOT NULL,
	[Пол] [varchar](1) NOT NULL,
	[Возраст] [int] NOT NULL,
	[Звание] [varchar](4) NULL,
	[Разряд] [smallint] NULL,
	[Владелец] [int] NOT NULL,
	[Дата окончания проживания] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Лошади] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Резерв площадок]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Резерв площадок](
	[id площадки] [int] NOT NULL,
	[Состояние] [smallint] NOT NULL,
	[Доступность] [bit] NOT NULL,
	[Дата последнего резервирования] [varchar](10) NULL,
	[Время последнего резервирования] [varchar](5) NULL,
	[Последней занимавший тренер] [int] NULL,
 CONSTRAINT [PK_Резерв площадок] PRIMARY KEY CLUSTERED 
(
	[id площадки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Сломанное снаряжение]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Сломанное снаряжение](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Тип снаряжения] [varchar](50) NOT NULL,
	[Должность доложившего] [varchar](20) NOT NULL,
	[id доложившего] [int] NOT NULL,
	[Дата обнаружения] [varchar](10) NOT NULL,
	[Время обнаружения] [varchar](5) NOT NULL,
	[Место обнаружения] [varchar](20) NOT NULL,
	[id лошади] [int] NULL,
	[Состояние снаряжения] [smallint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Стойла]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Стойла](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Состояние] [smallint] NOT NULL,
	[Проживающая лошадь] [int] NULL,
 CONSTRAINT [PK_Стойла] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Тренеры]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Тренеры](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ФИО] [varchar](50) NOT NULL,
	[Возраст] [int] NOT NULL,
	[Стаж(дни)] [int] NULL,
	[Телефон] [varchar](11) NULL,
 CONSTRAINT [PK_Тренеры] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Тренировки]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Тренировки](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id лошади] [int] NOT NULL,
	[id тренера] [int] NOT NULL,
	[Дата тренировки] [varchar](10) NOT NULL,
	[Длительность тренировки(часы)] [float] NOT NULL,
	[Номер площадки] [int] NOT NULL,
 CONSTRAINT [PK_Тренировки] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Экипировка]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Экипировка](
	[Тип] [varchar](50) NOT NULL,
	[На складе] [int] NOT NULL,
	[Используются] [int] NOT NULL,
	[Необходим ремонт] [int] NOT NULL,
 CONSTRAINT [PK_Экипировка] PRIMARY KEY CLUSTERED 
(
	[Тип] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Закрепление лошадей]  WITH CHECK ADD  CONSTRAINT [FK_Закрепление лошадей_Лошади] FOREIGN KEY([id лошади])
REFERENCES [dbo].[Лошади] ([id])
GO
ALTER TABLE [dbo].[Закрепление лошадей] CHECK CONSTRAINT [FK_Закрепление лошадей_Лошади]
GO
ALTER TABLE [dbo].[Закрепление лошадей]  WITH CHECK ADD  CONSTRAINT [FK_Закрепление лошадей_Тренеры] FOREIGN KEY([id тренера])
REFERENCES [dbo].[Тренеры] ([id])
GO
ALTER TABLE [dbo].[Закрепление лошадей] CHECK CONSTRAINT [FK_Закрепление лошадей_Тренеры]
GO
ALTER TABLE [dbo].[Закрепление стойл]  WITH CHECK ADD  CONSTRAINT [FK_Закрепление стойл_Конюхи] FOREIGN KEY([id конюха])
REFERENCES [dbo].[Конюхи] ([id])
GO
ALTER TABLE [dbo].[Закрепление стойл] CHECK CONSTRAINT [FK_Закрепление стойл_Конюхи]
GO
ALTER TABLE [dbo].[Закрепление стойл]  WITH CHECK ADD  CONSTRAINT [FK_Закрепление стойл_Стойла] FOREIGN KEY([id стойла])
REFERENCES [dbo].[Стойла] ([id])
GO
ALTER TABLE [dbo].[Закрепление стойл] CHECK CONSTRAINT [FK_Закрепление стойл_Стойла]
GO
ALTER TABLE [dbo].[Лошади]  WITH CHECK ADD  CONSTRAINT [FK_Лошади_Владельцы] FOREIGN KEY([Владелец])
REFERENCES [dbo].[Владельцы] ([id])
GO
ALTER TABLE [dbo].[Лошади] CHECK CONSTRAINT [FK_Лошади_Владельцы]
GO
ALTER TABLE [dbo].[Резерв площадок]  WITH CHECK ADD  CONSTRAINT [FK_Резерв площадок_Тренеры] FOREIGN KEY([Последней занимавший тренер])
REFERENCES [dbo].[Тренеры] ([id])
GO
ALTER TABLE [dbo].[Резерв площадок] CHECK CONSTRAINT [FK_Резерв площадок_Тренеры]
GO
ALTER TABLE [dbo].[Сломанное снаряжение]  WITH CHECK ADD  CONSTRAINT [FK_Сломанное снаряжение_Лошади] FOREIGN KEY([id лошади])
REFERENCES [dbo].[Лошади] ([id])
GO
ALTER TABLE [dbo].[Сломанное снаряжение] CHECK CONSTRAINT [FK_Сломанное снаряжение_Лошади]
GO
ALTER TABLE [dbo].[Сломанное снаряжение]  WITH CHECK ADD  CONSTRAINT [FK_Сломанное снаряжение_Экипировка] FOREIGN KEY([Тип снаряжения])
REFERENCES [dbo].[Экипировка] ([Тип])
GO
ALTER TABLE [dbo].[Сломанное снаряжение] CHECK CONSTRAINT [FK_Сломанное снаряжение_Экипировка]
GO
ALTER TABLE [dbo].[Стойла]  WITH CHECK ADD  CONSTRAINT [FK_Стойла_Лошади] FOREIGN KEY([Проживающая лошадь])
REFERENCES [dbo].[Лошади] ([id])
GO
ALTER TABLE [dbo].[Стойла] CHECK CONSTRAINT [FK_Стойла_Лошади]
GO
ALTER TABLE [dbo].[Тренировки]  WITH CHECK ADD  CONSTRAINT [FK_Тренировки_Лошади] FOREIGN KEY([id лошади])
REFERENCES [dbo].[Лошади] ([id])
GO
ALTER TABLE [dbo].[Тренировки] CHECK CONSTRAINT [FK_Тренировки_Лошади]
GO
ALTER TABLE [dbo].[Тренировки]  WITH CHECK ADD  CONSTRAINT [FK_Тренировки_Резерв площадок] FOREIGN KEY([Номер площадки])
REFERENCES [dbo].[Резерв площадок] ([id площадки])
GO
ALTER TABLE [dbo].[Тренировки] CHECK CONSTRAINT [FK_Тренировки_Резерв площадок]
GO
ALTER TABLE [dbo].[Тренировки]  WITH CHECK ADD  CONSTRAINT [FK_Тренировки_Тренеры] FOREIGN KEY([id тренера])
REFERENCES [dbo].[Тренеры] ([id])
GO
ALTER TABLE [dbo].[Тренировки] CHECK CONSTRAINT [FK_Тренировки_Тренеры]
GO
ALTER TABLE [dbo].[Лошади]  WITH CHECK ADD  CONSTRAINT [CK_Лошади] CHECK  (([Пол]='м' OR [Пол]='ж'))
GO
ALTER TABLE [dbo].[Лошади] CHECK CONSTRAINT [CK_Лошади]
GO
ALTER TABLE [dbo].[Резерв площадок]  WITH CHECK ADD  CONSTRAINT [CK_Резерв площадок] CHECK  (([Состояние]=(0) OR [Состояние]=(1) OR [Состояние]=(2)))
GO
ALTER TABLE [dbo].[Резерв площадок] CHECK CONSTRAINT [CK_Резерв площадок]
GO
ALTER TABLE [dbo].[Сломанное снаряжение]  WITH CHECK ADD  CONSTRAINT [CK_Сломанное снаряжение] CHECK  (([Должность доложившего]='Тренер' OR [Должность доложившего]='Конюх' OR [Должность доложившего]='Директор'))
GO
ALTER TABLE [dbo].[Сломанное снаряжение] CHECK CONSTRAINT [CK_Сломанное снаряжение]
GO
ALTER TABLE [dbo].[Сломанное снаряжение]  WITH CHECK ADD  CONSTRAINT [CK_Сломанное снаряжение_1] CHECK  (([Состояние снаряжения]=(0) OR [Состояние снаряжения]=(1) OR [Состояние снаряжения]=(2)))
GO
ALTER TABLE [dbo].[Сломанное снаряжение] CHECK CONSTRAINT [CK_Сломанное снаряжение_1]
GO
ALTER TABLE [dbo].[Стойла]  WITH CHECK ADD  CONSTRAINT [CK_Стойла] CHECK  (([Состояние]=(0) OR [Состояние]=(1) OR [Состояние]=(2)))
GO
ALTER TABLE [dbo].[Стойла] CHECK CONSTRAINT [CK_Стойла]
GO
/****** Object:  StoredProcedure [dbo].[FindAllTrainesForHorses]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FindAllTrainesForHorses]
AS
(SELECT Лошади.Кличка, SUM([Тренировки].[Длительность тренировки(часы)]) FROM [Лошади], [Тренировки] WHERE [Тренировки].[id лошади]=[Лошади].id
GROUP BY Лошади.Кличка)
GO
/****** Object:  StoredProcedure [dbo].[FindBadHorse]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FindBadHorse]
AS
(SELECT Лошади.Кличка, COUNT([Сломанное снаряжение].[id доложившего]) FROM [Лошади], [Сломанное снаряжение] WHERE [Сломанное снаряжение].[id лошади]=[Лошади].id
GROUP BY Лошади.Кличка)
GO
/****** Object:  StoredProcedure [dbo].[FindBadPerson]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FindBadPerson]
AS
(SELECT Тренеры.ФИО, COUNT([Сломанное снаряжение].[id доложившего]) FROM [Тренеры], [Сломанное снаряжение] WHERE [Сломанное снаряжение].[id доложившего]=[Тренеры].id
AND [Сломанное снаряжение].[Должность доложившего]='Тренер' GROUP BY Тренеры.ФИО)
UNION
(SELECT Конюхи.ФИО, COUNT([Сломанное снаряжение].[id доложившего]) FROM [Конюхи], [Сломанное снаряжение] WHERE [Сломанное снаряжение].[id доложившего]=[Конюхи].id
AND [Сломанное снаряжение].[Должность доложившего]='Конюх' GROUP BY [Конюхи].ФИО)
GO
/****** Object:  StoredProcedure [dbo].[FindHorsesWithoutStables]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FindHorsesWithoutStables]
AS
SELECT Лошади.Кличка FROM [Лошади] 
EXCEPT
SELECT Лошади.Кличка FROM [Лошади], [Стойла] WHERE [Стойла].[Проживающая лошадь]=[Лошади].id
GO
/****** Object:  StoredProcedure [dbo].[FindPlainsInUse]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FindPlainsInUse]
AS
SELECT [Резерв площадок].[id площадки] FROM [Резерв площадок] WHERE [Резерв площадок].Доступность=0
GO
/****** Object:  StoredProcedure [dbo].[FindWorker]    Script Date: 14.12.2018 15:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FindWorker] (@Name AS varchar(50))
AS
	SELECT id, ФИО, Возраст, Телефон, 'Конюх' FROM Конюхи WHERE Конюхи.ФИО=@Name
	UNION
	SELECT id, ФИО, Возраст, Телефон, 'Тренер' FROM Тренеры WHERE Тренеры.ФИО=@Name
GO
USE [master]
GO
ALTER DATABASE [HorseComplex] SET  READ_WRITE 
GO
