   M S B A M L   `   `   `  ����A  =mectep, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:mectep.Pagesmectep.Pages  5           mectep.Pages.Window_Ubakyt   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:mectep.Pages     5        N� Title$  Window_Ubakyt��5	       N� 
Background
 �����.��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $	��200 �6    �� 5      $��* �6    .+�5      � $��0��6   .+�5      �� $��Жадыбал��6   $��20(�6+   ���#0A6E9E$��25��6N   $	��100��6Z   $��80,5,712,165q�6f   �� 5      $��
80,30,30,0q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��0,15,0,0q�6:   .+�5      �� $!��Кирүү убактысы��6!   $��0,0,0,0q�6:   �� 5      -   5         ��Name$ 	ComboBox1��5      $	��250��5   #   $��30,0,0,0q�6/   
 � Tag$! Кирүү убактысы��6A    �� 
IsEditable . $��22��5   +   .@�5      �� $��08:00��6(   �� 5      $��09:00��6(   �� 5      $��10:00��6(   �� 5      $��11:00��6(   �� 5      $��12:00��6(   �� 5      $��13:00��6(   �� 5      $��14:00��6(   5       5"      �� 5#      $ 
Horizontal=�6!   $��0,15,0,0q�6:   .+�5$      �� $!��Чыгуу убактысы��6!   $��0,0,0,0q�6:   �� 5%      $	��250��6#   $��30,0,0,0q�6/   $! Кирүү убактысы��6A    . $��22��5&   +   .@�5'      �� $��08:00��6(   �� 5(      $��09:00��6(   �� 5)      $��10:00��6(   �� 5*      $��11:00��6(   �� 5+      $��12:00��6(   �� 5,      $��13:00��6(   �� 5-      $��14:00��6(   5.      5/      �� 50      $ 
Horizontal=�6!   $��0,15,0,0q�6:   .+�51      �� $'��!Коңгуроо убактысы��6!   $��0,0,0,0q�6=   �� 52      -   5         ��Name$ text1��52   0   $��14(�6"      textbox_style#���   6@   $ Секунда менен��6h   $��24��6|   $	��250��6�   $��Right=�6�   $��10,0,0,0q�6�   �� 53        
Add_Delete#���  6!   $	��150��6F   $��30��6R   $��40,0,0,0q�6^   .��54      �� $ 
Horizontal=�6)   $
��Left=�6B   $
��25,0q�6]   .+�55   "   �� $��Image/Icon/Save.png��6(   $��30��6E   $��30��6Q   $��Center=�6\   �� 56   "   $��Сактоо��6,   
�������$��14(�6M   $��Center=�6[   57      58      �� 59      #���  6!   $	��150��6F   $��30��6R   $
��15,0q�6^   .��5:      �� $ 
Horizontal=�6)   $
��Left=�6B   $
��25,0q�6]   .+�5;   "   �� $��Image/Icon/Delete.png��6(   $��30��6G   $��30��6S   $��Center=�6^   �� 5<   "   $��Өчүрүү��6,   
�������$��14(�6M   $��Center=�6[   5=      5>      5?      5@      5A      � 5B      $��1��6   $��
30,0,30,30q�6    .+�5C      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridView1��5G      $��12(�5C        grid_xml#���  6*   "	   VerticalScrollBarVisibility$
	 Auto=�6M   
   AutoGenerateColumns
 .     HeadersVisibility$ Column=�5D         CanUserAddRows .    
hederstyle   ColumnHeaderStyle# �  5H      ��5F      ��    Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   ��  �� Path$ Title�6W     5K      $! Кирүү убактысы��6-   $	 350 6d    6E   �� $ Price�6d     5L      $! Чыгуу убактысы��6-   $	 772 6d    6E   �� $ Price�6d   5N      5O      5P      5Q      5R      