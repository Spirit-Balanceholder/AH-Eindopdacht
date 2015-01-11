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
    
    public class ProductViewModel : INotifyPropertyChanged
    {


        private Product _product;
        public Product Product { get { return _product; } }
        public event PropertyChangedEventHandler PropertyChanged;


        //properties that link trough to the model's properties.
        public int ProductId 
        {
            get { return _product.ProductID; }
            set { _product.ProductID= value; OnPropertyChanged(); }
        }

        public String Naam
        {
            get { return _product.ProductNaam; }
            set { _product.ProductNaam = value; OnPropertyChanged(); }
        }

        public int? AfdelingID
        {
            get { return _product.AfdelingID; }
            set { _product.AfdelingID = value; OnPropertyChanged(); }
        }

        public Afdeling Afdeling
        {
            get { return _product.Afdeling; }
            set { _product.Afdeling = value; OnPropertyChanged(); }
        }
        
        //2 constructors, eentje voor het ontvangen van een model, eentje voor het aanmaken ervan
        public ProductViewModel()
            {
                _product = new Product();
            }

        public ProductViewModel(Product product)
        {
            _product = product;
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

