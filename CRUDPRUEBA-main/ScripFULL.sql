USE [master]
GO
/****** Object:  Database [CRUDVENTA]    Script Date: 12/13/2022 01:40:53 ******/
CREATE DATABASE [CRUDVENTA] ON  PRIMARY 
( NAME = N'CRUDVENTA', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CRUDVENTA.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CRUDVENTA_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CRUDVENTA_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CRUDVENTA] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CRUDVENTA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CRUDVENTA] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [CRUDVENTA] SET ANSI_NULLS OFF
GO
ALTER DATABASE [CRUDVENTA] SET ANSI_PADDING OFF
GO
ALTER DATABASE [CRUDVENTA] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [CRUDVENTA] SET ARITHABORT OFF
GO
ALTER DATABASE [CRUDVENTA] SET AUTO_CLOSE ON
GO
ALTER DATABASE [CRUDVENTA] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [CRUDVENTA] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [CRUDVENTA] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [CRUDVENTA] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [CRUDVENTA] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [CRUDVENTA] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [CRUDVENTA] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [CRUDVENTA] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [CRUDVENTA] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [CRUDVENTA] SET  ENABLE_BROKER
GO
ALTER DATABASE [CRUDVENTA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [CRUDVENTA] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [CRUDVENTA] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [CRUDVENTA] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [CRUDVENTA] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [CRUDVENTA] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [CRUDVENTA] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [CRUDVENTA] SET  READ_WRITE
GO
ALTER DATABASE [CRUDVENTA] SET RECOVERY SIMPLE
GO
ALTER DATABASE [CRUDVENTA] SET  MULTI_USER
GO
ALTER DATABASE [CRUDVENTA] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CRUDVENTA] SET DB_CHAINING OFF
GO
USE [CRUDVENTA]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 12/13/2022 01:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[iduser] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](15) NULL,
	[contraseña] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[iduser] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON
INSERT [dbo].[usuario] ([iduser], [usuario], [contraseña]) VALUES (1, N'Thejonathan1994', N'bosina1994')
SET IDENTITY_INSERT [dbo].[usuario] OFF
/****** Object:  Table [dbo].[cliente]    Script Date: 12/13/2022 01:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[iduser] [int] NULL,
	[cedula] [varchar](14) NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[ocupacion] [varchar](50) NULL,
	[sexo] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[cliente] ON
INSERT [dbo].[cliente] ([idcliente], [iduser], [cedula], [nombre], [apellido], [ocupacion], [sexo]) VALUES (2, NULL, N'543-786564-2', N'Keyler', N'Morel', N'Est-Sistema', N'M')
INSERT [dbo].[cliente] ([idcliente], [iduser], [cedula], [nombre], [apellido], [ocupacion], [sexo]) VALUES (20, NULL, N'678', N'u', N'k', N'k', N'M')
SET IDENTITY_INSERT [dbo].[cliente] OFF
/****** Object:  Table [dbo].[articulo]    Script Date: 12/13/2022 01:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[articulo](
	[idarticulo] [int] IDENTITY(1,1) NOT NULL,
	[iduser] [int] NULL,
	[nombre] [varchar](50) NULL,
	[tipo] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[precio] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[idarticulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[factura]    Script Date: 12/13/2022 01:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[factura](
	[idfactura] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NULL,
	[idarticulo] [int] NULL,
	[total] [money] NULL,
	[descripcion] [varchar](100) NULL,
	[subtotal] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[idfactura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pedidos]    Script Date: 12/13/2022 01:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedidos](
	[idpedidos] [int] IDENTITY(1,1) NOT NULL,
	[iduser] [int] NULL,
	[idcliente] [int] NULL,
	[idarticulo] [int] NULL,
	[idempleado] [int] NULL,
 CONSTRAINT [PK_pedidos] PRIMARY KEY CLUSTERED 
(
	[idpedidos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 12/13/2022 01:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleado](
	[idempleado] [int] IDENTITY(1,1) NOT NULL,
	[iduser] [int] NULL,
	[cedula] [varchar](14) NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[cargo] [varchar](50) NULL,
	[tiposamgre] [char](3) NULL,
	[sexo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idempleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[empleado] ON
INSERT [dbo].[empleado] ([idempleado], [iduser], [cedula], [nombre], [apellido], [cargo], [tiposamgre], [sexo]) VALUES (1, NULL, N'402-25678-2', N'Jonathan', N'de la cruz ', N'fron-end', NULL, N'Masculino')
INSERT [dbo].[empleado] ([idempleado], [iduser], [cedula], [nombre], [apellido], [cargo], [tiposamgre], [sexo]) VALUES (3, NULL, N'401-987654-9', N'Meteo', N'Mota', N'Soporte', NULL, N'Masculino')
SET IDENTITY_INSERT [dbo].[empleado] OFF
/****** Object:  ForeignKey [FK_cliente_usuario]    Script Date: 12/13/2022 01:40:55 ******/
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK_cliente_usuario] FOREIGN KEY([iduser])
REFERENCES [dbo].[usuario] ([iduser])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_cliente_usuario]
GO
/****** Object:  ForeignKey [FK_articulo_usuario]    Script Date: 12/13/2022 01:40:55 ******/
ALTER TABLE [dbo].[articulo]  WITH CHECK ADD  CONSTRAINT [FK_articulo_usuario] FOREIGN KEY([iduser])
REFERENCES [dbo].[usuario] ([iduser])
GO
ALTER TABLE [dbo].[articulo] CHECK CONSTRAINT [FK_articulo_usuario]
GO
/****** Object:  ForeignKey [FK_factura_articulo]    Script Date: 12/13/2022 01:40:55 ******/
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_articulo] FOREIGN KEY([idarticulo])
REFERENCES [dbo].[articulo] ([idarticulo])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_articulo]
GO
/****** Object:  ForeignKey [FK_factura_cliente]    Script Date: 12/13/2022 01:40:55 ******/
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[cliente] ([idcliente])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_cliente]
GO
/****** Object:  ForeignKey [FK_pedidos_factura]    Script Date: 12/13/2022 01:40:55 ******/
ALTER TABLE [dbo].[pedidos]  WITH CHECK ADD  CONSTRAINT [FK_pedidos_factura] FOREIGN KEY([iduser])
REFERENCES [dbo].[factura] ([idfactura])
GO
ALTER TABLE [dbo].[pedidos] CHECK CONSTRAINT [FK_pedidos_factura]
GO
/****** Object:  ForeignKey [FK_pedidos_usuario]    Script Date: 12/13/2022 01:40:55 ******/
ALTER TABLE [dbo].[pedidos]  WITH CHECK ADD  CONSTRAINT [FK_pedidos_usuario] FOREIGN KEY([iduser])
REFERENCES [dbo].[usuario] ([iduser])
GO
ALTER TABLE [dbo].[pedidos] CHECK CONSTRAINT [FK_pedidos_usuario]
GO
/****** Object:  ForeignKey [FK_empleado_factura]    Script Date: 12/13/2022 01:40:55 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_empleado_factura] FOREIGN KEY([iduser])
REFERENCES [dbo].[factura] ([idfactura])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_factura]
GO
/****** Object:  ForeignKey [FK_empleado_usuario]    Script Date: 12/13/2022 01:40:55 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_empleado_usuario] FOREIGN KEY([iduser])
REFERENCES [dbo].[usuario] ([iduser])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_usuario]
GO
