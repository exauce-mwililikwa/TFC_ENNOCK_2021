USE [master]
GO
/****** Object:  Database [TFC_ENNOCK]    Script Date: 16/12/2021 12:53:37 ******/
CREATE DATABASE [TFC_ENNOCK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TFC_ENNOCK', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SA\MSSQL\DATA\TFC_ENNOCK.mdf' , SIZE = 10432KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TFC_ENNOCK_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SA\MSSQL\DATA\TFC_ENNOCK_log.ldf' , SIZE = 8512KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TFC_ENNOCK] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TFC_ENNOCK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TFC_ENNOCK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET ARITHABORT OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TFC_ENNOCK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TFC_ENNOCK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TFC_ENNOCK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TFC_ENNOCK] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET RECOVERY FULL 
GO
ALTER DATABASE [TFC_ENNOCK] SET  MULTI_USER 
GO
ALTER DATABASE [TFC_ENNOCK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TFC_ENNOCK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TFC_ENNOCK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TFC_ENNOCK] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TFC_ENNOCK] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TFC_ENNOCK', N'ON'
GO
USE [TFC_ENNOCK]
GO
/****** Object:  Table [dbo].[AUDITOIRE]    Script Date: 16/12/2021 12:53:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AUDITOIRE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PROMOTION] [int] NULL,
	[OPTIONS] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CARTE]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARTE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DATETIME] [datetime] NULL DEFAULT (getdate()),
	[IMAGE] [image] NULL,
	[INSCRIPTION] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ETUDIANT]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ETUDIANT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOM] [varchar](15) NULL,
	[POSTNOM] [varchar](15) NULL,
	[PRENOM] [varchar](15) NULL,
	[SEXE] [char](1) NULL,
	[LIEU] [varchar](20) NULL,
	[DATE] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INSCRIPTION]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INSCRIPTION](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MATRICULE] [varchar](10) NULL,
	[DATETIME] [datetime] NULL DEFAULT (getdate()),
	[ETUDIANT] [int] NULL,
	[AUDITOIRE] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MOTIF]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOTIF](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AUDITOIRE] [int] NULL,
	[DESIGNATION] [varchar](20) NULL,
	[MONTANT] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OPTIONS]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OPTIONS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DESIGNATION] [varchar](19) NULL,
	[ABREVIATION] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PAIEMENT]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAIEMENT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MONTANT] [int] NULL,
	[INSCRIPTION] [int] NULL,
	[DATETIME] [datetime] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PARAMETRE]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PARAMETRE](
	[POURCENTAGE] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PROMOTION]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROMOTION](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DESIGNATION] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RECOUVREMENT]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RECOUVREMENT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ETUDIANT] [int] NULL,
	[DATE] [date] NULL,
	[DECISION] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRANCHE]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRANCHE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PAIEMENT] [int] NULL,
	[DESIGNATION] [varchar](25) NULL,
	[MONTANT] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[LISTE_ETUDIANT]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[LISTE_ETUDIANT] AS(
SELECT INSCRIPTION.MATRICULE,NOM,POSTNOM,PRENOM,SEXE,PROMOTION.DESIGNATION,OPTIONS.ABREVIATION,OPTIONS.DESIGNATION AS COMPLET,CARTE.IMAGE FROM INSCRIPTION INNER JOIN ETUDIANT ON ETUDIANT.ID=INSCRIPTION.ETUDIANT INNER JOIN AUDITOIRE
ON AUDITOIRE.ID=INSCRIPTION.AUDITOIRE INNER JOIN PROMOTION on 
PROMOTION.ID=AUDITOIRE.PROMOTION inner join OPTIONS on OPTIONS.ID=AUDITOIRE.OPTIONS INNER JOIN CARTE ON CARTE.INSCRIPTION=INSCRIPTION.ID)

GO
/****** Object:  View [dbo].[RECU]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[RECU] AS (
SELECT PAIEMENT.ID, FORMAT(PAIEMENT.ID,'0000') AS RECU,INSCRIPTION.MATRICULE,NOM,POSTNOM,PRENOM,SEXE,SUBSTRING( CONVERT(VARCHAR(10),CONVERT(TIME,PAIEMENT.DATETIME)),1,8) AS HEURE,PAIEMENT.DATETIME,MONTANT FROM PAIEMENT INNER JOIN INSCRIPTION ON INSCRIPTION.ID=PAIEMENT.INSCRIPTION
INNER JOIN ETUDIANT ON ETUDIANT.ID=INSCRIPTION.ETUDIANT
)
GO
/****** Object:  View [dbo].[VOIR_AUDITOIRE]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VOIR_AUDITOIRE] AS(
SELECT AUDITOIRE.ID,OPTIONS.ABREVIATION,PROMOTION.DESIGNATION FROM AUDITOIRE INNER JOIN PROMOTION ON PROMOTION.ID=AUDITOIRE.PROMOTION INNER JOIN OPTIONS ON OPTIONS.ID=AUDITOIRE.OPTIONS
)

GO
/****** Object:  StoredProcedure [dbo].[AJOUTEAUDITOIRE]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AJOUTEAUDITOIRE](
@PROMOTION VARCHAR(3),
@OPTION VARCHAR(3)
)
AS
BEGIN
DECLARE @IDPROMOTION INT;
SELECT @IDPROMOTION=PROMOTION.ID FROM PROMOTION WHERE PROMOTION.DESIGNATION=@PROMOTION
DECLARE @IDOPTION INT;
SELECT @IDOPTION=ID FROM OPTIONS WHERE ABREVIATION=@OPTION
INSERT INTO AUDITOIRE(OPTIONS,PROMOTION)VALUES(@IDOPTION,@IDPROMOTION)
END
GO
/****** Object:  StoredProcedure [dbo].[AJOUTEETUDIANT]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AJOUTEETUDIANT](
@NOM VARCHAR(15),
@POSTNOM VARCHAR(15),
@PRENOM VARCHAR(15),
@SEXE CHAR,
@LIEU VARCHAR(20),
@DATE VARCHAR(20),
@IMAGE IMAGE,
@PROMOTION VARCHAR(6),
@OPTION VARCHAR(8)
)
AS
BEGIN
DECLARE @MATRICULE VARCHAR(10);
DECLARE @IDAUDITOIRE INT;
SELECT @IDAUDITOIRE=AUDITOIRE.ID FROM AUDITOIRE INNER JOIN PROMOTION ON PROMOTION.ID=AUDITOIRE.PROMOTION INNER JOIN OPTIONS ON OPTIONS.ID=AUDITOIRE.OPTIONS WHERE PROMOTION.DESIGNATION=@PROMOTION AND OPTIONS.ABREVIATION=@OPTION
SELECT @MATRICULE= CONCAT(SUBSTRING(CONVERT(varchar(13),YEAR(GETDATE())),3,2),@OPTION,(SELECT FORMAT(ISNULL(MAX(ID),0)+1,'0000') FROM INSCRIPTION))
INSERT INTO ETUDIANT(NOM,POSTNOM,PRENOM,SEXE,LIEU,DATE)VALUES(@NOM,@POSTNOM,@PRENOM,@SEXE,@LIEU,@DATE)
DECLARE @IDETUDIANT INT;
SELECT @IDETUDIANT=MAX(ID) FROM ETUDIANT
INSERT INTO INSCRIPTION(MATRICULE,AUDITOIRE,ETUDIANT)VALUES(@MATRICULE,@IDAUDITOIRE,@IDETUDIANT)
DECLARE @IDINSRIPTION INT;
SELECT @IDINSRIPTION=MAX(ID) FROM INSCRIPTION
INSERT INTO CARTE(IMAGE,INSCRIPTION)VALUES(@IMAGE,@IDINSRIPTION)
END
GO
/****** Object:  StoredProcedure [dbo].[AJOUTEOPTION]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AJOUTEOPTION] (@DESIGNATION VARCHAR(19),@ABREVIATION VARCHAR(3))
AS
BEGIN
INSERT INTO [OPTIONS](DESIGNATION,ABREVIATION)VALUES(@DESIGNATION,@ABREVIATION)
END
GO
/****** Object:  StoredProcedure [dbo].[AJOUTEPAIEMENT]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AJOUTEPAIEMENT](
@MATRICULE VARCHAR(10),
@MONTANT INT
)
AS
BEGIN
	DECLARE @IDINSCRIPTION INT;
	SELECT @IDINSCRIPTION=INSCRIPTION.ID FROM INSCRIPTION WHERE INSCRIPTION.MATRICULE=@MATRICULE
	INSERT INTO PAIEMENT(INSCRIPTION,MONTANT)VALUES(@IDINSCRIPTION,@MONTANT)
END
GO
/****** Object:  StoredProcedure [dbo].[AJOUTEPROMOTION]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AJOUTEPROMOTION](@DESIGNATION VARCHAR(3))

AS
BEGIN
INSERT INTO PROMOTION(DESIGNATION)VALUES(@DESIGNATION)
END

GO
/****** Object:  StoredProcedure [dbo].[AJOUTERMOTIF]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AJOUTERMOTIF](
@PROMOTION VARCHAR(5),
@OPTION VARCHAR(5),
@DESIGNATION VARCHAR(20),
@MONTANT INT
)
AS
BEGIN
DECLARE @AUDITOIRE INT;
SELECT @AUDITOIRE=ID FROM VOIR_AUDITOIRE WHERE ABREVIATION=@OPTION AND DESIGNATION=@PROMOTION
INSERT INTO MOTIF (AUDITOIRE,DESIGNATION,MONTANT)VALUES(@AUDITOIRE,@DESIGNATION,@MONTANT)
END
GO
/****** Object:  StoredProcedure [dbo].[PARAMETRER]    Script Date: 16/12/2021 12:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PARAMETRER](
@POURCENTAGE INT 
)
AS
BEGIN
UPDATE PARAMETRE SET POURCENTAGE=@POURCENTAGE
END
GO
USE [master]
GO
ALTER DATABASE [TFC_ENNOCK] SET  READ_WRITE 
GO
