   M S B A M L   `   `   `  ����A  =mectep, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:mectepmectep  5   	       mectep.Window_Add_MRZ   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:mectep     5   	     � Title$  Window_Add_MRZ��5   	   $	��600��6    $
��1100��6-    � WindowStartupLocation$ CenterScreen=�6:    � WindowStyle$
 None=�6_    � AllowsTransparency .  � 
ResizeMode$ NoResize=�6�   ��6�   Z� .��5	      �  J� Effect 5
   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 9Q�6      	Direction$	 303Q�6.      ShadowDepth$ 4Q�6>   	   RenderingBias$	 Quality=�6N   .+�5   
   � $��Center=�6   $��Center=�6,   $	��500��6G   $	��900��6T   
�������
 � ColumnDefinitions
 5      �� 5      �� 5      $	��208 �6#    � RowDefinitions 5      �� 5      $��33 �6    �� 5      $��* �6    .+�5      � -   5        $��0��5      ���#0A6E9E$��2��6d   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Stretch=�66   $��Right=�6R   .+�5      �� -   5           Close_Button#���   5      $��Bottom=�6P   .��5      �� $��Image/Icon/Close.png��6    $��Bottom=�6>   5      5      5      �� 5      $��1��6   $��1��6)   $	��Top=�66   $��0,20,0,0q�6N   .+�5      ��   
Add_Delete#���  6   $��30��6>   $	��150��6J   $��0,20,0,0q�6W   .��5      �� $ 
Horizontal=�6!   $
��Left=�6:   $
��25,0q�6U   .+�5       �� $��Image/Icon/Add_MRZ1.png��6    $��30��6A   $��30��6M   $��Center=�6X   �� 5!      $��Жүктөө��6$   
�������$��14(�6E   $��Center=�6S   5"      5#      d� 5$        
Pausa_Play#���  6   $��30��6D   $	��150��6P   $��0,20,0,0q�6]   �� 5%      #���  6   $��30��6>   $	��150��6J   $��0,20,0,0q�6W   .��5&      �� $ 
Horizontal=�6!   $
��Left=�6:   $
��25,0q�6U   .+�5'      �� $��Image/Icon/Select1.png��6    $��30��6@   $��30��6L   $��Center=�6W   �� 5(      $��Тандоо��6$   
�������$��14(�6E   $��Center=�6S   5)      5*      �� 5+      #���  6   $��30��6>   $	��150��6J   $��0,20,0,0q�6W   .��5,      �� $ 
Horizontal=�6!   $
��Left=�6:   $
��25,0q�6U   .+�5-      �� $��Image/Icon/Delete.png��6    $��30��6?   $��30��6K   $��Center=�6V   �� 5.      $��Өчүрүү��6$   
�������$��14(�6E   $��Center=�6S   5/      50      51      � 52      $��1��6   $��0��6    $��15,10,15,10q�60   .+�53      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridView1��57      $��12(�53        grid_xml#���  6*   "   VerticalScrollBarVisibility$
 Auto=�6M      AutoGenerateColumns .     HeadersVisibility$ Column=�54         CanUserAddRows .    
hederstyle   ColumnHeaderStyle# �  58      ��56      ��    Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   ��  �� Path$ Title�6W     5;      $ Аттары��6-   $	 772 6\    6=   �� $ Price�6\   5=      5>      5?      5@      5A      