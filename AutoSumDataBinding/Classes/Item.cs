using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AutoSumDataBinding.Classes
{
    /// <summary>
    /// Property names are generic as this is for a forum question
    /// </summary>
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
        /// <summary>
        /// <see cref="Value1"/> * <see cref="Value2"/>
        /// </summary>
        public double Total => Value1 * Value2;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}