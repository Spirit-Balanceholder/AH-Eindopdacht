using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebWinkel2._0.Model;

namespace WebWinkel2._0.ViewModel
{
    public class AfdelingViewModel : INotifyPropertyChanged
    {
        private Afdeling _afdeling;
    
    public AfdelingViewModel()
        {
            _afdeling = new Afdeling();
        }

    public AfdelingViewModel(Afdeling afdeling)
    {
        _afdeling = afdeling;
    }


    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    }
}
