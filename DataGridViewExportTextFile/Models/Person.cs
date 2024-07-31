using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataGridViewExportTextFile.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private int _id;
        private DateTime _birthDate;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

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

        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                _birthDate = value;
                OnPropertyChanged();
            }
        }

        public Person(int identifier)
        {
            Id = identifier;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}