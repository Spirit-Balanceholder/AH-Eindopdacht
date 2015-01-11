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
    public class MerkListViewModel : ViewModelBase
    {

        //lijst van songview models 
      public ObservableCollection<MerkViewModel> Merken { get; set; }

      //selected object
      private MerkViewModel _selectedMerk;

      //reference property for merk
      public MerkViewModel SelectedMerk
      {
          get
          {
              return _selectedMerk;
          }
          set
          {
              _selectedMerk = value;         
              RaisePropertyChanged();
          }
      }


      //class constructor
      public MerkListViewModel()
      {
                   
          DataContext db = new DataContext();
          var merkLijst = db.Merken.ToList().Select(a => new MerkViewModel(a));
          Merken = new ObservableCollection<MerkViewModel>(merkLijst);
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
