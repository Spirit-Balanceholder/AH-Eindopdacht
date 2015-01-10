using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WebWinkel2._0.Views;

namespace WebWinkel2._0.ViewModel
{//this class is added for the purpose of navigation trough all windows. 
  public  class WindowsViewModel : ViewModelBase
    {
        //private references to all windows
        private AfdelingWindow _AfdelingWindow;
        private ProductWindow _ProductWindow;
       
      //add different icommands per window
        public ICommand ShowAfdelingWindowCommand { get; set; }
        public ICommand ShowProductWindowCommand { get; set; }

        public WindowsViewModel()
        {
            _AfdelingWindow = new AfdelingWindow();
            _ProductWindow = new ProductWindow();

            ShowAfdelingWindowCommand = new RelayCommand(showAfdelingWindow, canShowAfdelingWindow);
            ShowProductWindowCommand = new RelayCommand(showProductWindow, canShowProductWindow);
        }






        //methods that get called when the command is called
        #region afdeling
        private void showAfdelingWindow()
        {
            try { _AfdelingWindow.Show(); }
            catch(Exception e)
            {

                Console.WriteLine(e.Message);
                _AfdelingWindow = new AfdelingWindow();
                _AfdelingWindow.InitializeComponent();
                _AfdelingWindow.Show();
            }
           
        }

        private bool canShowAfdelingWindow()
        {
            return _AfdelingWindow.IsVisible == false;
        }
        #endregion

        #region product
        private void showProductWindow()
        {
            try {_ProductWindow.Show(); }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                _ProductWindow = new ProductWindow();
               _ProductWindow.InitializeComponent();
                _ProductWindow.Show();
            }

        }

        private bool canShowProductWindow()
        {
            return _ProductWindow.IsVisible == false;
        }
        #endregion




    }
}
