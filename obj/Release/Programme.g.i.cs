﻿#pragma checksum "..\..\Programme.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3D4BD64E2C97E145CE9E32A2ED92739F2CE8249EA116C83EAE7AE260637C3D6D"
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
    /// Programme
    /// </summary>
    public partial class Programme : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\Programme.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nomProgramme;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Programme.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numeroProgramme;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Programme.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox duréé;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\Programme.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock affichageProgrammes;
        
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
            System.Uri resourceLocater = new System.Uri("/Gestion_Ecole;component/programme.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Programme.xaml"
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
            this.nomProgramme = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\Programme.xaml"
            this.nomProgramme.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.accepterQueLesLettres);
            
            #line default
            #line hidden
            return;
            case 2:
            this.numeroProgramme = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\Programme.xaml"
            this.numeroProgramme.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.accepterQueLesChiffres);
            
            #line default
            #line hidden
            return;
            case 3:
            this.duréé = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            
            #line 52 "..\..\Programme.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ajoutProgramme_a_LaListe);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 80 "..\..\Programme.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.home);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 81 "..\..\Programme.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Etudiant);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 82 "..\..\Programme.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Consultation);
            
            #line default
            #line hidden
            return;
            case 8:
            this.affichageProgrammes = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

