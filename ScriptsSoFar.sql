/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/

USE [Vidly]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsLetter], [MembershipTypeId], [DateOfBirth]) VALUES (1, N'Levi Ackerman', 1, 4, CAST(N'1990-04-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsLetter], [MembershipTypeId], [DateOfBirth]) VALUES (2, N'Erwin Smith', 0, 1, CAST(N'1989-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsLetter], [MembershipTypeId], [DateOfBirth]) VALUES (3, N'Eren Yeager', 1, 4, NULL)
GO
INSERT [dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsLetter], [MembershipTypeId], [DateOfBirth]) VALUES (4, N'Armin Arlert', 0, 3, NULL)
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 
GO
INSERT [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId]) VALUES (1, N'Titanic', CAST(N'1994-01-01T00:00:00.000' AS DateTime), CAST(N'2006-08-10T00:00:00.000' AS DateTime), 100, 4)
GO
INSERT [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId]) VALUES (3, N'Toy Story', CAST(N'2011-05-09T00:00:00.000' AS DateTime), CAST(N'2016-10-21T00:00:00.000' AS DateTime), 56, 1)
GO
INSERT [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId]) VALUES (4, N'Hangover', CAST(N'2017-05-21T00:00:00.000' AS DateTime), CAST(N'2018-03-20T00:00:00.000' AS DateTime), 5, 1)
GO
INSERT [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId]) VALUES (6, N'The Terminator', CAST(N'1999-05-30T00:00:00.000' AS DateTime), CAST(N'2000-01-01T00:00:00.000' AS DateTime), 200, 2)
GO
INSERT [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId]) VALUES (7, N'50 First Dates', CAST(N'2007-06-08T00:00:00.000' AS DateTime), CAST(N'2010-12-28T00:00:00.000' AS DateTime), 57, 3)
GO
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
