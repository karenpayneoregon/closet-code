# About

Developer at one time or another need to export data to Excel. Consider using Entity Framework Core and want to export data to Excel. 

A common solution is to create Excel automation objects, iterate through their data and set cell values along with formatting cells. 

Problems with this approach

- Client changes their version of Excel which can break an application
- Memory leaks when not coded properly, had to detect in many cases.
  - When I coded with Excel automation I adapted the `one dot rule` which meant no one line of code for Excel automation had more than one <kbd>.</kbd> which other developer have argued `why?` well because it allows memory to be released correctly, more code but worthit.
- Client does not have Excel install
- Application runs from a server, this can have problems with permissions

**Alternate approach**

Use Open XML for Excel using a third party library, for common operations there are plenty of free libraries out there or opt for a robust paid for product. 

For free libraries they tend to have a method to import a list or DataTable into Excel.

GemBox.SpreadSheet (not cheap but a great library)

[Example](https://www.gemboxsoftware.com/spreadsheet/examples/open-read-import-excel-spreadsheet/6007)

```csharp
using System;
using System.Data;
using System.Text;
using GemBox.Spreadsheet;

class Program
{
    static void Main()
    {
        // If you are using the Professional version, enter your serial key below.
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

        var workbook = ExcelFile.Load("SimpleTemplate.xlsx");

        // Select the first worksheet from the file.
        var worksheet = workbook.Worksheets[0];

        // Create DataTable from an Excel worksheet.
        var dataTable = worksheet.CreateDataTable(new CreateDataTableOptions()
        {
            ColumnHeaders = true,
            StartRow = 1,
            NumberOfColumns = 5,
            NumberOfRows = worksheet.Rows.Count - 1,
            Resolution = ColumnTypeResolution.AutoPreferStringCurrentCulture
        });

        // Write DataTable content
        var sb = new StringBuilder();
        sb.AppendLine("DataTable content:");
        foreach (DataRow row in dataTable.Rows)
        {
            sb.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}", row[0], row[1], row[2], row[3], row[4]);
            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString());
    }
}
```

On the cheap, [SpreadSheetLight](https://spreadsheetlight.com/)

*SpreadsheetLight is an open source Open XML spreadsheet library for .NET Framework written in C#, and is released under the MIT License. You can create new Open XML spreadsheets, or work with existing Open XML spreadsheets that are compatible with Microsoft Excel 2007/2010/2013 and LibreOffice Calc.*

- No Office/Excel Interop needed. You do not need Microsoft Office/Excel to be installed.
- Has full documentation to download

Personally this is my choice for a free library while Gembox for serious work.

Let’s use Entity Framework Core for demonstrating with SpreadSheetLight.

Since SpreadSheetLight method to import only accepts a DataTable we need to take

```csharp
public class CustomerOperations
{
    /// <summary>
    /// This method is for importing this data to a new Excel file.
    /// </summary>
    /// <returns>List&lt;<see cref="CustomersForExcel"/>&gt;</returns>
    public static List<CustomersForExcel> ToExcel()
    {
        using var context = new Context();

        return context.Customers
            .Include(customer => customer.Contact)
            .Include(customer => customer.ContactTypeIdentifierNavigation)
            .Include(customer => customer.CountryIdentifierNavigation)
            .Include(customer => customer.Contact.ContactDevices)
            .Select(current => new CustomersForExcel(
                current.CompanyName, 
                current.CountryIdentifierNavigation.Name, 
                current.Contact.ContactTypeIdentifierNavigation.ContactTitle, 
                $"{current.Contact.FirstName} {current.Contact.LastName}", 
                current.Phone, current.ModifiedDate, current.CustomerIdentifier))
            .ToList();

    }
}
```

To a `DataTable`where there are common generic methods on the web which work great but not optimal for large spreadsheets so we use an NuGet package [FastMember](https://www.nuget.org/packages/FastMember/) which is both fast and optimal for any size Excel file.

Using FastMember, create a new DataTable, pass it to `ObjectReader.Create`

```csharp
public static void CustomersToExcel(List<CustomersForExcel> list, string fileName)
{
    System.Data.DataTable table = new();
    using var reader = ObjectReader.Create(list);
    table.Load(reader);
```

Next steps, 

Set colums in the DataTable to the correct display order using [SetOrdinal](http://example.com)

Create a new document

```csharp
using var document = new SLDocument();
```

Create a header style

```csharp
public static SLStyle HeaderStye(SLDocument document)
{
    
    SLStyle headerStyle = document.CreateStyle();

    headerStyle.Font.Bold = true;
    headerStyle.Font.FontColor = Color.White;
    headerStyle.Fill.SetPattern(
        PatternValues.LightGray,
        SLThemeColorIndexValues.Accent1Color,
        SLThemeColorIndexValues.Accent5Color);

    return headerStyle;
}
```

Create a style for the DateTime column

```csharp
SLStyle dateStyle = document.CreateStyle();
dateStyle.FormatCode = "mm-dd-yyyy";
```

Import data

```csharp
document.ImportDataTable(1, SLConvert.ToColumnIndex("A"), table, true);
```

Note parameter 1 is the start row, second parameter is the start column. This means you can do multiple imports and append.

To get the last row

```csharp
document.GetWorksheetStatistics().EndRowIndex
```

Finishing touches which do auto fit column data, rename the sheet and set the active cells then save.

```csharp
document.HideColumn(7, 7);
document.SetColumnStyle(dateColumnIndex, dateStyle);

for (int columnIndex = 1; columnIndex < table.Columns.Count; columnIndex++)
{
    document.AutoFitColumn(columnIndex);
}

document.AutoFitColumn(dateColumnIndex + 1);
            
document.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Customers");

document.SetCellStyle(1, 1, 1, 6, headerStyle);

// one row below header
document.SetActiveCell("A2");

// ensure header is visible when scrolling down
document.FreezePanes(1,6);

document.SaveAs(fileName);
```

**Results**

![example](../assets/Excel1.png)

