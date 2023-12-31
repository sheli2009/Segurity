USE [master]
GO
/****** Object:  Database [WindSegurity]    Script Date: 3/12/2023 19:13:35 ******/
CREATE DATABASE [WindSegurity]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WindSegurity', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\WindSegurity.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WindSegurity_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\WindSegurity_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [WindSegurity] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WindSegurity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WindSegurity] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WindSegurity] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WindSegurity] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WindSegurity] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WindSegurity] SET ARITHABORT OFF 
GO
ALTER DATABASE [WindSegurity] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WindSegurity] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WindSegurity] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WindSegurity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WindSegurity] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WindSegurity] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WindSegurity] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WindSegurity] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WindSegurity] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WindSegurity] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WindSegurity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WindSegurity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WindSegurity] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WindSegurity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WindSegurity] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WindSegurity] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WindSegurity] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WindSegurity] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WindSegurity] SET  MULTI_USER 
GO
ALTER DATABASE [WindSegurity] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WindSegurity] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WindSegurity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WindSegurity] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WindSegurity] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WindSegurity] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [WindSegurity] SET QUERY_STORE = ON
GO
ALTER DATABASE [WindSegurity] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [WindSegurity]
GO
/****** Object:  Table [dbo].[Formularios]    Script Date: 3/12/2023 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formularios](
	[ID_Formularios] [int] IDENTITY(1,1) NOT NULL,
	[Formulario] [varchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioRegistro] [int] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[UsuarioActualiza] [int] NULL,
	[FechaActualizacion] [datetime] NULL,
 CONSTRAINT [PK__Formular__3214EC2769AF4E84] PRIMARY KEY CLUSTERED 
(
	[ID_Formularios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 3/12/2023 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[ID_Permisos] [int] IDENTITY(1,1) NOT NULL,
	[Permiso] [varchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioRegistro] [int] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[UsuarioActualiza] [int] NULL,
	[FechaActualizacion] [datetime] NULL,
 CONSTRAINT [PK__Permisos__3214EC27355AF395] PRIMARY KEY CLUSTERED 
(
	[ID_Permisos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 3/12/2023 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID_Rol] [int] IDENTITY(1,1) NOT NULL,
	[Rol] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioRegistro] [int] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[UsuarioActualiza] [int] NULL,
	[FechaActualizacion] [datetime] NULL,
 CONSTRAINT [PK__Roles__3214EC2779946B50] PRIMARY KEY CLUSTERED 
(
	[ID_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolFormulario]    Script Date: 3/12/2023 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolFormulario](
	[ID_RolFormulario] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NOT NULL,
	[IdFormulario] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioRegistro] [int] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[UsuarioActualiza] [int] NULL,
	[FechaActualizacion] [datetime] NULL,
 CONSTRAINT [PK__RolFormu__3214EC2748E67D36] PRIMARY KEY CLUSTERED 
(
	[ID_RolFormulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolPermiso]    Script Date: 3/12/2023 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolPermiso](
	[ID_RolPermiso] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NOT NULL,
	[IdPermiso] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioRegistro] [int] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[UsuarioActualiza] [int] NULL,
	[FechaActualizacion] [datetime] NULL,
 CONSTRAINT [PK__RolPermi__3214EC27FD3A53EF] PRIMARY KEY CLUSTERED 
(
	[ID_RolPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolUsuario]    Script Date: 3/12/2023 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolUsuario](
	[ID_RolUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioRegistro] [int] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[UsuarioActualiza] [int] NULL,
	[FechaActualizacion] [datetime] NULL,
 CONSTRAINT [PK__RolUsuar__3214EC27C6461BE4] PRIMARY KEY CLUSTERED 
(
	[ID_RolUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 3/12/2023 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Correo] [varchar](200) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varbinary](max) NOT NULL,
	[Contador] [int] NOT NULL,
	[Bloqueado] [bit] NOT NULL,
	[CambiarPassword] [bit] NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioRegistro] [int] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[UsuarioActualiza] [int] NULL,
	[FechaActualizacion] [datetime] NULL,
 CONSTRAINT [PK__Usuarios__3214EC271B489AC0] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Correo], [Login], [Password], [Contador], [Bloqueado], [CambiarPassword], [Activo], [UsuarioRegistro], [FechaRegistro], [UsuarioActualiza], [FechaActualizacion]) VALUES (1, N'Administrador', N'admin@gmail.com', N'admin', 0x8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918, 0, 0, 0, 1, 1, CAST(N'2023-12-01T21:47:12.880' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF__Usuarios__Bloque__49C3F6B7]  DEFAULT ((0)) FOR [Bloqueado]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF__Usuarios__Cambia__4AB81AF0]  DEFAULT ((0)) FOR [CambiarPassword]
GO
ALTER TABLE [dbo].[RolFormulario]  WITH CHECK ADD  CONSTRAINT [FK__RolFormul__IdFor__5812160E] FOREIGN KEY([IdFormulario])
REFERENCES [dbo].[Formularios] ([ID_Formularios])
GO
ALTER TABLE [dbo].[RolFormulario] CHECK CONSTRAINT [FK__RolFormul__IdFor__5812160E]
GO
ALTER TABLE [dbo].[RolFormulario]  WITH CHECK ADD  CONSTRAINT [FK__RolFormul__IdRol__571DF1D5] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Roles] ([ID_Rol])
GO
ALTER TABLE [dbo].[RolFormulario] CHECK CONSTRAINT [FK__RolFormul__IdRol__571DF1D5]
GO
ALTER TABLE [dbo].[RolPermiso]  WITH CHECK ADD  CONSTRAINT [FK__RolPermis__IdPer__5BE2A6F2] FOREIGN KEY([IdPermiso])
REFERENCES [dbo].[Permisos] ([ID_Permisos])
GO
ALTER TABLE [dbo].[RolPermiso] CHECK CONSTRAINT [FK__RolPermis__IdPer__5BE2A6F2]
GO
ALTER TABLE [dbo].[RolPermiso]  WITH CHECK ADD  CONSTRAINT [FK__RolPermis__IdRol__5AEE82B9] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Roles] ([ID_Rol])
GO
ALTER TABLE [dbo].[RolPermiso] CHECK CONSTRAINT [FK__RolPermis__IdRol__5AEE82B9]
GO
ALTER TABLE [dbo].[RolUsuario]  WITH CHECK ADD  CONSTRAINT [FK__RolUsuari__IdRol__534D60F1] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Roles] ([ID_Rol])
GO
ALTER TABLE [dbo].[RolUsuario] CHECK CONSTRAINT [FK__RolUsuari__IdRol__534D60F1]
GO
ALTER TABLE [dbo].[RolUsuario]  WITH CHECK ADD  CONSTRAINT [FK__RolUsuari__IdUsu__5441852A] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([ID_Usuario])
GO
ALTER TABLE [dbo].[RolUsuario] CHECK CONSTRAINT [FK__RolUsuari__IdUsu__5441852A]
GO
USE [master]
GO
ALTER DATABASE [WindSegurity] SET  READ_WRITE 
GO
