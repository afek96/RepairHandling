USE [RepairHandling]
GO
INSERT INTO [dbo].[Role] ([RoleType],[Name]) VALUES ('ADM','Admin'),('MAN','Manager'),('WOR','Worker')
GO
INSERT [dbo].[ActivityType] ([ActivityType], [Name]) VALUES (N'LAK', N'Lakierowanie'),(N'MALOW', N'Malowanie'), (N'POLERKA', N'Polerowanie'), (N'SKREC', N'Skrêcanie')
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 
GO
INSERT [dbo].[Personel] ([IdPersonel], [FirstName], [LastName], [UserName], [Password], [Role], [ExpiryDate]) 
VALUES
(1, N'Adam', N'Malcherczyk', N'afek', N'fd50b90ee5d075e2d2e266f4d67065bc70c90421db826c3b731112ee7c01fe26', N'ADM', NULL),
(2, N'Rober', N'Nawra', N'roberto', N'roberto', N'WOR', CAST(N'2020-12-31T00:00:00.0000000' AS DateTime2)),
(3, N'Piotr', N'Musio³', N'speedy', N'a657fa855740a63d55448b06afbc256bcecb8ba1bcb219fea8def369b4d0ef29', N'MAN', NULL),
(4, N'£ukasz', N'Kwaœniak', N'kwasu', N'8af5f148f50b4881a3122ac96d29ec1449b7ac22e250ea39dfa96db2b1fb5ce8', N'WOR', NULL),
(5, N'Wojciech', N'Pietrzak', N'pietru', N'16bf11fd0a996c65bb6e98867e6eca7be3aea7368163d4caf69488f56f35d957', N'WOR', NULL),
(6, N'Mateusz', N'Rak', N'mati', N'e23aca4e773835e40018957f073f0d4cec0d41218ec0352d6a165333e318bac7', N'WOR', NULL),
(7, N'user', N'user', N'user', N'04f8996da763b7a969b1028ee3007569eaf3a635486ddab211d512c85b9df8fb', N'MAN', NULL)
GO
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO

