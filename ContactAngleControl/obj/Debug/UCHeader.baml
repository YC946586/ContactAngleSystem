   M S B A M L   `   `   `  ����N  JContactAngleControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ContactAngleControlContactAngleControl  5      "    ContactAngleControl.UCHeader   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ContactAngleControl     5      .��5      � $��49��6   ��5   
   �� 5	        �� ImageSource$  Img/header.png��6    j� Stretch$
 Fill=�66   6G    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Center=�6   $
��20,0q�60    �� Orientation$ 
Horizontal=�6>   .+�5      �� $��Img/logo.png��6   $��21��6*   $��21��66   6C   �� 5         CompanyName#���   6     	CommLabel#��[ 6<   $��10,0,0,0q�6_   6t   �� 5      $��-��6   $
��10,0q�6    #��[ 6.   6T   �� 5        SysName#���  6   #��[ 68   ���#FBD1516r   5      �� 5   
   $��1��6   $ 
Horizontal=�6%   $
��20,0q�6>   $��Center=�6L   $��Right=�6g   .+�5      �� -   5        
������  � ToolTip$ 设置��5   .     RadiusButton#��[ 6;   
 � Tag$ 1��6b   $��21��6   $��21��6�   ��5      �� 5      $��Img/set.png��6   $��15��61   $��15��6<   6J   5      �� 5      -   5        
������ $ 	最小化��5   .   #��[ 6<   $��15,0,0,0q�6b   $ 2��6t   $��21��6�   $��21��6�   ��5      �� 5      $��Img/min.png��6   $��15��61   $��15��6<   6J   5       �� 5"      -   5        
������ $ 	最大化��5"   .   #��[ 6<   $��15,0,0,0q�6b   $ 3��6t   $��21��6�   $��21��6�   ��5#      �� 5$      -   5         ��Name$	 Max��5$   I   $��Img/max1.png��6   $��15��62   $��15��6=   6X   5&      �� 5(      -   5        
������ $ 关闭��5(   .   #��[ 6;   $��15,0,0,0q�6a   $ 4��6s   $��21��6�   $��21��6�   ��5)      �� 5*      $��Img/close.png��6   $��15��63   $��15��6>   6L   5,      5-      5.      5/      