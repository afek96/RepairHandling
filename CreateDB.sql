USE [master]
GO
/****** Object:  Database [RepairHandling]    Script Date: 24.03.2019 19:49:37 ******/
CREATE DATABASE [RepairHandling]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RepairHandling', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RepairHandling.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RepairHandling_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RepairHandling_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RepairHandling] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RepairHandling].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RepairHandling] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RepairHandling] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RepairHandling] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RepairHandling] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RepairHandling] SET ARITHABORT OFF 
GO
ALTER DATABASE [RepairHandling] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RepairHandling] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RepairHandling] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RepairHandling] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RepairHandling] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RepairHandling] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RepairHandling] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RepairHandling] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RepairHandling] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RepairHandling] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RepairHandling] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RepairHandling] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RepairHandling] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RepairHandling] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RepairHandling] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RepairHandling] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RepairHandling] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RepairHandling] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RepairHandling] SET  MULTI_USER 
GO
ALTER DATABASE [RepairHandling] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RepairHandling] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RepairHandling] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RepairHandling] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RepairHandling] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RepairHandling] SET QUERY_STORE = OFF
GO
USE [RepairHandling]
GO
/****** Object:  Table [dbo].[Activity]    Script Date: 24.03.2019 19:49:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity](
	[IdActivity] [int] IDENTITY(1,1) NOT NULL,
	[SequenceNo] [int] NULL,
	[Description] [nvarchar](1024) NOT NULL,
	[Result] [nvarchar](1024) NULL,
	[Status] [nvarchar](3) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NULL,
	[Type] [nvarchar](8) NOT NULL,
	[IdRequest] [int] NOT NULL,
	[IdPersonel] [int] NULL,
 CONSTRAINT [PK_Activity] PRIMARY KEY CLUSTERED 
(
	[IdActivity] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActivityType]    Script Date: 24.03.2019 19:49:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityType](
	[ActivityType] [nvarchar](8) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_ActivityType] PRIMARY KEY CLUSTERED 
(
	[ActivityType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 24.03.2019 19:49:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[IdAddress] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](50) NOT NULL,
	[HouseNumber] [nvarchar](8) NOT NULL,
	[PostalCode] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[IdAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 24.03.2019 19:49:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](15) NOT NULL,
	[IdAddress] [int] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Object]    Script Date: 24.03.2019 19:49:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Object](
	[IdObject] [int] IDENTITY(1,1) NOT NULL,
	[IdClient] [int] NOT NULL,
	[Type] [nvarchar](8) NOT NULL,
	[Name] [nvarchar](256) NULL,
 CONSTRAINT [PK_Object] PRIMARY KEY CLUSTERED 
(
	[IdObject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ObjectType]    Script Date: 24.03.2019 19:49:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjectType](
	[ObjectType] [nvarchar](8) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_ObjectTyoe] PRIMARY KEY CLUSTERED 
(
	[ObjectType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 24.03.2019 19:49:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[IdPersonel] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](64) NOT NULL,
	[Role] [nvarchar](3) NOT NULL,
	[ExpiryDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[IdPersonel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_UserName] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 24.03.2019 19:49:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[IdRequest] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](1024) NOT NULL,
	[Result] [nvarchar](1024) NULL,
	[Status] [nvarchar](3) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NULL,
	[IdObject] [int] NOT NULL,
	[IdPersonel] [int] NOT NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[IdRequest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 24.03.2019 19:49:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleType] [nvarchar](3) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_ActivityType] FOREIGN KEY([Type])
REFERENCES [dbo].[ActivityType] ([ActivityType])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_ActivityType]
GO
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Personel] FOREIGN KEY([IdPersonel])
REFERENCES [dbo].[Personel] ([IdPersonel])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_Personel]
GO
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Request] FOREIGN KEY([IdRequest])
REFERENCES [dbo].[Request] ([IdRequest])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_Request]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Address] FOREIGN KEY([IdAddress])
REFERENCES [dbo].[Address] ([IdAddress])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Address]
GO
ALTER TABLE [dbo].[Object]  WITH CHECK ADD  CONSTRAINT [FK_Object_Client] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdClient])
GO
ALTER TABLE [dbo].[Object] CHECK CONSTRAINT [FK_Object_Client]
GO
ALTER TABLE [dbo].[Object]  WITH CHECK ADD  CONSTRAINT [FK_Object_ObjectType] FOREIGN KEY([Type])
REFERENCES [dbo].[ObjectType] ([ObjectType])
GO
ALTER TABLE [dbo].[Object] CHECK CONSTRAINT [FK_Object_ObjectType]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Role] FOREIGN KEY([Role])
REFERENCES [dbo].[Role] ([RoleType])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Role]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Object] FOREIGN KEY([IdObject])
REFERENCES [dbo].[Object] ([IdObject])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Object]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Personel] FOREIGN KEY([IdPersonel])
REFERENCES [dbo].[Personel] ([IdPersonel])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Personel]
GO
USE [master]
GO
ALTER DATABASE [RepairHandling] SET  READ_WRITE 
GO
