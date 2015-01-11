using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebWinkel2._0.Model;

namespace WebWinkel2._0.ViewModel
{
  public  class EindproductListViewModel : ViewModelBase
    {

        //our repository for testing purposes 
     // Eindproductrepository eindproductrepository;

      //lijst van songview models 
      public ObservableCollection<EindproductViewModel> Eindproducten { get; set; }

      //selected object
      private EindproductViewModel _selectedEindproduct;

      //reference property for eindproduct
      public EindproductViewModel SelectedEindproduct
      {
          get
          {
              return _selectedEindproduct;
          }
          set
          {
              _selectedEindproduct = value;         
              RaisePropertyChanged();
          }
      }


      //class constructor
      public EindproductListViewModel()
      {
                   
          DataContext db = new DataContext();
          var eindproductLijst = db.Eindproducten.ToList().Select(a => new EindproductViewModel(a));
          Eindproducten = new ObservableCollection<EindproductViewModel>(eindproductLijst);
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
