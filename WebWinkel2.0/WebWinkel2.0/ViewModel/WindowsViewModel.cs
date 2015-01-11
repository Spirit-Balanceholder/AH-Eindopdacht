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
    public class WindowsViewModel : ViewModelBase
    {
        //private references to all windows
        private AfdelingWindow _AfdelingWindow;
        private ProductWindow _ProductWindow;
        private EindproductWindow _EindproductWindow;
        private MerkWindow _MerkWindow;
      

        //add different icommands per window
        public ICommand ShowAfdelingWindowCommand { get; set; }
        public ICommand ShowProductWindowCommand { get; set; }

        public ICommand ShowEindproductWindowCommand { get; set; }

        public ICommand ShowMerkWindowCommand { get; set; }





        public WindowsViewModel()
        {
            _AfdelingWindow = new AfdelingWindow();
            _ProductWindow = new ProductWindow();
            _EindproductWindow = new EindproductWindow();
            _MerkWindow = new MerkWindow();


            ShowAfdelingWindowCommand = new RelayCommand(showAfdelingWindow, canShowAfdelingWindow);
            ShowProductWindowCommand = new RelayCommand(showProductWindow, canShowProductWindow);
            ShowEindproductWindowCommand = new RelayCommand(showEindproductWindow, canShowEindproductWindow);
            ShowMerkWindowCommand = new RelayCommand(showMerkWindow, canShowMerkWindow);

        }






        //methods that get called when the command is called
        #region afdeling
        private void showAfdelingWindow()
        {
            try { _AfdelingWindow.Show(); }
            catch (Exception e)
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
            try { _ProductWindow.Show(); }
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

        #region Eindproduct
        private void showEindproductWindow()
        {
            try { _EindproductWindow.Show(); }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                _EindproductWindow = new EindproductWindow();
                _EindproductWindow.InitializeComponent();
                _EindproductWindow.Show();

            }

        }

        private bool canShowEindproductWindow()
        {
            return _EindproductWindow.IsVisible == false;
        }
        #endregion

        #region Merk
        private void showMerkWindow()
        {
            try { _MerkWindow.Show(); }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                _MerkWindow = new MerkWindow();
                _MerkWindow.InitializeComponent();
                _MerkWindow.Show();



            }

        }

        private bool canShowMerkWindow()
        {
            return _MerkWindow.IsVisible == false;
        }
        #endregion

    }
}
