   M S B A M L   `   `   `  ����A  =mectep, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:mectepmectep  5   	       mectep.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:mectep     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $
��1100��6,    � WindowStartupLocation$ CenterScreen=�6<    � WindowStyle$
 None=�6a    � AllowsTransparency .  � 
ResizeMode$ NoResize=�6�   ��6�   Z� .��5
      � $��7,4,7,18q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 9Q�6      	Direction$	 303Q�6.      ShadowDepth$ 4Q�6>   	   RenderingBias$	 Quality=�6N   .+�5   
   � 
�������
 � ColumnDefinitions
 5      �� 5      $
��Auto �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��30 �6    �� 5      $��50 �6    �� 5      $��* �6    .+�5      � -   5         �Name$
 grid��5      $��0��6!   $��3��61   ���#0A6E9E K� ZIndex$ 1��6X   $	��200��6i    5        5         Opacity$	 0.4Q�6'   $ 15Q�65   $ 0Q�6E   .+�5       � $��Stretch=�6   $	��Top=�65   $��80��6M   .+�5!      �� -   5         ��Name$ Menu_Stacpanel��5!   !   $��Right=�69   $	��Top=�6U   .+�5"      �� -   5         ��Name$ 	Open_Menu��5"   !      Opening_Closing#���   64   $y�	Collapsed=�6_   .��5#      �� $��Image/Icon/Opening.png��6$   5$      �� 5%      -   5        $ 
Close_Menu��5%   !   #���   65   $y�Visible=�6`   .��5&      �� -   5         ��Name$ image��5&   $   $��Image/Icon/Closing.png��63   5'      5(      5*      �� 5+      $	��Top=�6   $��0,80,0,0q�66   .+�5,      d� -   5         d�Name$ Video_Kozomol��5,   #     
menuButton#���  6:   .��5-      ��  �� Orientation$ 
Horizontal=�6%   .+�5.      �� $��Image/Icon/Camera.png��6$   $��45��6C   $��45��6O   �� 5/      -   5         ��Name$ 	textBlock��5/   (   $��Видео көзөмөл��6;   $��Center=�6P   $��16(�6k   
�������6y   50      51      d� 52      -	   5        $ MenuButton2��52   #   #���  68   .��53      �� $ 
Horizontal=�6%   .+�54      �� $!��Image/Icon/Kponguroolor.png��6$   $��45��6I   $��45��6U   �� 55      -
   5        $ 
textBlock1��55   (   $��Коңгуроолор��6<   $��Center=�6O   $��16(�6j   
�������6x   56      57      d� 58      -   5        $ MenuButton3��58   #   #���  68   .��59      �� $ 
Horizontal=�6%   .+�5:      �� $#��Image/Icon/Ubakyt_Boyncha.png��6$   $��45��6K   $��45��6W   �� 5;      -   5        $ 
textBlock2��5;   (   $��Убакыт боюнча��6<   $��Center=�6Q   $��16(�6l   
�������6z   5<      5=      d� 5>      -   5        $ MenuButton4��5>   #   #���  68   .��5?      �� $ 
Horizontal=�6%   .+�5@      �� $��Image/Icon/Add_MRZ.png��6$   $��45��6D   $��45��6P   �� 5A      -   5        $ 
textBlock3��5A   (   $��Үн тууралоо��6<   $��Center=�6O   $��16(�6j   
�������6x   5B      5C      5E      5G      � 5I      -   5        $��1��5I      $��0��6#   ���#0A6E9E.+�5J      �� $ 
Horizontal=�6   $��Stretch=�66   $��Right=�6R   .+�5K      �� -   5        $ Svernut��5K   r     Close_Button#���  6   $��Bottom=�6P   .��5L      �� $��Image/Icon/Mininmized.png��6    $��Bottom=�6C   $��30��6^   $��	0,0,0,-10q�6j   5M      �� 5N      -   5        $ 	Maximized��5N   r   #���  6   $��Bottom=�6P   .��5O      �� $��Image/Icon/Svernut.png��6    $��Bottom=�6@   5P      �� 5Q      -   5        #���  5Q      $��Bottom=�6P   .��5R      �� $��Image/Icon/Close.png��6    $��Bottom=�6>   5S      5T      5U      � 5V      $��1��6   $��1��6    ���	#FFE8E8E8.+�5W      �� $	��Top=�6   $��Right=�65   $��0,5,15,0q�6Q   .+�5X      �� -   5        $
 Time��5X       $��Maksat��6.   $��18(�6<   ���	#FF0A6E9E$
��Left=�6a   �� 5Y      -   5        $
 Date��5Y       $��Maksat��6.   $��15(�6<   ���	#FF3E97C1$
��Left=�6a   5Z      5[      � 5\      $��3��6   $��2��6    .+�5]       � -   5          �Name$ 	FramePage��5]        � NavigationUIVisibility$ Hidden=�6+   5_      5`      5b      5c      5d      