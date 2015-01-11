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

        private Edit_Product _EditProduct;
        private EditRecept _EditRecept;
        private EditMerk _EditMerk;
        private EditKorting _EditKorting;
        private EditEindproduct _EditEindproduct;
        private EditAfdeling _EditAfdeling;
      

        //add different icommands per window
        public ICommand ShowAfdelingWindowCommand { get; set; }
        public ICommand ShowProductWindowCommand { get; set; }
        public ICommand ShowEindproductWindowCommand { get; set; }
        public ICommand ShowMerkWindowCommand { get; set; }

        public ICommand ShowProductEditCommand { get; set; }
        public ICommand ShowMerkEditCommand { get; set; }
        public ICommand ShowKortingEditCommand { get; set; }
        public ICommand ShowReceptEditCommand { get; set; }
        public ICommand ShowAfdelingEditCommand { get; set; }
        public ICommand ShowEindproductEditCommand { get; set; }




        public WindowsViewModel()
        {
            _AfdelingWindow = new AfdelingWindow();
            _ProductWindow = new ProductWindow();
            _EindproductWindow = new EindproductWindow();
            _MerkWindow = new MerkWindow();

            _EditAfdeling = new EditAfdeling();
            _EditEindproduct = new EditEindproduct();
            _EditKorting = new EditKorting();
            _EditMerk = new EditMerk();
            _EditRecept = new EditRecept();
            _EditProduct = new Edit_Product();

            ShowAfdelingWindowCommand = new RelayCommand(showAfdelingWindow, canShowAfdelingWindow);
            ShowProductWindowCommand = new RelayCommand(showProductWindow, canShowProductWindow);
            ShowEindproductWindowCommand = new RelayCommand(showEindproductWindow, canShowEindproductWindow);
            ShowMerkWindowCommand = new RelayCommand(showMerkWindow, canShowMerkWindow);

            ShowMerkEditCommand = new RelayCommand(showMerkEdit, canShowMerkEdit);
            ShowAfdelingEditCommand = new RelayCommand(showAfdelingEdit, canShowAfdelingEdit);
            ShowEindproductEditCommand = new RelayCommand(showEindproductEdit, canShowEindproductEdit);
            ShowKortingEditCommand = new RelayCommand(showKortingEdit, canShowKortingEdit);
            ShowReceptEditCommand = new RelayCommand(showReceptEdit, canShowReceptEdit);
            ShowProductEditCommand = new RelayCommand(showProductEdit, canShowProductEdit);
        }






        //methods that get called when the command is called

        #region EditProduct
        private void showProductEdit()
        {
            try { _EditProduct.Show(); }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                _EditProduct = new Edit_Product();
                _EditProduct.InitializeComponent();
                _EditProduct.Show();
            }

        }

        private bool canShowProductEdit()
        {
            return _EditProduct.IsVisible == false;
        }
        #endregion

        #region EditRecept
        private void showReceptEdit()
        {
            try { _EditRecept.Show(); }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                _EditRecept = new EditRecept();
                _EditRecept.InitializeComponent();
                _EditRecept.Show();
            }

        }

        private bool canShowReceptEdit()
        {
            return _EditRecept.IsVisible == false;
        }
        #endregion

        #region EditMerk
        private void showMerkEdit()
        {
            try { _EditMerk.Show(); }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                _EditMerk = new EditMerk();
                _EditMerk.InitializeComponent();
                _EditMerk.Show();
            }

        }

        private bool canShowMerkEdit()
        {
            return _EditMerk.IsVisible == false;
        }
        #endregion

        #region EditKorting
        private void showKortingEdit()
        {
            try { _EditKorting.Show(); }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                _EditKorting = new EditKorting();
                _EditKorting.InitializeComponent();
                _EditKorting.Show();
            }

        }

        private bool canShowKortingEdit()
        {
            return _EditKorting.IsVisible == false;
        }
        #endregion

        #region EditEindproduct
        private void showEindproductEdit()
        {
            try { _EditEindproduct.Show(); }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                _EditEindproduct = new EditEindproduct();
                _EditEindproduct.InitializeComponent();
                _EditEindproduct.Show();
            }

        }

        private bool canShowEindproductEdit()
        {
            return _EditEindproduct.IsVisible == false;
        }
        #endregion

        #region EditAfdeling
        private void showAfdelingEdit()
        {
            try { _EditAfdeling.Show(); }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                _EditAfdeling = new EditAfdeling();
                _EditAfdeling.InitializeComponent();
                _EditAfdeling.Show();
            }

        }

        private bool canShowAfdelingEdit()
        {
            return _EditAfdeling.IsVisible == false;
        }
        #endregion


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
