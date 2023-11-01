using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using static Gestion_Ecole.classDonnées;

namespace Gestion_Ecole
{
    /// <summary>
    /// Logique d'interaction pour Programme.xaml
    /// </summary>
    public partial class Programme : Page
    {
       
        public Programme()
        {
            InitializeComponent();
           
            affichageDeLaListeProgramme();
            
        }

        private void accepterQueLesChiffres(object sender, TextCompositionEventArgs e)
        {

            e.Handled = !char.IsDigit(e.Text, e.Text.Length - 1);
        }

        private void accepterQueLesLettres(object sender, TextCompositionEventArgs e)
        {

            if (!Regex.IsMatch(e.Text, "^[a-zA-ZÀ-ÖØ-öø-ÿ.'´`]+$"))
            {
                e.Handled = true;
            }
        }

        private void ajoutProgramme_a_LaListe(object sender, RoutedEventArgs e) 
        {
            try
            {
                string nomProgrammes = nomProgramme.Text;
                int numeroProgrammes = int.Parse(numeroProgramme.Text);
                int dureeProgrammes = int.Parse(duréé.Text);
                classDonnées.programme ObjetProgramme = new classDonnées.programme(numeroProgrammes, dureeProgrammes, nomProgrammes);
                classDonnées.programmeList.Add(ObjetProgramme);
                affichageProgrammes.Text = "";
                affichageDeLaListeProgramme();
                Etudiant etudiantPage = new Etudiant();
                etudiantPage.RemplirLaDropListeProgramme();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message + " Vous avez laissé des champs vides"); }

        }
        private void Etudiant(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new Etudiant());
        }

        private void Consultation(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new Consultation());
        }

        private void affichageDeLaListeProgramme()
        {
            affichageProgrammes.Text = string.Join("\n", classDonnées.programmeList.Select(p => p.affichageProgramme()));
            

        }


        private void home(object sender, MouseButtonEventArgs e)
        {

            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;


            mainWindow.mainFrame.Content = null;


            mainWindow.acceuil.Visibility = Visibility.Visible;

        }
    }
}
