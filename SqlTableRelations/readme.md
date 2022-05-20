## Example working with SQL-Server table definitions

![image](assets/figure1.png)

Using a query targeting a single database displays table names in a ComboBox, select a table from the ComboBox, press a button which in turn populates a ListView with table definitions including related tables.

This maybe expanded to have a Window controls e.g. ListBox or ComboBox to display databases. Select a database, in the SqlServerOperations.SqlInformation class change the default catalog to the selected database which now provides the ability to work with any database the operator has permissions to work with.

## And there is more

See the following Microsoft Technet article

[Windows Forms ListView: Examining Detail view with SQL-Server](https://social.technet.microsoft.com/wiki/contents/articles/53356.windows-forms-listview-examining-detail-view-with-sql-server.aspx)

![image](assets/F2.jpg)

![image](assets/figure2.png)

## Permissions
See the [following repository](https://github.com/karenpayneoregon/SqlServerUserLoginSharp) for how to login a user with required permissions if needed when not using SQL-Server login or Windows authenication.