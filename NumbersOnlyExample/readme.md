# Custom NumericUpDown control

- Hide spinner
- Has a property `AsInteger` to get int value rather than decimal
- Surpress beep when pressing ENTER
- Will work with .NET Core

# Use in your project

1. Copy `SpecialNumericUpDown.cs` to your project
2. Build your project
3. Select a SpecialNumericUpDown control from Visual Studio ToolBox and place on a form.
4. See code below to get a `int` value in a Button `Click` event where in this case the button name is `CountButton`

```csharp
private void CountButton_Click(object sender, EventArgs e)
{
    int count = CountNumericUpDown.AsInteger;
    for (int index = 0; index < count; index++)
    {
        Console.WriteLine(index);
    }
}
```