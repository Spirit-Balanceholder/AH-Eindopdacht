/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:WebWinkel2._0"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace WebWinkel2._0.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            //register our LVM'S
            SimpleIoc.Default.Register<AfdelingListViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<WindowsViewModel>();
            SimpleIoc.Default.Register<ProductListViewModel>();
            SimpleIoc.Default.Register<EindproductListViewModel>();
            SimpleIoc.Default.Register<MerkListViewModel>();
            SimpleIoc.Default.Register<ReceptListViewModel>();
            # region designmode
            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

#endregion
                       
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This non-static member is needed for data binding purposes.")]
        public AfdelingListViewModel AfdelingListViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AfdelingListViewModel>();
            }
        }

        public WindowsViewModel Manager
        {
            get
            {
                return ServiceLocator.Current.GetInstance<WindowsViewModel>();
            }
        }

        public ProductListViewModel ProductListViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ProductListViewModel>();
            }
        }

        public EindproductListViewModel EindproductListViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EindproductListViewModel>();
            }
        }

        public MerkListViewModel MerkListViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MerkListViewModel>();
            }
        }

        public ReceptListViewModel ReceptListViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ReceptListViewModel>();
            }
        }


        public static void Cleanup()
        {

            //clean LVM references (or don't)
        }










        //public MainViewModel Main
        //{
        //    get
        //    {
        //        return ServiceLocator.Current.GetInstance<MainViewModel>();
        //    }
        //}
        
     
    }
}