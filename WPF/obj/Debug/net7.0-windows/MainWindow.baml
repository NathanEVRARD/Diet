   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF.MVVM.ViewWPF.MVVM.View  5   	   7 clr-namespace:WPF.MVVM.ViewModelWPF.MVVM.ViewModel  5   	   clr-namespace:WPFWPF  5   	       WPF.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -viewsclr-namespace:WPF.MVVM.View     5   	   0vms clr-namespace:WPF.MVVM.ViewModel     5   	   #localclr-namespace:WPF     5   	   -   5          � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)   ���#cccccc � 	Resources 5       �� 
TargetType �� Property �� Value��%T   '��       �� 5   
   " ��6   .�5      ��  � ��
 �����6;   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      6!   .+�5   
   o� $��0��6   $��0��6   $��2��6,   .@�5      m� $��Fichier��6   6*   m� 5      $��Paramètres��6   6-   5      �� 5!   
   $��1��6   .+�5"      �� $��Clients��6   ��6'   �� *NavigateClientsCommand+6T   �� 5#      $��Aliments��6   ��6(   �� *NavigateAlimentsCommand+6V   5$      �� 5&   
   $��
5, 0, 0, 0q�6   $��1��6-   $��1��6:   ��6J   �� *CurrentViewModel+ 5'       �� DataType1   +WPF.MVVM.ViewModel.AlimentsListingViewModel   WPF.MVVM.View.AlimentView0   *WPF.MVVM.ViewModel.ClientsListingViewModel   WPF.MVVM.View.ClientView&    WPF.MVVM.ViewModel.PlanViewModel   WPF.MVVM.View.PlanView��%�   (��       5(      *, +)(�� 7     5+      *, +)(�� n     5.      *, +)�� 5(      "  6   .R�5)        6*   5*      �� 5+      "  6   .R�5,        6)   5-      �� 5.      "  6   .R�5/        6'   50      51      52      �� 53   
   
�������$��
0, 2, 2, 0q�6(   $��1��6E   $��0��6R   6d   �� 54   
   
���   �$��1q�6%   $y�	Collapsed=�69   6S   55      56      