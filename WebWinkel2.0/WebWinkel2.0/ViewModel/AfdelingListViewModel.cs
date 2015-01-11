using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WebWinkel2._0.Model;


namespace WebWinkel2._0.ViewModel
{
  public class AfdelingListViewModel : ViewModelBase
  {
      DataContext db;

      //class constructor
      public AfdelingListViewModel()
      {
          SaveChanges = new RelayCommand(Save);
          AddNew = new RelayCommand(AddNewItem);
          DeleteSelected = new RelayCommand(Delete);

          db = new DataContext();
          var afdelingLijst = db.Afdelingen.ToList().Select(a => new AfdelingViewModel(a));
          Afdelingen = new ObservableCollection<AfdelingViewModel>(afdelingLijst);
          SelectedAfdeling = new AfdelingViewModel();
      }
     

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
              RaisePropertyChanged();
          }
      }

      public ICommand SaveChanges { get; set; }
      public ICommand AddNew { get; set; }
      public ICommand DeleteSelected { get; set; }

      public void Delete()
      {
          db.Afdelingen.Remove(SelectedAfdeling.Afdeling);
          Afdelingen.Remove(SelectedAfdeling);
          SelectedAfdeling = new AfdelingViewModel();
      }

      public void Save()
      {
          db.SaveChanges();
      }

      private void AddNewItem()
      {
          if (SelectedAfdeling.AfdelingId <= 0)
          {
              AfdelingViewModel pvm = new AfdelingViewModel();

              pvm.Naam = SelectedAfdeling.Naam;

              Afdelingen.Add(pvm);
              db.Afdelingen.Add(pvm.Afdeling);
          }
          else
          {
              this.SelectedAfdeling = new AfdelingViewModel();
          }
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
