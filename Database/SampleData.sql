USE [NIHF]
GO
SET IDENTITY_INSERT [dbo].[Manufacturer] ON 

INSERT [dbo].[Manufacturer] ([ID], [Name]) VALUES (1, N'Delco')
INSERT [dbo].[Manufacturer] ([ID], [Name]) VALUES (2, N'Chrysler')
INSERT [dbo].[Manufacturer] ([ID], [Name]) VALUES (3, N'Dodge')
INSERT [dbo].[Manufacturer] ([ID], [Name]) VALUES (5, N'FORD')
SET IDENTITY_INSERT [dbo].[Manufacturer] OFF
SET IDENTITY_INSERT [dbo].[Part] ON 

INSERT [dbo].[Part] ([ID], [Number], [Name], [Description], [ManufacturerID]) VALUES (1, N'00001', N'SPK', N'Ignites gas in the engine cylinder', 1)
INSERT [dbo].[Part] ([ID], [Number], [Name], [Description], [ManufacturerID]) VALUES (3, N'00003', N'RRP', N'Truck Right Rear Passenger Panel', 1)
SET IDENTITY_INSERT [dbo].[Part] OFF
