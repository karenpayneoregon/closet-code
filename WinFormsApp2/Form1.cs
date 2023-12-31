using System.ComponentModel;
using WindowsFormsLibrary.LanguageExtensions;
using WinFormsApp2.Classes;
using WinFormsApp2.Models;

namespace WinFormsApp2;

public partial class Form1 : Form
{
    private BindingList<Book> _bindingList;
    public Form1()
    {
        InitializeComponent();
        JsonOperations.CreateFile();
        BooksListBox1.DataSource = JsonOperations.BookList();

        _bindingList = new BindingList<Book>(JsonOperations.BookList());
        BooksListBox2.DataSource = _bindingList;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        this.DisableControls("button1", "button3", "button4");
    }

    private void button4_Click(object sender, EventArgs e)
    {
        this.EnableControls();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        BooksListBox1.SaveToFile<Book>("Demo.json");
        _bindingList.SaveToFile("binding.json");
    }
}
