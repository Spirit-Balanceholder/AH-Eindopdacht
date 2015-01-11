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
    public class MerkListViewModel : ViewModelBase
    {

        DataContext db;

        //class constructor
        public MerkListViewModel()
        {
            db = new DataContext();

            SaveChanges = new RelayCommand(Save);
            AddNew = new RelayCommand(AddNewItem);
            DeleteSelected = new RelayCommand(Delete);
            
            var merkLijst = db.Merken.ToList().Select(a => new MerkViewModel(a));
            Merken = new ObservableCollection<MerkViewModel>(merkLijst);

            SelectedMerk = new MerkViewModel();
        }
  



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

      public ICommand SaveChanges { get; set; }
      public ICommand AddNew { get; set; }
      public ICommand DeleteSelected { get; set; }

      public void Delete()
      {
          db.Merken.Remove(SelectedMerk.Merk);
          Merken.Remove(SelectedMerk);
          SelectedMerk = new MerkViewModel();
      }

      public void Save()
      {
          db.SaveChanges();
      }

      private void AddNewItem()
      {
          if (SelectedMerk.MerkID <= 0)
          {
              MerkViewModel pvm = new MerkViewModel();

              pvm.MerkNaam = SelectedMerk.MerkNaam;

              Merken.Add(pvm);
              db.Merken.Add(pvm.Merk);
          }
          else
          {
              this.SelectedMerk = new MerkViewModel();
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
