using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole
{
    public static class classDonnées
    {

        public class programme
        {
            private int numeroDuProgramme;

            private int dureeDuProgramme;

            private string nomDuProgramme;
            public global::System.Int32 NumeroDuProgramme { get => numeroDuProgramme; set => numeroDuProgramme = value; }
            public global::System.Int32 DureeDuProgramme { get => dureeDuProgramme; set => dureeDuProgramme = value; }
            public global::System.String NomDuProgramme { get => nomDuProgramme; set => nomDuProgramme = value; }

            public programme(int numeroDuProgramme, int dureeDuProgramme, string nomDuProgramme)
            {
                this.nomDuProgramme = nomDuProgramme;
                this.numeroDuProgramme = numeroDuProgramme;
                this.dureeDuProgramme = dureeDuProgramme;
            }

            public string getNom()
            {
                return (this.nomDuProgramme).ToString();
            }
            public string affichageProgramme()
            {
                return (this.nomDuProgramme + ", Numero du programme: " + this.NumeroDuProgramme + ", durée du programme: " + this.dureeDuProgramme + " mois").ToString();
            }
        }


        public class etudiant
        {
            private string nomEtPrenom;
            private string sexe;
            private int numeroEtudiant;
            private programme programmeEtudiant;
            private string dateDeNaissance;

            public global::System.String NomEtPrenom { get => nomEtPrenom; set => nomEtPrenom = value; }
            public global::System.String Sexe { get => sexe; set => sexe = value; }
            public global::System.Int32 NumeroEtudiant { get => numeroEtudiant; set => numeroEtudiant = value; }
            public programme ProgrammeEtudiant { get => programmeEtudiant; set => programmeEtudiant = value; }
            public global::System.String DateDeNaissance { get => dateDeNaissance; set => dateDeNaissance = value; }

            public etudiant() { }
            public etudiant(string nomEtPrenom, string sexe, int numeroEtudiant, programme programmeEtudiant, string dateDeNaissance)
            {
                this.nomEtPrenom = nomEtPrenom;
                this.sexe = sexe;
                this.numeroEtudiant = numeroEtudiant;
                this.programmeEtudiant = programmeEtudiant;
                this.dateDeNaissance = dateDeNaissance;
            }
            public string affichageInformationEtudiant() {


                return this.nomEtPrenom + " " + this.sexe + " " + this.dateDeNaissance + " " + this.numeroEtudiant + " " + this.programmeEtudiant.getNom();
            }
        }


        public static List<programme> programmeList = new List<programme>();
        public static List<etudiant> etudiantListe = new List<etudiant>();
        public static programme p1 = new programme(1, 24, "info");
        public static programme p2 = new programme(2, 12, "math");

        static classDonnées(){
            programmeList.Add(p1);
            programmeList.Add(p2);
        }

        
}
}
