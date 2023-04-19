using ArtGalleryApplication.DBEntity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ArtGalleryApplication.ViewModel
{
    public class TablePanelViewModel : BaseViewModel
    {
        
        private ObservableCollection<PieceOfArt> _pieceOfArts;
        private ObservableCollection<string> _material;
        private ObservableCollection<string> _genre;
        private ObservableCollection<string> _artist;
        private ObservableCollection<string> _stile;
        private ObservableCollection<string> _technique;
        private ObservableCollection<string> _pieceOfArtHasStile;
        private ObservableCollection<string> _pieceOfArtHasMaterial;
        private ObservableCollection<string> _pieceOfArtHasGenre;
        private ObservableCollection<string> _pieceOfArtHasTechnique;
        private ObservableCollection<string> _description;
        private PieceOfArt _selectedPieceOfArt;
        private User1 _user1;
        private PieceOfArt _addPieceOfArt;


        public ObservableCollection<PieceOfArt> PieceOfArts
        {
            get => _pieceOfArts;
            set
            {
                _pieceOfArts = value;
                OnPropertyChanged(nameof(PieceOfArt));
            }
        }

        public ObservableCollection<string> Artist
         {
             get => _artist;
             set
             {
                 _artist = value;
                 OnPropertyChanged(nameof(Artist));
             }
         }

        public ObservableCollection<string> Material
        {
            get => _material;
            set
            {
                _material = value;
                OnPropertyChanged(nameof(Material));
            }
        }

        public ObservableCollection<string> Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public ObservableCollection<string> Genre
        {
            get => _genre;
            set
            {
                _genre = value;
                OnPropertyChanged(nameof(Genre));
            }
        }

        public ObservableCollection<string> Technique
        {
            get => _technique;
            set
            {
                _technique = value;
                OnPropertyChanged(nameof(Technique));
            }
        }

        public ObservableCollection<string> Stile
        {
            get => _stile;
            set
            {
                _stile = value;
                OnPropertyChanged(nameof(Stile));
            }
        }

        public ObservableCollection<string> PieceOfArtHasGenre
        {
            get => _pieceOfArtHasGenre;
            set
            {
                _pieceOfArtHasGenre = value;
                OnPropertyChanged(nameof(PieceOfArtHasGenre));
            }
        }


        public ObservableCollection<string> PieceOfArtHasMaterial
        {
            get => _pieceOfArtHasMaterial;
            set
            {
                _pieceOfArtHasMaterial = value;
                OnPropertyChanged(nameof(PieceOfArtHasMaterial));
            }
        }

        public ObservableCollection<string> PieceOfArtHasStile
        {
            get => _pieceOfArtHasStile;
            set
            {
                _pieceOfArtHasStile = value;
                OnPropertyChanged(nameof(PieceOfArtHasStile));
            }
        }
        public ObservableCollection<string> PieceOfArtHasTechnique
        {
            get => _pieceOfArtHasTechnique;
            set
            {
                _pieceOfArtHasTechnique = value;
                OnPropertyChanged(nameof(PieceOfArtHasTechnique));
            }
        }

        public PieceOfArt AddPieceOfArt
        {
            get => _addPieceOfArt;
            set
            {
                _addPieceOfArt = value;
                OnPropertyChanged(nameof(AddPieceOfArt));
            }
        }

        public PieceOfArt SelectedPieceOfArt
        {
            get => _selectedPieceOfArt;
            set
            {
                _selectedPieceOfArt = value;
                OnPropertyChanged(nameof(SelectedPieceOfArt));
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
            if (PieceOfArts.Count > 0)
            {
                PieceOfArts.Clear();
            }
            var pieceOfArtList = DbStorage.DB_s.PieceOfArt.ToList();
            pieceOfArtList.ForEach(element => PieceOfArts?.Add(element));
        }


        public void LoadComboBoxData()
        {
            if (Artist.Count > 0)
            {
                Artist.Clear();
            }
            var artistList = DbStorage.DB_s.Artist.ToList();
            artistList.ForEach(element => Artist?.Add(element.FIO));

            if (Material.Count > 0)
            {
                Material.Clear();
            }
            var materialList = DbStorage.DB_s.Material.ToList();
            materialList.ForEach(element => Material?.Add(element.MaterialName));

            if (Stile.Count > 0)
            {
                Stile.Clear();
            }
            var stileList = DbStorage.DB_s.Stile.ToList();
            stileList.ForEach(element => Stile?.Add(element.StileName));

            if (Genre.Count > 0)
            {
                Genre.Clear();
            }
            var genreList = DbStorage.DB_s.Genre.ToList();
            genreList.ForEach(element => Genre?.Add(element.GenreName));

            if (Technique.Count > 0)
            {
                Technique.Clear();
            }
            var techniqueList = DbStorage.DB_s.Technique.ToList();
            techniqueList.ForEach(element => Technique?.Add(element.TechniqueName));


           

        }

       /* public AddPieceOfArtDB()
        {
            using (var db = new TradeEntityes())
            { }
        }*/


        public void DeleteSelectedInfo()
        {
            if (!(SelectedPieceOfArt is null))
            {
                using (var db = new ArtGalleryEntities())
                {
                    var result = MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Удаление",
                        MessageBoxButton.YesNo, MessageBoxImage.Hand);

                    if (result == MessageBoxResult.Yes)
                    {
                        try
                        {
                            var infoForDelete = db.PieceOfArt.Where(elem => elem.ID == SelectedPieceOfArt.ID).FirstOrDefault();
                            db.PieceOfArt.Remove(infoForDelete);
                            db.SaveChanges();
                            LoadData();
                            MessageBox.Show("Данные успешно удалены!", "Удаление", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "Удаление", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
        }




      /*  private StringBuilder ValidateEntity()
        {
            var errors = new StringBuilder();
            if (_addPieceOfArt != null)
            {
                if (string.IsNullOrEmpty(AddPieceOfArt.ID))
                {
                    errors.AppendLine("Поле не может быть ID пустым");
                }
            }
        }*/

        public TablePanelViewModel(User1 user1)
        {
            PieceOfArts = new ObservableCollection<PieceOfArt>();
            Artist = new ObservableCollection<string>();
            Material = new ObservableCollection<string>();
            Genre = new ObservableCollection<string>();
            Technique = new ObservableCollection<string>();
            Stile = new ObservableCollection<string>();
            User1 = user1;
            AddPieceOfArt = new PieceOfArt();
           /* AddPieceOfArt.PieceOfArtHasMaterial = 0;
            AddPieceOfArt.PieceOfArtHasGenre = 0;
            AddPieceOfArt.PieceOfArtHasStile = 0;
            AddPieceOfArt.PieceOfArtHasTechnique = 0;*/
            SelectedPieceOfArt = new PieceOfArt();
            LoadData();
            LoadComboBoxData();
            
        }


    }
}
