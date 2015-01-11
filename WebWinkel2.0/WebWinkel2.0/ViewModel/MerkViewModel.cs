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
    public class MerkViewModel : INotifyPropertyChanged
    {


        private Merk _merk;
        public event PropertyChangedEventHandler PropertyChanged;
        public Merk Merk { get { return _merk; } }

        //properties that link trough to the model's properties.
      

        public String MerkNaam
        {
            get { return _merk.MerkNaam; }
            set { _merk.MerkNaam = value; OnPropertyChanged(); }
        }

        public int MerkID
        {
            get { return _merk.MerkID; }
            set { _merk.MerkID = value; OnPropertyChanged(); }
        }
        
    //2 constructors, eentje voor het ontvangen van een model, eentje voor het aanmaken ervan
    public MerkViewModel()
        {
            _merk = new Merk();
        }

    public MerkViewModel(Merk merk)
    {
        _merk = merk;
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
