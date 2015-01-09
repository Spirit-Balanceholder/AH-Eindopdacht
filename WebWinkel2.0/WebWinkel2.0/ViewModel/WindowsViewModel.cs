using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WebWinkel2._0.ViewModel
{//this class is added for the purpose of navigation trough all windows. 
  public  class WindowsViewModel : ViewModelBase
    {
        //private references to all windows
        private AfdelingWindow _AfdelingWindow;
       
      //add different icommands per window
        public ICommand ShowAfdelingWindowCommand { get; set; }

        public WindowsViewModel()
        {
            _AfdelingWindow = new AfdelingWindow();
           

            ShowAfdelingWindowCommand = new RelayCommand(showAfdelingWindow, canShowAfdelingWindow);
           
        }


        private bool canShowAfdelingWindow()
        {
            return _AfdelingWindow.IsVisible == false;
        }

        private void showAfdelingWindow()
        {
            _AfdelingWindow.Show();
        }


      



    }
}
