using ArtGalleryApplication.DBEntity;
using ArtGalleryApplication.ViewModel;
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
using System.Windows.Shapes;

namespace ArtGalleryApplication.View
{
    /// <summary>
    /// Логика взаимодействия для TablePanelWindow.xaml
    /// </summary>
    public partial class TablePanelWindow : Window
    {
        //    mklmk       malochokolada

        public TablePanelWindow(User1 user1)
        {
            InitializeComponent();

            //  ArtInfoDataGrid.ItemsSource = ArtGalleryEntities.GetContext().PieceOfArt.ToList();

        // this.DataContext = new ApplicationViewModel(user1); 

            DataContext = new TablePanelViewModel(user1);
          /*  foreach (var item in App.Current.Windows)
            {
                if (item is MainWindow)
                {
                    this.Owner = item as Window;
                }
            }*/
           
        }
        

       /* public void RefreshData()
        {
            (DataContext as ApplicationViewModel).LoadData();
        }*/

        private void btnAddNewInfo_Click(object sender, RoutedEventArgs e)
        {
            /* switch ((sender as Button).Content)
             {

             }*/
            //(DataContext as TablePanelViewModel).AddPieceOfArt();
        }
    }
}