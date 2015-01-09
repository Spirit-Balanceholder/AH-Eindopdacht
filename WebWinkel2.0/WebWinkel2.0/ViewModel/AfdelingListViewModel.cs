using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WebWinkel2._0.Repositories;

namespace WebWinkel2._0.ViewModel
{
  public class AfdelingListViewModel : INotifyPropertyChanged
  {
      //for the purpose of navigation
     // private int _index;

      //our repository for testing purposes 
      IAfdelingRepository afdelingrepository;

      //lijst van songview models 
      public ObservableCollection<AfdelingViewModel> Afdelingen { get; set; }

      //selected object
      private AfdelingViewModel _selectedAfdeling;

      //reference property for afdeling
      public AfdelingViewModel SelectedAfdeling
      {
          get
          {
              return _selectedAfdeling;
          }
          set
          {
              _selectedAfdeling = value;
             //!!!!!!!!!!!!!!!!!!!!!!!!!!
              // RaisePropertyChanged();
          }
      }


      //class constructor
      public AfdelingListViewModel()
      {
          afdelingrepository = new Afdelingrepository();
          var afdelingLijst = afdelingrepository.ToList().Select(a => new AfdelingViewModel(a));
          Afdelingen = new ObservableCollection<AfdelingViewModel>(afdelingLijst);
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
