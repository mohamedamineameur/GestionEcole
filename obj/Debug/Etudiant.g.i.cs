﻿#pragma checksum "..\..\Etudiant.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7426391EB11992EA17630A8DAFF41D5E7F6D94244661E8C041FC6B88EF946480"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Gestion_Ecole;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Gestion_Ecole {
    
    
    /// <summary>
    /// Etudiant
    /// </summary>
    public partial class Etudiant : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\Etudiant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nomPrenom;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Etudiant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numero;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Etudiant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sexe;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Etudiant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateDeNaissance;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Etudiant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox programme;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\Etudiant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock affichageEtudiant;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Gestion_Ecole;component/etudiant.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Etudiant.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nomPrenom = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\Etudiant.xaml"
            this.nomPrenom.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.accepterQueLesLettres);
            
            #line default
            #line hidden
            return;
            case 2:
            this.numero = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\Etudiant.xaml"
            this.numero.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.accepterQueLesChiffres);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sexe = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.dateDeNaissance = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.programme = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 54 "..\..\Etudiant.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ajoutEtudiant_a_LaListe);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 81 "..\..\Etudiant.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.home);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 119 "..\..\Etudiant.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Programme);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 157 "..\..\Etudiant.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Consultation);
            
            #line default
            #line hidden
            return;
            case 10:
            this.affichageEtudiant = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

