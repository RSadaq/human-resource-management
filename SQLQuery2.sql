INSERT INTO [dbo].[Jobs] ([Id], [Bakery], [Tills], [Stocking_shelves], [Customer_Services], [Meat], [Internet_shopping]) VALUES (1579, 1, 1, 1, 1, 1, 1)
INSERT INTO [dbo].[Jobs] ([Id], [Bakery], [Tills], [Stocking_shelves], [Customer_Services], [Meat], [Internet_shopping]) VALUES (1580, 0, 1, 0, 1, 0, 1)
INSERT INTO [dbo].[Jobs] ([Id], [Bakery], [Tills], [Stocking_shelves], [Customer_Services], [Meat], [Internet_shopping]) VALUES (1581, 0, 1, 0, 1, 0, 1)
INSERT INTO [dbo].[Jobs] ([Id], [Bakery], [Tills], [Stocking_shelves], [Customer_Services], [Meat], [Internet_shopping]) VALUES (1582, 0, 1, 1, 0, 0, 0)
INSERT INTO [dbo].[Jobs] ([Id], [Bakery], [Tills], [Stocking_shelves], [Customer_Services], [Meat], [Internet_shopping]) VALUES (1583, 1, 0, 1, 1, 0, 0)
INSERT INTO [dbo].[Jobs] ([Id], [Bakery], [Tills], [Stocking_shelves], [Customer_Services], [Meat], [Internet_shopping]) VALUES (1584, 1, 1, 1, 0, 0, 0)
INSERT INTO [dbo].[Jobs] ([Id], [Bakery], [Tills], [Stocking_shelves], [Customer_Services], [Meat], [Internet_shopping]) VALUES (1585, 0, 0, 0, 1, 1, 1)
INSERT INTO [dbo].[Jobs] ([Id], [Bakery], [Tills], [Stocking_shelves], [Customer_Services], [Meat], [Internet_shopping]) VALUES (1586, 0, 0, 1, 1, 1, 1)
INSERT INTO [dbo].[Jobs] ([Id], [Bakery], [Tills], [Stocking_shelves], [Customer_Services], [Meat], [Internet_shopping]) VALUES (1587, 1, 1, 1, 0, 0, 0)
INSERT INTO [dbo].[Jobs] ([Id], [Bakery], [Tills], [Stocking_shelves], [Customer_Services], [Meat], [Internet_shopping]) VALUES (1588, 1, 1, 0, 1, 1, 1)

SELECT Current_Job, Shifts FROM Assignment WHERE Name = 'John Knight';
UPDATE Assignment SET Shifts = Shifts - 1 WHERE (Shifts = 0 AND Name = 'John Knight');