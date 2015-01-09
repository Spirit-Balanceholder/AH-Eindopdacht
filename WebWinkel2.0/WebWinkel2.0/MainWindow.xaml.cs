using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebWinkel2._0.Model;

namespace WebWinkel2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            // create new Student entity object in disconnected scenario (out of the scope of DbContext)
             Boodschappenlijst bs = new Boodschappenlijst();
            Merk m = new Merk();
            m.MerkNaam = "peop";
           
             Eindproduct ep = new Eindproduct();
             ep.Merk = m;
             ep.BoodschappenlijstID = 1;
            


            //create DBContext object
            using (var dbCtx = new DataContext())
            {
                //Add Student object into Students DBset
                 //dbCtx.Boodschappenlijst.Add(bs);
                 dbCtx.Merken.Add(m);
                 dbCtx.Eindproducten.Add(ep);
                

                

       
                
               // dbCtx.Boodschappenlijst.Add();
                // call SaveChanges method to save student into database
                dbCtx.SaveChanges();



            }


            InitializeComponent();
        }
    }
}
