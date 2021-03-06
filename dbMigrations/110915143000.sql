USE [master]
GO
/****** Object:  Database [bdNomina]    Script Date: 09/11/2015 16:29:20 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'bdNomina')
BEGIN
CREATE DATABASE [bdNomina] ON  PRIMARY 
( NAME = N'bdNomina', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\bdNomina.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'bdNomina_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\bdNomina_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END
GO
ALTER DATABASE [bdNomina] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bdNomina].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bdNomina] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [bdNomina] SET ANSI_NULLS OFF
GO
ALTER DATABASE [bdNomina] SET ANSI_PADDING OFF
GO
ALTER DATABASE [bdNomina] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [bdNomina] SET ARITHABORT OFF
GO
ALTER DATABASE [bdNomina] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [bdNomina] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [bdNomina] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [bdNomina] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [bdNomina] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [bdNomina] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [bdNomina] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [bdNomina] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [bdNomina] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [bdNomina] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [bdNomina] SET  DISABLE_BROKER
GO
ALTER DATABASE [bdNomina] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [bdNomina] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [bdNomina] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [bdNomina] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [bdNomina] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [bdNomina] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [bdNomina] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [bdNomina] SET  READ_WRITE
GO
ALTER DATABASE [bdNomina] SET RECOVERY FULL
GO
ALTER DATABASE [bdNomina] SET  MULTI_USER
GO
ALTER DATABASE [bdNomina] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [bdNomina] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'bdNomina', N'ON'
GO
USE [bdNomina]
GO
/****** Object:  Table [dbo].[caUsers]    Script Date: 09/11/2015 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[caUsers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[caUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[user] [nvarchar](50) NOT NULL,
	[pwd] [nvarchar](max) NOT NULL,
	[fReg] [datetime] NOT NULL,
	[email] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[caUsers]') AND name = N'IX_caUsers_user')
CREATE NONCLUSTERED INDEX [IX_caUsers_user] ON [dbo].[caUsers] 
(
	[user] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[caUsers] ON
INSERT [dbo].[caUsers] ([Id], [user], [pwd], [fReg], [email]) VALUES (1, N'test', N'a94a8fe5ccb19ba61c4c0873d391e987982fbbd3', CAST(0x0000A51000B2BC16 AS DateTime), N'test@test.test')
INSERT [dbo].[caUsers] ([Id], [user], [pwd], [fReg], [email]) VALUES (4, N'other', N'a94a8fe5ccb19ba61c4c0873d391e987982fbbd3', CAST(0x0000A51000B42CC9 AS DateTime), N'other@test.test')
SET IDENTITY_INSERT [dbo].[caUsers] OFF
/****** Object:  Table [dbo].[tblLogs]    Script Date: 09/11/2015 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLogs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Application] [nvarchar](50) NOT NULL,
	[EventDateTime] [datetime] NULL,
	[EventLevel] [nvarchar](100) NULL,
	[MachineName] [nvarchar](100) NULL,
	[EventMessage] [nvarchar](max) NULL,
	[ErrorSource] [nvarchar](100) NULL,
	[ErrorClass] [nvarchar](500) NULL,
	[ErrorMethod] [nvarchar](max) NULL,
	[ErrorMessage] [nvarchar](max) NULL,
	[InnerErrorMessage] [nvarchar](max) NULL,
	[Exception] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblLogs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[paGetUserData]    Script Date: 09/11/2015 16:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[paGetUserData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[paGetUserData]
	@idUser int
AS
BEGIN
	SET NOCOUNT ON;

    SELECT     
		[user], 
		fReg, 
		email
	FROM         
		dbo.caUsers
	WHERE     
		(Id = @idUser)
END
' 
END
GO
/****** Object:  Table [dbo].[tblMessages]    Script Date: 09/11/2015 16:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblMessages]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblMessages](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idUserFrom] [int] NULL,
	[idUserTo] [int] NULL,
	[message] [nvarchar](max) NOT NULL,
	[fIns] [datetime] NOT NULL,
	[msgRead] [bit] NOT NULL,
 CONSTRAINT [PK_tblMessages] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[tblMessages] ON
INSERT [dbo].[tblMessages] ([id], [idUserFrom], [idUserTo], [message], [fIns], [msgRead]) VALUES (2, 4, 1, N'Message Test', CAST(0x0000A51000B6CD9E AS DateTime), 0)
INSERT [dbo].[tblMessages] ([id], [idUserFrom], [idUserTo], [message], [fIns], [msgRead]) VALUES (3, 4, 1, N'Second Message Test', CAST(0x0000A51000F75885 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[tblMessages] OFF
/****** Object:  StoredProcedure [dbo].[paValidUser]    Script Date: 09/11/2015 16:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[paValidUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author		: Xmal
-- Create date	: 11/09/15
-- Description	: Valida usuario
-- =============================================
CREATE PROCEDURE [dbo].[paValidUser]
	@user nvarchar(50),
	@pwd nvarchar(max)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		Id, 
		fReg, 
		email
	FROM         
		dbo.caUsers
	WHERE
		([user] = @user) 
	  AND 
		(pwd = @pwd)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[paNewMessagesByIdUser]    Script Date: 09/11/2015 16:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[paNewMessagesByIdUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[paNewMessagesByIdUser]
	@idUserTo int
AS
BEGIN
	SET NOCOUNT ON;

    SELECT TOP (100) PERCENT 
		dbo.tblMessages.id, 
		dbo.tblMessages.idUserFrom, 
		dbo.caUsers.[user], 
		dbo.caUsers.fReg, 
		dbo.caUsers.email, 
		dbo.tblMessages.[message], 
		CONVERT(VARCHAR(10), dbo.tblMessages.fIns, 103) + '' '' + CONVERT(VARCHAR(8), dbo.tblMessages.fIns, 108) AS fIns
	FROM         
		dbo.caUsers 
	  INNER JOIN
		dbo.tblMessages 
	  ON 
		dbo.caUsers.Id = dbo.tblMessages.idUserFrom
	WHERE     
		(dbo.tblMessages.idUserTo = @idUserTo) 
	  AND 
		(dbo.tblMessages.msgRead = 0)
	ORDER BY 
		dbo.tblMessages.fIns DESC
END
' 
END
GO
/****** Object:  Default [DF__caUsers__fReg__0BC6C43E]    Script Date: 09/11/2015 16:29:21 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__caUsers__fReg__0BC6C43E]') AND parent_object_id = OBJECT_ID(N'[dbo].[caUsers]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__caUsers__fReg__0BC6C43E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[caUsers] ADD  DEFAULT (getdate()) FOR [fReg]
END


End
GO
/****** Object:  Default [DF_tblMessages_fIns]    Script Date: 09/11/2015 16:29:22 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_tblMessages_fIns]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblMessages]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tblMessages_fIns]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblMessages] ADD  CONSTRAINT [DF_tblMessages_fIns]  DEFAULT (getdate()) FOR [fIns]
END


End
GO
/****** Object:  Default [DF_tblMessages_read]    Script Date: 09/11/2015 16:29:22 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_tblMessages_read]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblMessages]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tblMessages_read]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblMessages] ADD  CONSTRAINT [DF_tblMessages_read]  DEFAULT ((0)) FOR [msgRead]
END


End
GO
/****** Object:  ForeignKey [FK_tblMessages_caUsers]    Script Date: 09/11/2015 16:29:22 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblMessages_caUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblMessages]'))
ALTER TABLE [dbo].[tblMessages]  WITH CHECK ADD  CONSTRAINT [FK_tblMessages_caUsers] FOREIGN KEY([idUserTo])
REFERENCES [dbo].[caUsers] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblMessages_caUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblMessages]'))
ALTER TABLE [dbo].[tblMessages] CHECK CONSTRAINT [FK_tblMessages_caUsers]
GO
