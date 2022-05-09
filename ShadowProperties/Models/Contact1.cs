using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace ShadowProperties.Models
{
    [Table("Contact1")]
    public partial class Contact1 : INotifyPropertyChanged
    {
        private int _contactId;
        private string _firstName;
        private string _lastName;
        private DateTime? _lastUpdated;
        private string _lastUser;
        private DateTime? _createdAt;
        private string _createdBy;

        public int ContactId
        {
            get => _contactId;
            set
            {
                _contactId = value;
                OnPropertyChanged();
            }
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
        #region Not needed for shadow properties only for displaying in DataGridView

        public DateTime? LastUpdated
        {
            get => _lastUpdated;
            set
            {
                _lastUpdated = value;
                OnPropertyChanged();
            }
        }

        public string LastUser
        {
            get => _lastUser;
            set
            {
                _lastUser = value;
                OnPropertyChanged();
            }
        }

        public DateTime? CreatedAt
        {
            get => _createdAt;
            set
            {
                _createdAt = value;
                OnPropertyChanged();
            }
        }

        public string CreatedBy
        {
            get => _createdBy;
            set
            {
                _createdBy = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public Contact1(int id)
        {
            ContactId = id;
        }

        public Contact1()
        {
            
        }

        public override string ToString() => $"{FirstName} {LastName}";

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}