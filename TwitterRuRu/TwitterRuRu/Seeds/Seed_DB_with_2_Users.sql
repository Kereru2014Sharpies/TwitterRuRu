USE [master]
GO
/****** Object:  Database [TwitterRuRu]    Script Date: 28/08/2014 11:20:42 a.m. ******/
CREATE DATABASE [TwitterRuRu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TwitterRuRu', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TwitterRuRu.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TwitterRuRu_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TwitterRuRu_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TwitterRuRu] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TwitterRuRu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TwitterRuRu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TwitterRuRu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TwitterRuRu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TwitterRuRu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TwitterRuRu] SET ARITHABORT OFF 
GO
ALTER DATABASE [TwitterRuRu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TwitterRuRu] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TwitterRuRu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TwitterRuRu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TwitterRuRu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TwitterRuRu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TwitterRuRu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TwitterRuRu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TwitterRuRu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TwitterRuRu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TwitterRuRu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TwitterRuRu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TwitterRuRu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TwitterRuRu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TwitterRuRu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TwitterRuRu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TwitterRuRu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TwitterRuRu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TwitterRuRu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TwitterRuRu] SET  MULTI_USER 
GO
ALTER DATABASE [TwitterRuRu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TwitterRuRu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TwitterRuRu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TwitterRuRu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TwitterRuRu]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 28/08/2014 11:20:42 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Accounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[user_login] [nvarchar](50) NOT NULL,
	[password_hash] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Accounts__3214EC0702857D4D] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Accounts_user_login_cb27f490] UNIQUE NONCLUSTERED 
(
	[user_login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [DF__Accounts__passwo__117F9D94]  DEFAULT ('') FOR [password_hash]
GO
USE [master]
GO
ALTER DATABASE [TwitterRuRu] SET  READ_WRITE 
GO
