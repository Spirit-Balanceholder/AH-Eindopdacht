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
      IAfdelingRepository afdelingrepository;

    

      //referentie naar 1 item uit de lijst, basis voor het aanmaken van een nieuw element
      public AfdelingViewModel Afdeling { get; set; }

      //lijst van songview models 
      public ObservableCollection<AfdelingViewModel> afdelingen { get; set; }
  
        //constructor
      public AfdelingListViewModel()
      {
          afdelingrepository = new Afdelingrepository();
          var afdelingList = afdelingrepository.ToList().Select(s => new AfdelingViewModel(s));

          Afdeling = new AfdelingViewModel();
          afdelingen = new ObservableCollection<AfdelingViewModel>(afdelingList);

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
