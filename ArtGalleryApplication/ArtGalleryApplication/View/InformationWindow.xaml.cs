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
    /// Логика взаимодействия для InformationWindow.xaml
    /// </summary>
    public partial class InformationWindow : Window
    {
        public InformationWindow(User1 user1)
        {
            InitializeComponent();

            //  ArtInfoDataGrid.ItemsSource = ArtGalleryEntities.GetContext().PieceOfArt.ToList();

            this.DataContext = new ApplicationViewModel(user1);


        }


        public void RefreshData()
        {
            (DataContext as ApplicationViewModel).LoadData();
        }
    }
}
