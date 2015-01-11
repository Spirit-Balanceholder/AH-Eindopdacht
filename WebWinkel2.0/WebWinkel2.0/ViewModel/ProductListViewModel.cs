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
//using WebWinkel2._0.Repositories;

namespace WebWinkel2._0.ViewModel
{
    public class ProductListViewModel : ViewModelBase
    {

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
             
              RaisePropertyChanged();
          }
      }

      DataContext db;

      //class constructor
      public ProductListViewModel()
      {

          db = new DataContext();

          SaveChanges = new RelayCommand(Save);
          AddNew = new RelayCommand(AddNewItem);
          DeleteSelected = new RelayCommand(Delete);
         
          var productLijst = db.Producten.ToList().Select(a => new ProductViewModel(a));
          Producten = new ObservableCollection<ProductViewModel>(productLijst);

          Afdelingen = new List<Afdeling>();
          foreach (Afdeling af in db.Afdelingen)
          {
              Afdelingen.Add(af);
          }

          SelectedProduct = new ProductViewModel();
      }

      public ICommand SaveChanges { get; set; }
      public ICommand AddNew { get; set; }
      public ICommand DeleteSelected { get; set; }

      public void Delete ()
      {
          db.Producten.Remove(SelectedProduct.Product);
          Producten.Remove(SelectedProduct);
          SelectedProduct = new ProductViewModel();
      }
        
      public void Save ()
      {
          db.SaveChanges();
      }

      private void AddNewItem()
      {
          if (SelectedProduct.ProductId <= 0)
          {
              ProductViewModel pvm = new ProductViewModel();

              pvm.Naam = SelectedProduct.Naam;
              pvm.Afdeling = SelectedProduct.Afdeling;

              Producten.Add(pvm);
              db.Producten.Add(pvm.Product);
          }
          else
          {
              this.SelectedProduct = new ProductViewModel();
          }
      }

      public List<Afdeling> Afdelingen { get; set; }
     
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

