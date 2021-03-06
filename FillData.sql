USE [RepairHandling]
GO
SET IDENTITY_INSERT [dbo].[Address] ON 
GO
INSERT [dbo].[Address] ([IdAddress], [City], [Street], [HouseNumber], [PostalCode]) VALUES (1, N'Gliwice', N'Konarskiego', N'44', N'44-100')
GO
SET IDENTITY_INSERT [dbo].[Address] OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 
GO
INSERT [dbo].[Client] ([IdClient], [Name], [FirstName], [LastName], [PhoneNumber], [IdAddress]) VALUES (1, N'Imobit', N'', N'', N'666777888', 1)
GO
INSERT [dbo].[Client] ([IdClient], [Name], [FirstName], [LastName], [PhoneNumber], [IdAddress]) VALUES (2, N'', N'Adam', N'Małysz', N'123456123', NULL)
GO
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
INSERT [dbo].[ObjectType] ([ObjectType], [Name]) VALUES (N'VS6514', N'Volkswagen')
GO
INSERT [dbo].[ObjectType] ([ObjectType], [Name]) VALUES (N'SGL12345', N'Honda')
GO
SET IDENTITY_INSERT [dbo].[Object] ON 
GO
INSERT [dbo].[Object] ([IdObject], [IdClient], [Type], [Name]) VALUES (1, 1, N'SGL12345', N'Firmowa Honda')
GO
INSERT [dbo].[Object] ([IdObject], [IdClient], [Type], [Name]) VALUES (2, 2, N'VS6514', N'Name1')
GO
SET IDENTITY_INSERT [dbo].[Object] OFF
GO
INSERT [dbo].[Role] ([RoleType], [Name]) VALUES (N'ADM', N'Admin')
GO
INSERT [dbo].[Role] ([RoleType], [Name]) VALUES (N'MAN', N'Manager')
GO
INSERT [dbo].[Role] ([RoleType], [Name]) VALUES (N'WOR', N'Worker')
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 
GO
INSERT [dbo].[Personel] ([IdPersonel], [FirstName], [LastName], [UserName], [Password], [Role], [ExpiryDate]) VALUES (1, N'Adam', N'Malcherczyk', N'afek', N'fd50b90ee5d075e2d2e266f4d67065bc70c90421db826c3b731112ee7c01fe26', N'ADM', NULL)
GO
INSERT [dbo].[Personel] ([IdPersonel], [FirstName], [LastName], [UserName], [Password], [Role], [ExpiryDate]) VALUES (4, N'Robert', N'Nawrat', N'roberto', N'72534c4a93ddc043fe3229ed46b1d526c4ccc747febdcd0f284f7f6057a37858', N'WOR', CAST(N'2020-12-31T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Personel] ([IdPersonel], [FirstName], [LastName], [UserName], [Password], [Role], [ExpiryDate]) VALUES (6, N'Piotr', N'Musioł', N'speedy', N'a657fa855740a63d55448b06afbc256bcecb8ba1bcb219fea8def369b4d0ef29', N'MAN', NULL)
GO
INSERT [dbo].[Personel] ([IdPersonel], [FirstName], [LastName], [UserName], [Password], [Role], [ExpiryDate]) VALUES (7, N'Łukasz', N'Kwaśniak', N'kwasu', N'8af5f148f50b4881a3122ac96d29ec1449b7ac22e250ea39dfa96db2b1fb5ce8', N'WOR', NULL)
GO
INSERT [dbo].[Personel] ([IdPersonel], [FirstName], [LastName], [UserName], [Password], [Role], [ExpiryDate]) VALUES (8, N'Wojciech', N'Pietrzak', N'pietru', N'16bf11fd0a996c65bb6e98867e6eca7be3aea7368163d4caf69488f56f35d957', N'WOR', NULL)
GO
INSERT [dbo].[Personel] ([IdPersonel], [FirstName], [LastName], [UserName], [Password], [Role], [ExpiryDate]) VALUES (9, N'Mateusz', N'Rak', N'mati', N'e23aca4e773835e40018957f073f0d4cec0d41218ec0352d6a165333e318bac7', N'WOR', NULL)
GO
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Request] ON 
GO
INSERT [dbo].[Request] ([IdRequest], [Description], [Result], [Status], [CreateDate], [EndDate], [IdObject], [IdPersonel]) VALUES (1, N'Honda do lakierowania', NULL, N'OPN', CAST(N'2019-03-11T11:38:29.9873138' AS DateTime2), NULL, 2, 6)
GO
SET IDENTITY_INSERT [dbo].[Request] OFF
GO
INSERT [dbo].[ActivityType] ([ActivityType], [Name]) VALUES (N'LAK', N'Lakierowanie')
GO
INSERT [dbo].[ActivityType] ([ActivityType], [Name]) VALUES (N'MALOW', N'Malowanie')
GO
INSERT [dbo].[ActivityType] ([ActivityType], [Name]) VALUES (N'POLERKA', N'Polerowanie')
GO
INSERT [dbo].[ActivityType] ([ActivityType], [Name]) VALUES (N'SKREC', N'Skręcanie')
GO
SET IDENTITY_INSERT [dbo].[Activity] ON 
GO
INSERT [dbo].[Activity] ([IdActivity], [SequenceNo], [Description], [Result], [Status], [CreateDate], [EndDate], [Type], [IdRequest], [IdPersonel]) VALUES (1, 0, N'Polakieruj mój padawanie', N'Polakierowałem miszczu', N'FIN', CAST(N'2019-03-16T19:50:47.7683196' AS DateTime2), CAST(N'2019-03-16T21:53:24.8976749' AS DateTime2), N'LAK', 1, 7)
GO
INSERT [dbo].[Activity] ([IdActivity], [SequenceNo], [Description], [Result], [Status], [CreateDate], [EndDate], [Type], [IdRequest], [IdPersonel]) VALUES (2, 0, N'Pomaluj mi to zaraz', N'', N'OPN', CAST(N'2019-03-24T19:11:56.7496723' AS DateTime2), NULL, N'MALOW', 1, 7)
GO
INSERT [dbo].[Activity] ([IdActivity], [SequenceNo], [Description], [Result], [Status], [CreateDate], [EndDate], [Type], [IdRequest], [IdPersonel]) VALUES (3, 4, N'Na co czekasz skręcaj, skręcaj', N'', N'OPN', CAST(N'2019-03-24T19:22:35.3136672' AS DateTime2), NULL, N'SKREC', 1, 8)
GO
SET IDENTITY_INSERT [dbo].[Activity] OFF
GO
