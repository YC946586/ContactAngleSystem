   M S B A M L   `   `   `  ����V  RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nulleHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf  5      N JContactAngleControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Iclr-namespace:ContactAngleControl.View.UC.CalculatedView.ContentPresenter;ContactAngleControl.View.UC.CalculatedView.ContentPresenter 5      J FYCCustomControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\?clr-namespace:YCCustomControl.Controls;assembly=YCCustomControlYCCustomControl.Controls 5      Q   KContactAngleControl.View.UC.CalculatedView.ContentPresenter.Twoliquidmethod   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      XwpfHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf     5      [localIclr-namespace:ContactAngleControl.View.UC.CalculatedView.ContentPresenter     5      Tcontrols?clr-namespace:YCCustomControl.Controls;assembly=YCCustomControl     5      .��5      �   � RowDefinitions  5   
   �� 5      $��90 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      ��    A liquid#���   6     TextBlockStyleDefault#��[ 6>   �� 5        StyleComboBoxDefault#��[ 6   $	��100��6J   $
��10 0q�6V   +  %YCCustomControl.Controls.TitleTextBox  5        SurfaceTension   Title# �  6(   $
��10 0q�6S      Describe$
 MN/M��6b     5        Contact Angle# �  6(   $	 ｏ��6Q   5      �� 5      $ 
Horizontal=�6   .+�5      ��   Liquid2#���  6   #��[ 6>   �� 5      #��[ 6   $	��100��6J   $
��10 0q�6V     5      # �  6(   $
��10 0q�6S   $
 MN/M��6b     5      # �  6(   $	 ｏ��6Q   5      5      � 5    
   $��1��6   $��0 10 0 0q�6    � ColumnDefinitions 5!      �� 5"      $	��390 �6#   �� 5#      $��* �6#   .+�5%      �� $ Vertical=�6   .+�5&      ��   Calculate solid surface#���  6   $	��250��6M   $
��Left=�6Y     ButtonStyleDefaultByNoWidth#��[ 6v     5'        Solid surface energy# �  6(    	 TitleTextBoxNow#��[	 6X   $
 MN/M��6�   �� 5(       
 Liquid database changes#��� 
 6   $��0 10 q�6L     TextBoxStyleLeftBor#���  6[   �� 5)      ���#CCCCCC$��1q�6/   ._�5*      �� $ Vertical=�6!   .+�5+      �� $ 
Horizontal=�6%   .+�5,      �� 
 J� Uid# �   6&   $	��165��6H     TextBoxStyleDefaultByTitle#���  6U   �� 5-      # �  6&   $	��165��6M   #���  6Z   5.      �� 5/      $ 
Horizontal=�6%   .+�50      �� # �  6&   $	��165��6G   #���  6S   �� 51      # �  6&   $	��165��6M   #���  6Y   52      �� 54      $ 
Horizontal=�6%   $
��0 15q�6>   $��Center=�6M   $��3��6h   $��Center=�6u   .+�55      ��   Add#���  6&   $��60��6H     ButtonStyleDefault#��[ 6T   �� 56        Edit#���  6&   $��60��6G   #��[ 6S   �� 57       
 Cancel#���  6&   )   #MaterialDesignThemes.Wpf.DialogHost   CloseDialogCommand#��Z 6I   $��60��6�     ButtonStyleDel#��[ 6�   58      59      5:      5;      �� 5<      $��1��6   ���#cccccc$��1q�6;   $	��490��6P   $��20 0 0 0q�6]   ._�5=      &   System.Windows.Controls.DataGrid  $��10q�6   ��6(   �� *
ListGroups+   Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6K     Serial number	   Header#	 �  6U   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6/   �� *	GroupId+6U     5@      $ * 6.     Surface energy#	 �  68     5A      $ * 6.     Estimation method#	 �  68     5B      $ * 6.     Contact Angle1#	 �  68     5C      $ * 6.     Contact Angle2#	 �  68   5E      5F      5H      5I      5J      