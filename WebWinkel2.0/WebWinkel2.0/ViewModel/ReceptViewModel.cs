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
    public class ReceptViewModel : INotifyPropertyChanged
    {

         private Recept _recept;
        public event PropertyChangedEventHandler PropertyChanged;


        //properties that link trough to the model's properties.
       

        public String Naam
        {
            get { return _recept.ReceptNaam; }
            set { _recept.ReceptNaam = value; OnPropertyChanged();                           
           }
        }

       
     //ADDED BY BRAM 
        public List<Eindproduct> Eindproducten
        {
            get
            {
                List<Eindproduct> testlijstje = new List<Eindproduct>();
                foreach (Recept_Has_Eindproduct rhe in _recept.Recept_has_Eindproduct)
                {
                    testlijstje.Add(rhe.Eindproduct);
                }
                return testlijstje;

            }
            set { }
        }

        public int TotaalPrijs
        {
            get
            {
                int i = 0;
                DataContext db = new DataContext();
                foreach (Recept_Has_Eindproduct rhe in _recept.Recept_has_Eindproduct)
                {
                    i = (i + rhe.Eindproduct.Prijs.Hoeveelheid);
                }

                return i;
            }
            set { }
        }
        //END

       
    //2 constructors, eentje voor het ontvangen van een model, eentje voor het aanmaken ervan
    public ReceptViewModel()
        { 
            _recept = new Recept();
        }

    public ReceptViewModel(Recept recept)
    {
        _recept = recept;
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
