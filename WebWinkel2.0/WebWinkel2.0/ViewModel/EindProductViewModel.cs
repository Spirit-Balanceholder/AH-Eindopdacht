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
    public class EindproductViewModel : INotifyPropertyChanged
    {


        private Eindproduct _eindproduct;
        public event PropertyChangedEventHandler PropertyChanged;


        //properties that link trough to the model's properties.
        //recept en kortingen worden achter de schermen geregeld i guess
        public String Eindproduct_ProductNaam
        {
            get { return _eindproduct.Product.ProductNaam; }
            set { _eindproduct.Product.ProductNaam = value; OnPropertyChanged(); }
        }

        public String Eindproduct_MerkNaam
        {
            get { return _eindproduct.Merk.MerkNaam; }
            set { _eindproduct.Merk.MerkNaam = value; OnPropertyChanged(); }
        }

     


       
        
    //2 constructors, eentje voor het ontvangen van een model, eentje voor het aanmaken ervan
    public EindproductViewModel()
        {
            _eindproduct = new Eindproduct();
        }

    public EindproductViewModel(Eindproduct eindproduct)
    {
        _eindproduct = eindproduct;
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
