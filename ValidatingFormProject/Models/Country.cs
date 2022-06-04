using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ValidatingFormProject.Models
{
    public class Country : INotifyPropertyChanged
    {
        private string _countryName;
        private int _countryIdentifier;

        [Key]
        public int CountryIdentifier
        {
            get => _countryIdentifier;
            set
            {
                _countryIdentifier = value;
                OnPropertyChanged();
            }
        }
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [Display(Name = "Country name")]
        
        public string CountryName
        {
            get => _countryName;
            set
            {
                _countryName = value;
                OnPropertyChanged();
            }
        }

        public override string ToString() => CountryName;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}