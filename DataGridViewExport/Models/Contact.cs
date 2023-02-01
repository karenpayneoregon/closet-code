using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataGridViewExport.Models;

public class Contact : INotifyPropertyChanged
{
    private string _firstName;
    private string _lastName;
    private string _phone;
    private string _email;
    private DateTime _birthDate;
    public int Id { get; set; }

    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            OnPropertyChanged();
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            OnPropertyChanged();
        }
    }

    public string Phone
    {
        get => _phone;
        set
        {
            _phone = value;
            OnPropertyChanged();
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            OnPropertyChanged();
        }
    }

    public DateTime BirthDate
    {
        get => _birthDate;
        set
        {
            _birthDate = value;
            OnPropertyChanged();
        }
    }

    public Contact(int id)
    {
        Id = id;
    }

    public Contact()
    {
            
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}