using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebWinkel2._0.Repositories;

namespace WebWinkel2._0.ViewModel
{
    public class ProductListViewModel : INotifyPropertyChanged
    {

          //for the purpose of navigation
     // private int _index;

      //our repository for testing purposes 
      IProductRepository productrepository;

      //lijst van songview models 
      public ObservableCollection<ProductViewModel> Producten { get; set; }

      //selected object
      private ProductViewModel _selectedProduct;

      //reference property for product
      public ProductViewModel SelectedProduct
      {
          get
          {
              return _selectedProduct;
          }
          set
          {
              _selectedProduct = value;
             //!!!!!!!!!!!!!!!!!!!!!!!!!!
              // RaisePropertyChanged();
          }
      }


      //class constructor
      public ProductListViewModel()
      {
          productrepository = new Productrepository();
          var productLijst = productrepository.ToList().Select(a => new ProductViewModel(a));
          Producten = new ObservableCollection<ProductViewModel>(productLijst);
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

