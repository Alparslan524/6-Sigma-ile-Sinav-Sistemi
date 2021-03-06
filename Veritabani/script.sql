USE [master]
GO
/****** Object:  Database [veriYapilari]    Script Date: 14.05.2022 16:00:58 ******/
CREATE DATABASE [veriYapilari]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'veriYapilari', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\veriYapilari.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'veriYapilari_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\veriYapilari_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [veriYapilari] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [veriYapilari].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [veriYapilari] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [veriYapilari] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [veriYapilari] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [veriYapilari] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [veriYapilari] SET ARITHABORT OFF 
GO
ALTER DATABASE [veriYapilari] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [veriYapilari] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [veriYapilari] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [veriYapilari] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [veriYapilari] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [veriYapilari] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [veriYapilari] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [veriYapilari] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [veriYapilari] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [veriYapilari] SET  DISABLE_BROKER 
GO
ALTER DATABASE [veriYapilari] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [veriYapilari] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [veriYapilari] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [veriYapilari] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [veriYapilari] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [veriYapilari] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [veriYapilari] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [veriYapilari] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [veriYapilari] SET  MULTI_USER 
GO
ALTER DATABASE [veriYapilari] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [veriYapilari] SET DB_CHAINING OFF 
GO
ALTER DATABASE [veriYapilari] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [veriYapilari] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [veriYapilari] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [veriYapilari] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [veriYapilari] SET QUERY_STORE = OFF
GO
USE [veriYapilari]
GO
/****** Object:  Table [dbo].[tblKonu]    Script Date: 14.05.2022 16:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKonu](
	[KonuID] [int] NOT NULL,
	[konuAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblKonu] PRIMARY KEY CLUSTERED 
(
	[KonuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKullanici]    Script Date: 14.05.2022 16:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKullanici](
	[kullaniciID] [int] NOT NULL,
	[kullaniciAdi] [nvarchar](25) NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[KullaniciTipiID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKullaniciTipi]    Script Date: 14.05.2022 16:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKullaniciTipi](
	[KullaniciTipiID] [int] NOT NULL,
	[kullaniciTipiAdi] [nchar](10) NULL,
 CONSTRAINT [PK_tblKullaniciTipi] PRIMARY KEY CLUSTERED 
(
	[KullaniciTipiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSorular]    Script Date: 14.05.2022 16:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSorular](
	[SoruID] [int] NOT NULL,
	[UniteID] [int] NOT NULL,
	[KonuID] [int] NOT NULL,
 CONSTRAINT [PK_tblSorular] PRIMARY KEY CLUSTERED 
(
	[SoruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUnite]    Script Date: 14.05.2022 16:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUnite](
	[UniteID] [int] NOT NULL,
	[UniteAdi] [nchar](10) NULL,
 CONSTRAINT [PK_tblUnite] PRIMARY KEY CLUSTERED 
(
	[UniteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblKullanici]  WITH CHECK ADD  CONSTRAINT [FK_tblKullanici_tblKullaniciTipi] FOREIGN KEY([KullaniciTipiID])
REFERENCES [dbo].[tblKullaniciTipi] ([KullaniciTipiID])
GO
ALTER TABLE [dbo].[tblKullanici] CHECK CONSTRAINT [FK_tblKullanici_tblKullaniciTipi]
GO
ALTER TABLE [dbo].[tblSorular]  WITH CHECK ADD  CONSTRAINT [FK_tblSorular_tblKonu] FOREIGN KEY([KonuID])
REFERENCES [dbo].[tblKonu] ([KonuID])
GO
ALTER TABLE [dbo].[tblSorular] CHECK CONSTRAINT [FK_tblSorular_tblKonu]
GO
ALTER TABLE [dbo].[tblSorular]  WITH CHECK ADD  CONSTRAINT [FK_tblSorular_tblUnite] FOREIGN KEY([UniteID])
REFERENCES [dbo].[tblUnite] ([UniteID])
GO
ALTER TABLE [dbo].[tblSorular] CHECK CONSTRAINT [FK_tblSorular_tblUnite]
GO
USE [master]
GO
ALTER DATABASE [veriYapilari] SET  READ_WRITE 
GO
