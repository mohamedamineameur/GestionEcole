   M S B A M L   `   `   `  ���� H  DGestion_Ecole, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Gestion_EcoleGestion_Ecole      Gestion_Ecole.Etudiant   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:Gestion_Ecole       N� Title$  Etudiant�� N� 
Background
 �����.���  � RowDefinitions �� �� .+�� $��1�� �� �� �� �� �� �� �� �� �� �� �� ��  � ColumnDefinitions �� �� �� �� .+��� -    ��Name$ 	nomPrenom��$��2��$��0��$	��Nom���� -   $ numero��$��2��$��2���� -    ��Name$
 sexe��$��2��$��4��.@��� .��
Masculin�� .��Fémin(  "System.Windows.Controls.DatePicker  -     Name$ dateDeNaissance��$��2��$��6�� � 	Resources :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType	 �� Property
 �� Value��%6   '        �� "  .��� 	 �@��
IsReadOnly
 . �� -   $ 	programme��$��2��$��8���� -   $��2��$��10��.��	Ajouter�� $��Prénom et Nom��$��1��$��0��
�������� $��Numéro de l'étudiant��$��1��$��2��
�������� $
��Sexe��$��1��$��4��
�������� $��Date de naissance��$��1��$��6��
�������� $��Choix du programme��$��1��$��8��
�������  �� �� ��  �� �� �� �� .+�� $��2��$��0�� �� �� �� .+��� -   $A��;pack://application:,,,/Gestion_Ecole;component/img/Home.png��$��0��$��0�� � ToolTip$" Revenir à la page d'accueil���� -   $F��@pack://application:,,,/Gestion_Ecole;component/img/Programme.png��$��1��$��0��$* $Acceder au menu d'ajout de programme���� -	   $B��<pack://application:,,,/Gestion_Ecole;component/img/Liste.png��$��2��$��0��$" Acceder au menu consultation���� $��Liste des étudiants��$��0��$��1�� �� TextAlignment$ Center=��� $��1��$��1��$��3��.���� -
    ��Name$ affichageEtudiant��$ Center=�