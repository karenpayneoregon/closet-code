using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using ThirdPartyLibrary.Classes;
using ThirdPartyLibrary.Models;

namespace VendorsApp.Models;

public class VendorModel : INotifyPropertyChanged
{

    public VendorModel()
    {
        var list = References.Vendors();
        VendorEntries = new CollectionView(list);
        Debug.WriteLine(ObjectDumper.Dump(list, DumpStyle.CSharp));
    }

    public CollectionView VendorEntries { get; }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}