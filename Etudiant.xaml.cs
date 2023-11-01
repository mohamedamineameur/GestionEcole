using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Gestion_Ecole
{
    /// <summary>
    /// Logique d'interaction pour Etudiant.xaml
    /// </summary>
    public partial class Etudiant : Page
    {
       
        
      
        List<string> ListeDeProgrammeFormatString = new List<string>();

        public Etudiant()
        {
            InitializeComponent();
            ListeDeProgrammeFormatString.Clear();


            RemplirLaDropListeProgramme();
            affichageDeLaListeEtudiant();
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

        public void RemplirLaDropListeProgramme()
        {


            ListeDeProgrammeFormatString = classDonnées.programmeList.Select(p => p.getNom()).ToList();
            programme.ItemsSource = ListeDeProgrammeFormatString;
        }
        private void ajoutEtudiant_a_LaListe(object sender, RoutedEventArgs e)
        {
            try
            {
                string nomEtudiant = nomPrenom.Text;
                string sexeEtudiant = sexe.Text;
                string dateEtudiant = dateDeNaissance.Text;
                string ProgrammeFormatString = programme.Text;
                classDonnées.programme ObjetProgramme = classDonnées.programmeList[ListeDeProgrammeFormatString.IndexOf(ProgrammeFormatString)];
                int numeroEtudiant = int.Parse(numero.Text);
                classDonnées.etudiant ObjetEtudiant = new classDonnées.etudiant(nomEtudiant, sexeEtudiant, numeroEtudiant, ObjetProgramme, dateEtudiant);
                classDonnées.etudiantListe.Add(ObjetEtudiant);
                affichageEtudiant.Text = "";
                affichageDeLaListeEtudiant();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message+" Vous avez laissé des champs vides."); }
            
        }

        private void affichageDeLaListeEtudiant()
        {
            
            for(int i=0;i< classDonnées.etudiantListe.Count;i++)
            {
                affichageEtudiant.Text = affichageEtudiant.Text + classDonnées.etudiantListe[i].affichageInformationEtudiant() + "\n";
            }
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

        private void Consultation(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new Consultation());
        }



    }

}
