   M S B A M L   `   `   `  ����N  JContactAngleControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:ContactAngleControl.ViewModel.UC ContactAngleControl.ViewModel.UC  5   	   9!clr-namespace:ContactAngleControlContactAngleControl  5   	   4    .ContactAngleControl.View.Win.TestQueryPageView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =uc.clr-namespace:ContactAngleControl.ViewModel.UC     5   	   Acontactanglecontrol!clr-namespace:ContactAngleControl     5   	     � WindowStyle$
  None=�5       � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5	   
   $
��1366��5
      $	��768��6    � DataContext 5      =   7ContactAngleControl.ViewModel.UC.TestQueryPageViewModel  5   
   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��49 �6    �� 5      $��55 �6    �� 5      $��* �6    �� 5      $��30 �6    �� 5      $	��130 �6    .+�5      "   ContactAngleControl.UCHeader  �� 5      $��1��6    �� SelectedIndex$ 0��6%      ListBoxItemStyleTab#���   5      $��0q�6O    �� SelectedItem 5   7   �� *	SelectTab+.@�5      ��   AngleQuerySystem#���  6   �� 5        TensionQuerySystem#���  6   �� 5        SurfaceEnergQuerySystem#���  6   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   5       5"      &   System.Windows.Controls.DataGrid  5$      $��2��6   $
��15 0q�6G   ��6$   �� *
ListGroups+   Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6+    
 number
   Header#
 �  65     5'      $	 * 6+     Thetestdate#
 �  65     5(      $	 * 6+     The test of time#
 �  65     5)      $	 * 6+     The operator#
 �  65     5*      $	 * 6+     Sample number#
 �  65     5+      $	 * 6+    	 The name of the solid#
 � 	 65     5,      $	 * 6+    
 The left contact Angle#
 � 
 65     5-      $	 * 6+     Right contact Angle#
 �  65     5.      $	 * 6+     Differential contact Angle#
 �  65     5/      $	 * 6+     Evaluation contact Angle#
 �  65     50      $	 * 6+     A few lines of inclination#
 �  65     51      $	 * 6+     Forward Angle#
 �  65     52      $	 * 6+     Receding Angle#
 �  65   4  .System.Windows.Controls.DataGridTemplateColumn  53      
 54      �� 55      $��80��6'   $��Center=�56   C     CheckAll#���  6`    d� 	IsChecked 55   2   �� *DataContext.Check_ALL+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ UserControlL� � FocusVisualStyle 56   '   Z� 6`      CellTemplate 58      �� 59      .R�5:   "   �� 5;      5=      5?      � 5@      $��3��6   $
��15 0q�6    .+�5A      ��  
 Export#���  6   $
��Left=�6<     ButtonStyleDefault#���  6W   �� 5B      $ 
Horizontal=�6   $��Right=�66   .+�5C      ��   DeleteCurrentRecord#���  6     ButtonStyleDel#��[ 6O   �� 5D        	Deleteall#���  6   #��[ 6E   5E      5F      �� 5H      ���#cccccc$��1q�6+   $��4��6?   $��15q�6L   ._�5I      � $
��5 10q�6    � ColumnDefinitions 5J      �� 5K      $��3* �6+   �� 5L      $��2* �6+   �� 5M      $��* �6+   �� 5N      $��* �6+   .+�5Q      �� $ Vertical=�6!   .+�5R      ��   Query by date#���  6$   $
��Left=�6K   $��0q�6f     TextBlockStyleDefault#���  6q   �� 5S      $ 
Horizontal=�6%   .+�5T      ��   TextBoxStyleWindth#���  6'   �� 5U        Year#���  6(   ���#666666#���  6[   �� 5V      #���  6'   �� 5W       	 month#���  6(   ���#666666#���  6\   �� 5X      #���  6'   �� 5Y        day#���  6(   ���#666666#���  6Z   �� 5Z      #���  6'   �� 5[       	 hours#���  6(   ���#666666#���  6\   �� 5\      #���  6'   �� 5]        minutes#���  6(   ���#666666#���  6^   �� 5^       	 Query#���  6%   $��60��6G   $��28��6R   $
��Left=�6^   #���  6y   5_      5`      �� 5a      $ Vertical=�6!   $��1��68   .+�5b      ��    Query by measured value#���   6$   $��0q�6U   $
��Left=�6`   #���  6{   �� 5c      $ 
Horizontal=�6%   .+�5d      �� #���  6'   �� 5e       ! Measured mean#��� ! 6(   ���#666666#���  6d   �� 5f      #���  6'   �� 5g      #���  6%   $��60��6G   $��28��6R   $
��Left=�6^   #���  6y   5h      5i      �� 5j      $ Vertical=�6!   $��2��68   .+�5k      ��  " Query by operator#��� " 6$   $��0q�6O   $
��Left=�6Z   #���  6u   �� 5l      $ 
Horizontal=�6%   .+�5m      �� #���  6(   ���#666666#���  6c   �� 5n      #���  6'   �� 5o      #���  6%   $��60��6G   $��28��6R   $
��Left=�6^   #���  6y   5p      5q      �� 5r      $ Vertical=�6!   $��3��68   .+�5s      ��  # Query by sample#��� # 6$   $��0q�6M   $
��Left=�6X   #���  6s   �� 5t      $ 
Horizontal=�6%   .+�5u      ��  $ The sample name#��� $ 6(   ���#666666#���  6f   �� 5v      #���  6'   �� 5w      #���  6%   $��60��6G   $��28��6R   $
��Left=�6^   #���  6y   5x      5y      5z      5{      5|      5~      5      