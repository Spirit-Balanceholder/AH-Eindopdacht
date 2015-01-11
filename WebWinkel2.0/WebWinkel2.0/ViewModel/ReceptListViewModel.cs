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
    public class ReceptListViewModel : ViewModelBase
    {

         //lijst van songview models 
      public ObservableCollection<ReceptViewModel> Recepten { get; set; }

      //selected object
      private ReceptViewModel _selectedRecept;

      //reference property for recept
      public ReceptViewModel SelectedRecept
      {
          get
          {
              return _selectedRecept;
          }
          set
          {
              _selectedRecept = value;         
              RaisePropertyChanged();
          }
      }


      //class constructor
      public ReceptListViewModel()
      {
                   
          DataContext db = new DataContext();
          var receptLijst = db.Recepten.ToList().Select(a => new ReceptViewModel(a));
          Recepten = new ObservableCollection<ReceptViewModel>(receptLijst);
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
