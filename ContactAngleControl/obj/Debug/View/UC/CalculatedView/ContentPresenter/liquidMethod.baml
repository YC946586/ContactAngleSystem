   M S B A M L   `   `   `  ����N  JContactAngleControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Iclr-namespace:ContactAngleControl.View.UC.CalculatedView.ContentPresenter;ContactAngleControl.View.UC.CalculatedView.ContentPresenter  5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nulleHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf 5      J FYCCustomControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\?clr-namespace:YCCustomControl.Controls;assembly=YCCustomControlYCCustomControl.Controls 5      N    HContactAngleControl.View.UC.CalculatedView.ContentPresenter.liquidMethod   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      [localIclr-namespace:ContactAngleControl.View.UC.CalculatedView.ContentPresenter     5      XwpfHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf     5      Tcontrols?clr-namespace:YCCustomControl.Controls;assembly=YCCustomControl     5      .��5      �   � RowDefinitions  5   
   �� 5      $��90 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      ��    A liquid#���   6     TextBlockStyleDefault#��[ 6>   �� 5        StyleComboBoxDefault#��[ 6   $	��100��6J   $
��10 0q�6V   +  %YCCustomControl.Controls.TitleTextBox  5        SurfaceTension   Title# �  6(      Describe$
 MN/M��6T     5        The polar components# �  6(   $
��10 0q�6Y   $
 MN/M��6g     5        The dispersion component# �  6(   $
 MN/M��6\     5        Contact Angle# �  6(   $	 ｏ��6Q   $
��10 0q�6^   5      �� 5      $ 
Horizontal=�6   .+�5      ��   Liquid2#���  6   #��[ 6=   �� 5      #��[ 6   $	��100��6J   $
��10 0q�6V     5      # �  6(   $
 MN/M��6T     5      # �  6(   $
��10 0q�6X   $
 MN/M��6f     5      # �  6(   $
 MN/M��6\     5       # �  6(   $	 ｏ��6Q   $
��10 0q�6^   5!      5"      � 5&   
   $��1��6   $��0 10 0 0q�6    � ColumnDefinitions 5'      �� 5(      $	��390 �6#   �� 5)      $��* �6#   .+�5+      �� $ Vertical=�6   .+�5,      ��   Calculate solid surface#���  6   $	��250��6N   $
��Left=�6Z   $��0 0 20 0q�6v    	 ButtonStyleDefaultByNoWidth#��[	 6�     5-       
 Solid surface energy# � 
 6(     TitleTextBoxNow#��[ 6X   $
 MN/M��6�   �� 5.      $ 
Horizontal=�6   .+�5/        # �  6,   $��7 0 0 0q�6\   #��[ 6m   $
 MN/M��6�     50      # �  6.   #��[ 6b   $
 MN/M��6�   51      �� 53        Liquid database changes#���  6   $��0 10 q�6K     TextBoxStyleLeftBor#���  6Z   �� 54      ���#CCCCCC$��1q�6/   ._�55      �� $ Vertical=�6!   $��5q�68   .+�56      �� $ 
Horizontal=�6%   .+�57        # �   64   #��[ 6X   $��7 0 0 0q�6�     58      # �  64   #��[ 6^   $
 MN/M��6�   59      �� 5:      $ 
Horizontal=�6%   .+�5;        # �  64   #��[ 6d   $
 MN/M��6�     5<      # �  66   $��3 0 0 0q�6k   #��[ 6}   $
 MN/M��6�   5=      �� 5?      $ 
Horizontal=�6%   .+�5@        # �  64   #��[ 6W   $��7 0 0 0q�6�     5A      # �  64   #��[ 6_   $
 MN/M��6�   5B      �� 5C      $ 
Horizontal=�6%   .+�5D        # �  64   #��[ 6c   $
 MN/M��6�     5E      # �  66   $��3 0 0 0q�6l   #��[ 6~   $
 MN/M��6�   5F      �� 5G      $ 
Horizontal=�6%   $
��0 15q�6>   $��Center=�6M   $��3��6h   $��Center=�6u   .+�5H      ��   Add#���  6&   $��60��6H     ButtonStyleDefault#��[ 6T   �� 5I        Edit#���  6&   $��60��6G   #��[ 6S   �� 5J       
 Cancel#���  6&   )  #MaterialDesignThemes.Wpf.DialogHost   CloseDialogCommand#��Z 6I   $��60��6�     ButtonStyleDel#��[ 6�   5K      5L      5M      5N      �� 5O      $��1��6   ���#cccccc$��1q�6;   $	��490��6P   $��20 0 0 0q�6]   ._�5P      &   System.Windows.Controls.DataGrid  $��10q�6   ��6(   �� *
ListGroups+   Columns 5Q      0  *System.Windows.Controls.DataGridTextColumn  5R      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6K     Serial number   Header# �  6U   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6/   �� *	GroupId+6U     5S      $ * 6.     Surface energy# �  68     5T      $ * 6.     Estimation method# �  68     5U      $ * 6.     Contact Angle1# �  68     5V      $ * 6.     Contact Angle2# �  68     5W      $ * 6.   # �  68     5X      $ * 6.   # �  68   5Z      5[      5]      5^      5_      