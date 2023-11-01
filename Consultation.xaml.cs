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
    /// Logique d'interaction pour Consultation.xaml
    /// </summary>
    public partial class Consultation : Page
    {
        List<string> ListeDeProgrammeFormatString = new List<string>();

        
        public Consultation()
        {
            InitializeComponent();
            RemplirLaDropListeProgramme();
            listeProgramme.Visibility = Visibility.Collapsed;
            typeAffichage2.Visibility = Visibility.Collapsed;


        }

        private void MaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            ComboBox comboBox = sender as ComboBox; 
            ComboBoxItem selectedItem = comboBox.SelectedItem as ComboBoxItem;  
           
            if (selectedItem.Content.ToString().Trim() == "La liste complete des étudiants")
            {
                 
                listeProgramme.Visibility = Visibility.Collapsed;
                typeAffichage2.Visibility = Visibility.Collapsed;
            }
            else if(selectedItem.Content.ToString().Trim() == "Par programme") {  


                listeProgramme.Visibility = Visibility.Visible; typeAffichage2.Visibility = Visibility.Visible;
            } 
        }


        private void Etudiant(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new Etudiant());
        }

        private void Programme(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new Programme());
        }

        private void home(object sender, MouseButtonEventArgs e)
        {

            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;


            mainWindow.mainFrame.Content = null;


            mainWindow.acceuil.Visibility = Visibility.Visible;

        }

        private void accepterQueLesChiffress(object sender, TextCompositionEventArgs e)
        {

            e.Handled = !char.IsDigit(e.Text, e.Text.Length - 1);
        }

        private void accepterQueLesLettress(object sender, TextCompositionEventArgs e)
        {

            if (!Regex.IsMatch(e.Text, "^[a-zA-ZÀ-ÖØ-öø-ÿ.'´`]+$"))
            {
                e.Handled = true;
            }
        }

        private void afficherListe(object sender, RoutedEventArgs e)
        {
            affichageEtudiant.Text = "";
            if(listeProgramme.Visibility == Visibility.Collapsed)
            {
                for (int i = 0; i < classDonnées.etudiantListe.Count; i++)
                {
                    affichageEtudiant.Text = affichageEtudiant.Text + classDonnées.etudiantListe[i].affichageInformationEtudiant() + "\n";
                }

            }
            else
            {
                for (int i = 0; i < classDonnées.etudiantListe.Count; i++)
                {
                    if (classDonnées.etudiantListe[i].ProgrammeEtudiant.NomDuProgramme== listeProgramme.Text)
                    {
                        affichageEtudiant.Text = affichageEtudiant.Text + classDonnées.etudiantListe[i].affichageInformationEtudiant() + "\n";
                    }
                }

            }
           
        }

       


        public void RemplirLaDropListeProgramme()
        {


            ListeDeProgrammeFormatString = classDonnées.programmeList.Select(p => p.getNom()).ToList();
            listeProgramme.ItemsSource = ListeDeProgrammeFormatString;
        }
    }
}
