﻿--
-- Script was generated by Devart dbForge Studio 2022 for SQL Server, Version 6.4.7.0
-- Product home page: http://www.devart.com/dbforge/sql/studio
-- Script date 10/27/2023 3:51:00 PM
-- Server version: 16.00.1000
--


SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

USE QuanLySinhVien
GO

IF DB_NAME() <> N'QuanLySinhVien' SET NOEXEC ON
GO

--
-- Create table [dbo].[SinhVien]
--
PRINT (N'Create table [dbo].[SinhVien]')
GO
CREATE TABLE dbo.SinhVien (
  MaSo int NOT NULL,
  HoTen nvarchar(50) NULL DEFAULT ('NULL'),
  NgaySinh datetime NULL DEFAULT ('NULL'),
  GioiTinh bit NULL DEFAULT ('NULL'),
  DienThoai int NULL DEFAULT ('NULL'),
  MaKhoa nchar(6) NULL DEFAULT ('NULL'),
  PRIMARY KEY CLUSTERED (MaSo)
)
ON [PRIMARY]
GO

--
-- Create table [dbo].[Mon]
--
PRINT (N'Create table [dbo].[Mon]')
GO
CREATE TABLE dbo.Mon (
  MaH nchar(6) NOT NULL DEFAULT (NULL),
  TenMH nchar(50) NULL DEFAULT (NULL),
  SoTiet int NULL DEFAULT (NULL),
  PRIMARY KEY CLUSTERED (MaH)
)
ON [PRIMARY]
GO

--
-- Create table [dbo].[Khoa]
--
PRINT (N'Create table [dbo].[Khoa]')
GO
CREATE TABLE dbo.Khoa (
  MaKhoa nchar(6) NOT NULL DEFAULT (NULL),
  TenKhoa nchar(30) NULL DEFAULT (NULL),
  PRIMARY KEY CLUSTERED (MaKhoa)
)
ON [PRIMARY]
GO

--
-- Create table [dbo].[KetQua]
--
PRINT (N'Create table [dbo].[KetQua]')
GO
CREATE TABLE dbo.KetQua (
  MaSo int NOT NULL,
  MaMH nchar(6) NOT NULL DEFAULT (NULL),
  Diem int NULL,
  PRIMARY KEY CLUSTERED (MaSo, MaMH)
)
ON [PRIMARY]
GO

-- 
-- Dumping data for table SinhVien
--
PRINT (N'Dumping data for table SinhVien')
INSERT dbo.SinhVien VALUES (100, N'Nguyễn Văn A', '2000-01-01 00:00:00.000', CONVERT(bit, 'True'), 123456789, N'CNTT')
INSERT dbo.SinhVien VALUES (101, N'Nguyễn Văn B', '1900-10-10 00:00:00.000', CONVERT(bit, 'False'), 98765432, N'CNTP')
GO

-- 
-- Dumping data for table Mon
--
PRINT (N'Dumping data for table Mon')
INSERT dbo.Mon VALUES (N'MH001', N'Lập Trình Winform', 10)
INSERT dbo.Mon VALUES (N'MH002', N'Lập Trình Java', 9)
INSERT dbo.Mon VALUES (N'MH003', N'Lập Trình C', 20)
GO

-- 
-- Dumping data for table Khoa
--
PRINT (N'Dumping data for table Khoa')
INSERT dbo.Khoa VALUES (N'CNTP', N'Công Nghệ Thực Phẩm')
INSERT dbo.Khoa VALUES (N'CNTT', N'Công Nghệ Thông Tin')
INSERT dbo.Khoa VALUES (N'DDT', N'Điện Điện Tử')
INSERT dbo.Khoa VALUES (N'MT', N'Môi Trường')
INSERT dbo.Khoa VALUES (N'NN', N'Ngôn Ngữ')
INSERT dbo.Khoa VALUES (N'QTKD', N'Quản Trị Kinh Doanh')
GO

-- 
-- Dumping data for table KetQua
--
PRINT (N'Dumping data for table KetQua')
INSERT dbo.KetQua VALUES (100, N'MH003', 10)
INSERT dbo.KetQua VALUES (101, N'MH003', 7)
GO

USE QuanLySinhVien
GO

IF DB_NAME() <> N'QuanLySinhVien' SET NOEXEC ON
GO

--
-- Create foreign key [FK_SinhVien_Khoa] on table [dbo].[SinhVien]
--
PRINT (N'Create foreign key [FK_SinhVien_Khoa] on table [dbo].[SinhVien]')
GO
ALTER TABLE dbo.SinhVien
  ADD CONSTRAINT FK_SinhVien_Khoa FOREIGN KEY (MaKhoa) REFERENCES dbo.Khoa (MaKhoa)
GO

--
-- Create foreign key [FK_KetQua_Mon] on table [dbo].[KetQua]
--
PRINT (N'Create foreign key [FK_KetQua_Mon] on table [dbo].[KetQua]')
GO
ALTER TABLE dbo.KetQua
  ADD CONSTRAINT FK_KetQua_Mon FOREIGN KEY (MaMH) REFERENCES dbo.Mon (MaH)
GO

--
-- Create foreign key [FK_KetQua_SinhVien] on table [dbo].[KetQua]
--
PRINT (N'Create foreign key [FK_KetQua_SinhVien] on table [dbo].[KetQua]')
GO
ALTER TABLE dbo.KetQua
  ADD CONSTRAINT FK_KetQua_SinhVien FOREIGN KEY (MaSo) REFERENCES dbo.SinhVien (MaSo)
GO
SET NOEXEC OFF
GO