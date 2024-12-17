using System.Windows;
using PokemonLike.Views;

namespace pokemon_like
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ouvre la vue de connexion et ferme la fenêtre principale.
        /// </summary>
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var loginView = new LoginView();
            loginView.Show();
            this.Close();
        }

        /// <summary>
        /// Ouvre la vue d'inscription et ferme la fenêtre principale.
        /// </summary>
        private void SignupButton_Click(object sender, RoutedEventArgs e)
        {
            var signupView = new SignupView();
            signupView.Show();
            this.Close();
        }

        /// <summary>
        /// Ouvre la vue des paramètres sans fermer la fenêtre principale.
        /// </summary>
        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            var settingsView = new SettingsView();
            settingsView.Show();
        }

        /// <summary>
        /// Gestionnaire pour le clic du bouton des paramètres (SettingsButton_Click).
        /// </summary>
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            var settingsView = new SettingsView();
            settingsView.Show();
        }
    }
}
