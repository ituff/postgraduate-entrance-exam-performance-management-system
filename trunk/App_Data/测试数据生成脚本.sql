USE [master]
GO
/****** Object:  Database [grade2013]    Script Date: 2013/2/22 13:40:16 ******/
CREATE DATABASE [grade2013] ON  PRIMARY 
( NAME = N'grade2013', FILENAME = N'E:\DATABASE\MSSQL\grade2013.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'grade2013_log', FILENAME = N'E:\DATABASE\MSSQL\grade2013_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'grade2013', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [grade2013].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [grade2013] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [grade2013] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [grade2013] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [grade2013] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [grade2013] SET ARITHABORT OFF 
GO
ALTER DATABASE [grade2013] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [grade2013] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [grade2013] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [grade2013] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [grade2013] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [grade2013] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [grade2013] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [grade2013] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [grade2013] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [grade2013] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [grade2013] SET  DISABLE_BROKER 
GO
ALTER DATABASE [grade2013] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [grade2013] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [grade2013] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [grade2013] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [grade2013] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [grade2013] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [grade2013] SET RECOVERY FULL 
GO
ALTER DATABASE [grade2013] SET  MULTI_USER 
GO
ALTER DATABASE [grade2013] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [grade2013] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'grade2013', N'ON'
GO
USE [grade2013]
GO
/****** Object:  Table [dbo].[grade2013]    Script Date: 2013/2/22 13:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grade2013](
	[studentId] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NULL,
	[idCode] [nvarchar](50) NULL,
	[politicalTheoryMark] [nvarchar](50) NULL,
	[foreignLanguageMark] [nvarchar](50) NULL,
	[specializedCourseOneMark] [nvarchar](50) NULL,
	[specializedCourseTwoMark] [nvarchar](50) NULL,
	[sumMark] [nvarchar](50) NULL,
	[others] [nvarchar](200) NULL,
 CONSTRAINT [PK_grade2013] PRIMARY KEY CLUSTERED 
(
	[studentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[grade2013] ([studentId], [name], [idCode], [politicalTheoryMark], [foreignLanguageMark], [specializedCourseOneMark], [specializedCourseTwoMark], [sumMark], [others]) VALUES (N'102912210100001', N'程诗仪', N'320303199002210062', N'67', N'43', N'101', N'70', N'281', NULL)
INSERT [dbo].[grade2013] ([studentId], [name], [idCode], [politicalTheoryMark], [foreignLanguageMark], [specializedCourseOneMark], [specializedCourseTwoMark], [sumMark], [others]) VALUES (N'102912210100002', N'樊健', N'321183198909290619', N'42', N'22', N'59', N'10', N'133', NULL)
INSERT [dbo].[grade2013] ([studentId], [name], [idCode], [politicalTheoryMark], [foreignLanguageMark], [specializedCourseOneMark], [specializedCourseTwoMark], [sumMark], [others]) VALUES (N'102912210100003', N'顾松', N'320581199005131714', N'-1', N'-1', N'-1', N'-1', N'0', NULL)
INSERT [dbo].[grade2013] ([studentId], [name], [idCode], [politicalTheoryMark], [foreignLanguageMark], [specializedCourseOneMark], [specializedCourseTwoMark], [sumMark], [others]) VALUES (N'102912210100004', N'胡晨飞', N'41072519870712089X', N'49', N'28', N'117', N'98', N'292', NULL)
INSERT [dbo].[grade2013] ([studentId], [name], [idCode], [politicalTheoryMark], [foreignLanguageMark], [specializedCourseOneMark], [specializedCourseTwoMark], [sumMark], [others]) VALUES (N'102912210100005', N'黄小建', N'330501198305036722', N'-1', N'-1', N'-1', N'-1', N'0', NULL)
INSERT [dbo].[grade2013] ([studentId], [name], [idCode], [politicalTheoryMark], [foreignLanguageMark], [specializedCourseOneMark], [specializedCourseTwoMark], [sumMark], [others]) VALUES (N'102912210100006', N'李文惠', N'321182199002222923', N'72', N'53', N'102', N'106', N'333', NULL)
USE [master]
GO
ALTER DATABASE [grade2013] SET  READ_WRITE 
GO
