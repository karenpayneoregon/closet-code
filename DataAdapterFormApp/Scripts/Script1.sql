SELECT id, 
       FirstName, 
       LastName, 
       HiredDate
FROM ForumExample.dbo.employee;

---DELETE FROM [ForumExample].[dbo].[employee] WHERE [dbo].[employee].id > 5
---DBCC CHECKIDENT ('[employee]', RESEED, 5);
