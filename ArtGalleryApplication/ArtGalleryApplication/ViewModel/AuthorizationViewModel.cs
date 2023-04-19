using ArtGalleryApplication.DBEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ArtGalleryApplication.ViewModel
{

    public class AuthorizationViewModel : BaseViewModel
    {
        private string _buttonSignIn = "Войти";

        private string _userLogin;
        private string _userPassword;
        private User1 _user1;

        public string Login
        {
            get => _userLogin;
            set
            {
                _userLogin = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public string Password
        {
            get => _userPassword;
            set
            {
                _userPassword = value;
                OnPropertyChanged(nameof(Password));
            }

        }


        public string ButtonSignIn
        {
            get => _buttonSignIn;
            set
            {
                _buttonSignIn = value;
                OnPropertyChanged(nameof(ButtonSignIn));
            }
        }

        private async Task<bool> Authorize(string userLogin, string userPassword)
        {
            try
            {
                var result = await DbStorage.DB_s.User1.FirstOrDefaultAsync(_user1 => _user1.UserLogin == userLogin &&
                            _user1.UserPassword == userPassword);

                _user1 = result;

                if (result != null)
                {
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Необработанное исключение",
                        MessageBoxButton.OK, MessageBoxImage.Stop);

                return false;
            }

        }

        public async void AuthInApp() 
        {
            ButtonSignIn = "Подождите...";

            if (await Authorize(Login, Password))
            {
                var tableWindow = new View.TablePanelWindow(_user1);//_user?? TablePanelWindow

                tableWindow.Show();

                foreach (var item in App.Current.Windows)
                {
                    if (item is MainWindow)
                    {
                        (item as Window)?.Hide();
                    }
                }
                return;
            }

            MessageBox.Show("Неверный логин или пароль", "Авторизация",
                    MessageBoxButton.OK, MessageBoxImage.Error);

        }



    }
}
