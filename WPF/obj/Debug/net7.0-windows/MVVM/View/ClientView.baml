   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF.MVVM.ViewWPF.MVVM.View  5          WPF.MVVM.View.ClientView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WPF.MVVM.View     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��1.5* �6   6.   �� 5      6!   .+�5   
   ��  �� TextAlignment$ Center=�6   $��24(�6+   $��0, 10q�69   	Clients6Q   &   System.Windows.Controls.DataGrid  5   
   $
��Left=�6   $��10, 50, 15, 0q�6.   $	��Top=�6E      AutoGenerateColumns$ False��6�      
IsReadOnly$
 True��6�      AlternatingRowBackground
 ��İ���6]   �� *	Clients+ �� SelectedItem 6}   �� *SelectedClient+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� � ContextMenu 5      �� 5      .@�5      m� $
��Plan��6   	 m� Command	 6-   �� *NavigatePlanCommand+
 m� CommandParameter
 6U   �� *SelectedClient+6�   m� 5      $��	Supprimer��6   	 62   �� *SupprimerClientCommand+
 6]   �� *SelectedClient+6�   5       � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � ��$ SemiBold"�63   6F   �� 5       � ��$ Center=�6<   6M   �� 5       � ��
 ���� 6I   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Num��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Id+$ OneWay=�6X     5      $	 Nom��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6W    62   �� *Nom+$ OneWay=�6d     5       $ Prénom��6%   $ 2* 6]    65   �� *Prenom+$ OneWay=�6j     5!      $ Taille��6%   $
 1.5* 6]    65   �� *Taille+$ OneWay=�6l     5"      $ Poids��6%   $
 1.5* 6[    64   �� *Poids+$ OneWay=�6j     5#      $	 Bmi��6%   $
 1.5* 6W    62   �� *Bmi+$ OneWay=�6f   5%      �� 5&   
   $��0��6   $��25��6!   $	��Top=�6-   $��Right=�6E   $��5q�6a   $��Ajouter un client��6l   ��6�   �� *AjouterClientCommand+6�   �� 5'   
   $��1��6   $��
2, 0, 0, 0q�6!   
�������6W   �� 5(   
   $��1��6    �� Orientation$ 
Horizontal=�6%   $��5, 10q�6>   .+�5)      �� $��24(�6<   $��0, 0, 20, 0q�6J   $��Center=�6_   ��6   �� *SelectedClient.Nom+6~   �� 5*      $��24(�6?   $��0, 0, 5, 10q�6M   $��Center=�6b   ��6   �� *SelectedClient.Prenom+6�   5+      �� 5,   
   $��1��6   $��Hidden=�6'   .��5-      �� $��1��6   $��5, 50, 5, 0q�6)   .+�5.      �� $	��Nom��6   6(   �� 5/      ��6   �� *SelectedClient.Nom+$ PropertyChanged=�{�6c   �� *IsClientSelected+6�   �� 50      $��Prénom��6   6+   �� 51      ��6   �� *SelectedClient.Prenom+$ PropertyChanged=�{�6f   �� *IsClientSelected+6�   �� 52      $��Date de naissance��6   66   (  "System.Windows.Controls.DatePicker  53         SelectedDate 6   �� *SelectedClient.Naissance+$ PropertyChanged=�{�6t   �� *IsClientSelected+6�   �� 54      $��Taille��6   6+   �� 55      ��6   �� *SelectedClient.Taille+{�6A   �� *IsClientSelected+6j   �� 56      $��Poids��6   6*   �� 57      ��6   �� *SelectedClient.Poids+{�6@   �� *IsClientSelected+6i   �� 58      $	��Bmi��6   6(   �� 59      ${�False��6>   ��6   �� *SelectedClient.Bmi+6R   �� 5:      $��Pathologies��6   60   �� 5;      $��65��6N   ��6   �� *SelectedClient.Pathologies+��5<      �� 5=      " ��6     �� Triggers 5>      P� 5?   "    P� Property �@��HasItems P� Value$ False��6>   . �5@   &   ��  � y�$ 	Collapsed=�6C   5A   #   5C      5E      5F      5G      5H      5I      