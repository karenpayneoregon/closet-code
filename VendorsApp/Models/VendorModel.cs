using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using ThirdPartyLibrary.Classes;
using ThirdPartyLibrary.Models;

namespace VendorsApp.Models
{
    public class VendorModel : INotifyPropertyChanged
    {
        private readonly CollectionView _vendorEntries;
        private string _vendorEntry;

        public VendorModel()
        {
            IReadOnlyList<Vendor> list = References.Vendors();
            _vendorEntries = new CollectionView(list);
        }

        public CollectionView VendorEntries => _vendorEntries;

        public string VendorEntry
        {
            get => _vendorEntry;
            set
            {

                if (_vendorEntry == value)
                {
                    return;
                }

                _vendorEntry = value;

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
