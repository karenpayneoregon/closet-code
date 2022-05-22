# Various tips and tricks

**How to not generate language folders.**

Add the following to .csproj

Slim down to, in this case three

```xml
<PropertyGroup>
	<LangVersion>9.0</LangVersion>
	<TargetFramework>net5.0</TargetFramework>
	<IsPackable>false</IsPackable>
	<SatelliteResourceLanguages>en;de;pt</SatelliteResourceLanguages>
</PropertyGroup>
```

Slim down to one

```xml
<PropertyGroup>
	<LangVersion>9.0</LangVersion>
	<TargetFramework>net5.0</TargetFramework>
	<IsPackable>false</IsPackable>
	<SatelliteResourceLanguages>en</SatelliteResourceLanguages>
</PropertyGroup>
```

![Satellite Resource Languages](assets/TipsTricks/SatelliteResourceLanguages.png)

**Add project reference alternative**

Usually to add a project reference, right click, `add`, `project reference` and select. An alternate is to click on the project to add to another project, while holding down the mouse button drag to the current project and release.

![image](assets/TipsTricks/AddReferenceInSolutionExplorer.png)


## Numbers only for TextBox

```csharp
private void TextBoxOnKeyPress(object sender, KeyPressEventArgs e)
{
    if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
    {
        e.Handled = true;
        return;
    }

    if (e.KeyChar == 46 && (sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
    {
        e.Handled = true;
    }
}
```

## Parse string to time

```csharp

public partial class Form1 : Form
{
    private void GetTimeButton_Click(object sender, EventArgs e)
    {
        string format = "Valid format is HH:mm";
        if (!string.IsNullOrWhiteSpace(TimeTextBox.Text))
        {
            TimeLabel.Text = DateTime.TryParseExact(TimeTextBox.Text, "HH:mm", 
                CultureInfo.InvariantCulture, DateTimeStyles.None, out var time) ?
                time.ToShortTimeString() : 
                format;
        }
        else
        {
            TimeLabel.Text = format;
        }
    }
}
```
