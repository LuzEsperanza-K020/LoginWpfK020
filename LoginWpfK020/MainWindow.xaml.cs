using LoginWpfK020.negocio;
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

namespace LoginWpfK020
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private LoginService login = new LoginService();
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Password;
           
            if (login.checkArchivoTexto (username, password))
            {
                //salidaLabel.Content = "Usuario logeado";
                //MessageBox.Show("Exito!!", "Usuario logeado");
                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
                ventanaPrincipal.Show();
                this.Close();
                //this.Hide();
            }
            else
            {
                //salidaLabel.Content = "Usuario o password incorrectos";
                MessageBox.Show("Error de login", "Usuario o password incorrecto");
            }
        }
        
    }

}
