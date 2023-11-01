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

namespace Gestion_Ecole
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Etudiant(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Content = new Etudiant();
            acceuil.Visibility = Visibility.Collapsed;
        }
        public void Programme(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Content = new Programme();
            acceuil.Visibility = Visibility.Collapsed;
        }
        public void Consultation(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Content = new Consultation();
            acceuil.Visibility = Visibility.Collapsed;
        }
    }
}
