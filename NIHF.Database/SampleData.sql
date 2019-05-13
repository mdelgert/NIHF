USE [NIHF]
GO
SET IDENTITY_INSERT [dbo].[Manufacturer] ON 
GO
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (1, N'Delco')
GO
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (2, N'Chrysler')
GO
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (3, N'Dodge')
GO
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (5, N'FORD')
GO
SET IDENTITY_INSERT [dbo].[Manufacturer] OFF
GO
SET IDENTITY_INSERT [dbo].[Part] ON 
GO
INSERT [dbo].[Part] ([PartID], [Number], [Name], [Description], [Manufacturer]) VALUES (8, N'00001', N'SPK', N'Lights spark in engine', N'Delco')
GO
INSERT [dbo].[Part] ([PartID], [Number], [Name], [Description], [Manufacturer]) VALUES (9, N'00002', N'PNLR', N'Right rear truck panel', N'Chrysler')
GO
INSERT [dbo].[Part] ([PartID], [Number], [Name], [Description], [Manufacturer]) VALUES (10, N'00003', N'LRPNL', N'Left rear truck panel.', N'Chrysler')
GO
INSERT [dbo].[Part] ([PartID], [Number], [Name], [Description], [Manufacturer]) VALUES (11, N'00004', N'PLUGCVR', N'Park plug cover.', N'Delco')
GO
SET IDENTITY_INSERT [dbo].[Part] OFF
GO
