# About

Forum question

*How to sum a two number from two different textbox without clicking the button the sum will automatically displayed in the label*

They had

```csharp
protected void button1(object sender, EventArgs e)
{
    double a, b, product;
    a = double.Parse(txtt1.Text);
    b = 15;
    product = a * 15;
    lbl_.Text = Convert.ToString(product);
```

Someone responded with

```csharp
protected void TextBox2_TextChanged(object sender, EventArgs e)
{
  int valueToAdd = Convert.ToInt32(textBox2.Text);
  int newValue = Convert.ToInt32(textBoxToChange.Text) + valueToAdd;
  textBoxToChange.Text = newValue.ToString();
}
```

**We can improve this**

First eliminate a reason to convert TextBox input

```csharp
public class ControlEvents
{
    public static void TextBoxOnKeyPress(object sender, KeyPressEventArgs e)
    {
        if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
        {
            e.Handled = true;
            return;
        }

        if (e.KeyChar == 46)
        {
            if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                e.Handled = true;
        }
    }
}
```

Then create a class to ensure only proper values are provided along with change notification so no button click is needed to calculate the total of the two TextBox controls.

```csharp
public class Item : INotifyPropertyChanged
{
    private double _value1;
    private double _value2;

    public double Value1
    {
        get => _value1;
        set
        {
            _value1 = value;
            OnPropertyChanged();
        }
    }

    public double Value2
    {
        get => _value2;
        set
        {
            _value2 = value;
            OnPropertyChanged();
        }
    }

    public double Total => Value1 * Value2;

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
```

Then in the form, not much needed, some data binding and preset some data so when the app runs we see it works.

```
public partial class Form1 : Form
{
    private readonly BindingSource _bindingSource = new BindingSource();
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        textBox1.KeyPress += TextBoxOnKeyPress;
        textBox2.KeyPress += TextBoxOnKeyPress;

        _bindingSource.DataSource = new List<Item>()
        {
            new () {Value1 = 12, Value2 = 4}
        };

        textBox1.DataBindings.Add("Text", _bindingSource,
            nameof(Item.Value1));

        textBox2.DataBindings.Add("Text", _bindingSource,
            nameof(Item.Value2));

        TotalLabel.DataBindings.Add("Text", _bindingSource,
            nameof(Item.Total));
    }
}
```

Someone clever developer might say, let's do this without change notification and code everything right in the form, sure why not but that is the lazy way to code in my opinion and dirty up the form code. Also note the event for `KeyPress` is not in the form but in a class which means its reusable in this on any form project.

Lastly, note how Data Binding is done with `nameof` which means it's not prone to fail if the property name changes.

```csharp
textBox1.DataBindings.Add("Text", _bindingSource,
    nameof(Item.Value1));
```

And the control names should be better named.