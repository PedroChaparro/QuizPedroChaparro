using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizPedroChaparro
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            string select = "";

            //CÓDIGO PARA LA SELECCIÓN DE LA PRIMERA OPCIÓN, a = Desktop - Laptop

            string a = "";

            if (chkDesktop.IsChecked == true && chkLaptop.IsChecked == true)
            {
                a = "Desktop and Laptop";
            }
            else if (chkDesktop.IsChecked == true) {
                a = "Desktop";
            }
            else
            {
                a = "Laptop";
            }


            //CÓDIGO PARA LA SELECICÓN DE LA SEGUNDA OPCIÓN, b = PC PERFORMANCE

            string b = cmbPerformance.Text;

            //CÓDIGO PARA LA SELECCIÓN DE LA TERCERA OPCIÓN, PRECIO MÁXIMO

            double c1 = sldPrice.Value;
            c1 = Math.Round(c1);

            string c = c1.ToString();

            //CÓDIGO PARA MOSTRAR RESULTADOS

            txtResults.Text = txtResults.Text + "\n" + a + "\n" + b + "\n" + c + "\n";

        }

        //BOTÓN LOGOUT

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Login());
        }
    }
}
