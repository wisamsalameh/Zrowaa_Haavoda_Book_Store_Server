/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
      ,[Description]
      ,[Price]
  FROM [Zrowaa_Haavoda].[dbo].[bookData]

  INSERT INTO [Zrowaa_Haavoda].[dbo].[bookData] ([Name],[Description],price) VALUES ( 'Science Fiction','Science Fiction',150);
  INSERT INTO [Zrowaa_Haavoda].[dbo].[bookData] ([Name],[Description],price) VALUES ( 'Sport','Football Game',200);
  INSERT INTO [Zrowaa_Haavoda].[dbo].[bookData] ([Name],[Description],price) VALUES ( 'High Tech','High Tech',777);


  CREATE DATABASE Zrowaa_Haavoda;

