   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF.WindowsWPF.Windows  5   	   !    WPF.Windows.AjoutIngredient   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPF.Windows     5   	     � Title$  AjoutIngredient��5   	   $	��450��6!   $	��800��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      $
��0.2* �6   6,   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��DataGridAliments��5   �   $��0��6   $��Center=�6#   $��10, 50, 15, 0q�6@   $	��Top=�6W      AutoGenerateColumns$ False��6�   "   VerticalScrollBarVisibility$
 Auto=�6�      AlternatingRowBackground
 ��İ���6o   �� *
Aliments+ �� SelectedItem 6�   �� *SelectedAliment+ � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property	 �� Value��%�   '        �� 5      "  6   .�5      ��  � ��$	 SemiBold"�63   6F   �� 5       � ��$	 Center=�6<   6M   �� 5       � ��
	 ���� 6I   �� 5       � ��$	 54��6.   6;   5      5      
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Nom+ �� Mode$ OneWay=�6Y     5      $ 	Kcalories��6%    68   �� *Kcal+$ OneWay=�6`     5      $ Glucides��6%    67   �� *
Glucides+$ OneWay=�6c     5      $ 
Protéines��6%    68   �� *	Proteines+$ OneWay=�6e     5      $ Lipides��6%    66   �� *	Lipides+$ OneWay=�6a     5      $ Calcium��6%    66   �� *	Calcium+$ OneWay=�6a     5      $	 Fer��6%    62   �� *Fer+$ OneWay=�6Y     5      $
 VitC��6%    63   �� *VitC+$ OneWay=�6[   5!      �� 5"   
   $��
5, 5, 0, 0q�6   $	��Top=�6)   $
��Left=�6A   .+�5#      �� $��Rechercher :��6   6-   �� 5$      -   5        $��ChampRecherche��5$      6Y   5%      �� 5&   
   $��35��6   $	��200��6   $	��Top=�6)   $��Center=�6A   $��0,18,0,0q�6^   $��Ajouter un client��6p   $��1��6�   ��6�   �� *AjoutIngredientCommand+��6�   �� *SelectedAliment+{�6�   �� *IsSelectedAliment+5'      5(      