using System;
using System.Windows;

namespace Lab2Web
{
    /// <summary>
    /// Lógica de interacción para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (username == "user" && password == "123456")
            {
                
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close(); 
            }
            else
            {
                
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
