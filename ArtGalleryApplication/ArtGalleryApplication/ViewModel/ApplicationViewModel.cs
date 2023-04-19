using ArtGalleryApplication.DBEntity;
using ArtGalleryApplication.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ArtGalleryApplication.ViewModel
{
    internal class ApplicationViewModel : BaseViewModel 
    {
        private ObservableCollection<PieceOfArt> _pieceOfArts;

        private User1 _user1;

        public ObservableCollection<PieceOfArt> PieceOfArts
        {
            get => _pieceOfArts;
            set
            {
                _pieceOfArts = value;
                OnPropertyChanged(nameof(PieceOfArts));
            }
        }

        public User1 User1
        { 
            get => _user1;
            set
            {
                _user1 = value;
                OnPropertyChanged(nameof(User1));
            }
        }

       


        public void LoadData()
        {
            var pieceOfArtList = DbStorage.DB_s.PieceOfArt.ToList();
            pieceOfArtList.ForEach(element=>PieceOfArts?.Add(element));
        }

      /*  public void CheckAdmin()
        {
            return User1.UserInfo.Role.ID == 2;
        }*/

        public void OpenTablePanel()
        {
            var tablePanel = new TablePanelWindow(User1);
            tablePanel.Show();
        }

        public ApplicationViewModel(User1 user1)
        {
            PieceOfArts = new ObservableCollection<PieceOfArt>();
            User1 = user1;
          /* if (CheckAdmin())
            {
                OpenTablePanel();
            }*/
            LoadData();
        }

      /*  private int _picture;
        private string _nameOfArt;
        private int _years;
        private int _artist;
        private string _description; 
       
       
        


        public PieceOfArt SelectedPieceOfArt
        {
            get => _selectedPieceOfArt;
            set
            {
                _selectedPieceOfArt = value;
                OnPropertyChanged(nameof(SelectedPieceOfArt));
            }
        }

       public int Picture
        {
            get => _picture;

            set
            {
                _picture = value;
                OnPropertyChanged(nameof(Picture));
            }
        }

        public string NameOfArt
        {
            get => _nameOfArt;

            set
            {
                _nameOfArt = value;
                OnPropertyChanged(nameof(NameOfArt));
            }
        }


        public int Years
        {
            get => _years;

            set
            {
                _years = value;
                OnPropertyChanged(nameof(Years));
            }
        }


        public int Artist
        {
            get => _artist;

            set
            {
                _artist = value;
                OnPropertyChanged(nameof(Artist));
            }
        }

        public string Description
        {
            get => _description;

            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }  


        public ApplicationViewModel(User1 user1)
        {
            //PaintingTitle = paint.UserInfo.PaintingTitle;
          //  Years = (int)paint.UserInfo.Years;
           // ArtistName = paint.UserInfo.ArtistName;
           // Direction = paint.UserInfo.Direction;
           // PieceOfArt = new ObservableCollection<PieceOfArt>();
            LoadData();

        }*/

       




    }
}