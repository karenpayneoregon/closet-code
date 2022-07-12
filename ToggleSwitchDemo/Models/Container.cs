using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToggleSwitchDemo.Models
{
    /// <summary>
    /// Class for remembering settings
    /// </summary>
    /// <remarks>
    /// <see cref="INotifyPropertyChanged"/> provides change control between two forms
    /// </remarks>
    public class Container : INotifyPropertyChanged
    {
        private bool _bPlusRelay;
        private bool _bMinusRelay;
        private bool _preRelay;

        public bool BPlusRelay
        {
            get => _bPlusRelay;
            set
            {
                _bPlusRelay = value;
                OnPropertyChanged();
            }
        }

        public bool BMinusRelay
        {
            get => _bMinusRelay;
            set
            {
                _bMinusRelay = value;
                OnPropertyChanged();
            }
        }

        public bool PreRelay
        {
            get => _preRelay;
            set
            {
                _preRelay = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
