SET IDENTITY_INSERT [dbo].[Things] ON 

INSERT [dbo].[Things] ([Id], [Guid], [Name], [Description], [Value], [CreatedOn], [UpdatedOn], [CurrencyId], [ImageId], [CategoryId], [UserId]) VALUES (1, N'66b3ea92-a4ac-4e4d-ad67-071069219998', N'Soldering iron', N'Soldering iron', CAST(70.0000 AS Decimal(18, 4)), CAST(N'2020-07-23T00:00:00.0000000+00:00' AS DateTimeOffset), NULL, 2, NULL, 3, 1)
SET IDENTITY_INSERT [dbo].[Things] OFF
