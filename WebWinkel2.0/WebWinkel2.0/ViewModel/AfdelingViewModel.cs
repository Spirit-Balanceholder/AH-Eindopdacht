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
        public event PropertyChangedEventHandler PropertyChanged;


        //properties that link trough to the model's properties.
        public int AfdelingId
        {
            get { return _afdeling.AfdelingId; }
            set { _afdeling.AfdelingId = value; OnPropertyChanged(); }
        }

        public String Naam
        {
            get { return _afdeling.Naam; }
            set { _afdeling.Naam = value; OnPropertyChanged(); }
        }
        
    //2 constructors, eentje voor het ontvangen van een model, eentje voor het aanmaken ervan
    public AfdelingViewModel()
        {
            _afdeling = new Afdeling();
        }

    public AfdelingViewModel(Afdeling afdeling)
    {
        _afdeling = afdeling;
    }


   
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    }
}
