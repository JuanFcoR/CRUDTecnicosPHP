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

namespace Enel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool estado = false;
        string locate = System.Reflection.Assembly.GetExecutingAssembly().Location.ToString();
        public MainWindow()
        {


            InitializeComponent();
            estado = false;
            this.ReproducirBtn.Visibility = Visibility.Visible;
            this.Pausar.Visibility = Visibility.Collapsed;
            int num = locate.IndexOf("bin");
            string subCad = locate.Substring(0, num);
            string cad = subCad + ("Videos\\enel1.mp4");
            MyVideo.Source = new Uri(cad, UriKind.Absolute);



        }



        private void Reproducir_Pausa(object sender, RoutedEventArgs e)
        {
            try
            {

                MyVideo.Play();
                estado = true;

                ReproducirBtn.Visibility = Visibility.Collapsed;
                Pausar.Visibility = Visibility.Visible;


            }
            catch (Exception)
            {
                MessageBox.Show("Ni idea");
                throw;
            }

        }

        private void DetenerBtn_Click(object sender, RoutedEventArgs e)
        {
            //Se me ocurrio una idea vacana de 2 botntones xd, cuando se active uno, sedesactiva otro
            MyVideo.Stop();
            estado = false;
            ReproducirBtn.Visibility = Visibility.Visible;
            Pausar.Visibility = Visibility.Collapsed;


        }

        private void Pausar_Click(object sender, RoutedEventArgs e)
        {
            MyVideo.Pause();
            estado = false;
            ReproducirBtn.Visibility = Visibility.Visible;
            Pausar.Visibility = Visibility.Collapsed;

        }
    }
}

