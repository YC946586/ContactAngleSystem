   M S B A M L   `   `   `  ����J  FYCCustomControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:YCCustomControlYCCustomControl  5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nulleHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf 5      C&clr-namespace:YCCustomControl.ControlsYCCustomControl.Controls  5      G(clr-namespace:YCCustomControl.ConvertersYCCustomControl.Converters  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35  �� MergedDictionaries �� Source.    (YCCustomControl.Converters.FlagConverter   Flag+   %YCCustomControl.Controls.BoderContent �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius � RowDefinitions J� InputBindings	 d� MouseAction)  #MaterialDesignThemes.Wpf.DialogHost
   CloseDialogCommand �� Command   Hander'  !MaterialDesignThemes.Wpf.PackIcon   Kind � Cursor.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName.  (System.Windows.Interactivity.TriggerBase   Actions6  0System.Windows.Interactivity.InvokeCommandAction   Command+   %YCCustomControl.Controls.TitleTextBox-	  'System.Windows.Input.KeyboardNavigation �� Orientation   Title   
TitleWidth  TextBlockStyleDefault ! TextBoxStyleDefaultByDescribe   Describe
 J� Uid �� Triggers ]� 
Conditions �� Property �� Value  TitleTextBoxNow  TextBoxStyleDefaultByDescri  PassworldLoginStyle ��Name�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      'localclr-namespace:YCCustomControl  5      PwpfHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf  5      /loca&clr-namespace:YCCustomControl.Controls  5      Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      7
converters(clr-namespace:YCCustomControl.Converters  5        5      �� 5   
   $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Flipper.xaml?�6   �� 5   
   $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6   �� 5   
   $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6   �� 5   
   $R Lpack://application:,,,/YCCustomControl;component/Styles/ButtonBaseStyle.xaml?�6   �� 5   
   $P Jpack://application:,,,/YCCustomControl;component/Styles/TextBaseStyle.xaml?�6   �� 5   
   $S Mpack://application:,,,/YCCustomControl;component/Styles/ContentBaseStyle.xaml?�6   �� 5   
   $Q Kpack://application:,,,/YCCustomControl;component/Styles/CheckBaseStyle.xaml?�6   �� 5   
   $T Npack://application:,,,/YCCustomControl;component/Styles/DategridBaseStyle.xaml?�6   %  &	        '       '  )    &	 	    &	 ;       5      6   �� 5      "  6   .�5   
   ��  �@�FocusVisualStyle 6-   Z� �� 5   
    � ��$
 Left=�60   �� 5   
    � ��$ Center=�6.   �� 5   
    �@�Cursor$
 Hand��6#   �� 5   
    � �� 5      �� 5       "  6"   .R�5!      �� $ 11��6   
�������._�5"      �  5#      �� 5$   "   $��40 �60   �� 5%   "   $��* �60   .+�5'      �� $�� 0 0 0 1q�6%   ���#CCCCCC
������� 5(   "   d� 5)   &   $	 	LeftClicke�63   # Z
 6L   ._�5+   "   � .+�5,   &   �� $��18(�60   $��Microsoft YaHei)�6>   $��20 0 0 0q�6[   $
��Bold"�6m   ���#333333#��z��6�   #��z 5-   ,   #��z��6L     5.   &   $ Close=�63   $��30��6@   $��30��6K   $��0 5 10 0q�6W   $
 Hand��6j   $��Right=�6x   
���   �$��Center=�5/   I    50   *     51   .   $ MouseLeftButtonDown��6=   . 52   2     # Z
 6H   53   /   55   '   57   #   58      �� 5;      $��1��60   #��z��6=   #��z��5<   -   5>      5?      5@      5B      5C      �� 5F      "  6   .�5G   
   ��  � �� �#ECEFF46'   �� 5H   
    � ��$	 210��6"   �� 5I   
    � ��$ 35��6#   �� 5J   
    � �� �#E8E9EB6(   �� 5K   
    � ��$	 0 5q�6#   �� 5L   
    � �� �#3333336'   �� 5M   
    � ��$ 1q�6,   �� 5N   
    � ��$ 2 0 0 0q�6$   �� 5O   
    �@	 TabNavigation$
 None=�6=   �� 5P   
    � ��$
 Left=�60   �� 5Q   
    �@�FocusVisualStyle 6-   Z� �� 5R   
    �@J�	AllowDrop . 6&   �� 5S   
    �@��PanningMode$ VerticalFirst=�65   �� 5T   
    �@��IsFlicksEnabled .  63   �� 5U   
    � �� 5V      �� 5W      "  6"   .R�5X      � $��0q�6   .+�5Y      �� $ 
Horizontal=�6%   .+�5Z      �� #��z 6(   #��z 6I   $��0q�6n   $��Center=�6y   $��Right=�6�   #���  6�   � 5[      $��1��6#   $��2 0 0 0q�64   .+�5\   "   �� #���  6*   $��35��6b   $��0q�6n   $	��145��6y   # z 6�   5]      5^      5_      5`      5b       5c   
   ]� 5d       5e      �� 5f      + �@��#IsInactiveSelectionHighlightEnabled . 6O   �� 5g       �@��IsSelectionActive .  6=   ./�5i      ��  �@��SelectionBrush# � /�63   5j      5l      �� 5n      "  6%   .�5o   
   ��  � �� �#ECEFF46'   �� 5p   
    � ��$	 210��6"   �� 5q   
    � ��$ 35��6#   �� 5r   
    � �� �#E8E9EB6(   �� 5s   
    � �� �#3333336'   �� 5t   
    � ��$ 1q�6,   �� 5u   
    � ��$ 2 0 0 0q�6$   �� 5v   
    � ��$ 0q�6#   �� 5w   
    �@	 TabNavigation$
 None=�6=   �� 5x   
    � ��$
 Left=�60   �� 5y   
    � ��$ Center=�65   �� 5z   
    �@�FocusVisualStyle 6-   Z� �� 5{   
    �@J�	AllowDrop . 6&   �� 5|   
    �@��PanningMode$ VerticalFirst=�65   �� 5}   
    �@��IsFlicksEnabled .  63   �� 5~   
    � �� 5      �� 5�      "  6"   .R�5�      � $��0q�6   .+�5�      �� $ 
Horizontal=�6%   $��40��6>   .+�5�      �� #��z 6(   #��z 6I   $��0q�6n   $��Center=�6y   $��Right=�6�   #���  6�   � 5�      $��1��6#   $��2 0 0 0q�64   .+�5�   "   �� #���  6*   $��0q�6`   $	��110��6k   # z 6w   5�      5�      5�      5�      5�       5�   
   ]� 5�       5�      �� 5�      + �@��#IsInactiveSelectionHighlightEnabled . 6O   �� 5�       �@��IsSelectionActive .  6=   ./�5�      ��  �@��SelectionBrush# � /�63   5�      5�      �� 5�      " G�6)   .�5�   
   ��  � �� �#ECEFF46'   �� 5�   
    � �� �#E8E9EB6(   �� 5�   
    � �� �#3333336'   �� 5�   
    � ��$ 1q�6,   �� 5�   
    � ��$ 2 0 0 0q�6$   �� 5�   
    �@	 TabNavigation$
 None=�6=   �� 5�   
    � ��$
 Left=�67   �� 5�   
    � ��$ Center=�65   �� 5�   
    �@�FocusVisualStyle 6-   Z� �� 5�   
    �@J�	AllowDrop . 6&   �� 5�   
    �@��PanningMode$ VerticalFirst=�65   �� 5�   
    �@��IsFlicksEnabled .  63   �� 5�   
    �@G�PasswordChar$	 ●��6)   �� 5�   
    � ��$ 16(�6%   �� 5�   
    � ��$ Center=�6.   �� 5�   
    � �� 5�      �� 5�      " G�6"   .R�5�      �� #��z��6   #��z��6S   #��z��6}   ._�5�      �� $ PART_ContentHost��6'   $��2 0 0 0q�6B   #��z��6U   $��1��6�   5�      5�      5�      5�      5�      