   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	       Project.Manager   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Manager��5	   	   $	��600��6   $
��1024��6&    � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6Y   .��5
      � ��5   
   �� 5       �� ImageSource$ Manager/manager3.jpg��6   .+�5   
   � $	��800��6   $��Right=�6   ��5      �� 5      $ Manager/managermenu.jpg��6    � ColumnDefinitions 5      �� 5      $��5* �6#   �� 5      $
��900* �6#   .+�5      �� $��1��6   $	��Top=�6)   .+�5      � ���	#FF0069C0$��10��6.   � 5      $��5q�6   .+�5      �� $��Center=�6!    �� Orientation$ 
Horizontal=�6>   .+�5      �� $��Welcome to manager page��6$   $��Center=�6C   $��30(�6^   ���	#FF3C3C3C$��Showcard Gothic)�6�   $
��20 0q�6�   5      �� 5      $ 
Horizontal=�6!   $��Right=�6:   $
��10 0q�6V   .+�5      �� -   5         ��Name$ MinimizeBtn��5   !   $��50��66   $��30��6A   $��0q�6e   ���	#FF3C3C3C��6N   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Minus=�67   $��30��6D   $��30��6O   5      �� 5       -   5        $ MaximizeBtn��5    !   $��50��66   $��30��6A   $��0q�6e   ���	#FF3C3C3C��6N   Z� ��6�   Z� .��5!        $ SquareOutline=�67   $��30��6L   $��30��6W   5"      �� 5#      -   5        $ closeBtn��5#   !   $��50��63   $��30��6>   $��0q�6b   ���	#FF3C3C3C��6K   Z� ��6�   Z� .��5$        $ Power=�67   $��30��6D   $��30��6O   5%      5&      5'      5(      5)      � 5*   
   $��
255 55 0 0q�6   .+�5+      � -   5         �Name$ GridPrincipal��5+      $��Center=�6*   $��Center=�6G   5,      � 5.   
   $	��250��6   $
��Left=�6   ���	#FF3C3C3C.+�5/      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5        	  Name$	 TransitioningContentSlide��5/   3   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase
   OpeningEffect
 6V   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��50      � -   5        $ 
GridCursor��50      $��10��6+   $��0,63,0,0q�66   $	��Top=�6H   $
��Left=�6`   $��60��6{   ���	#FF0069C06�   51      �� 52      -   5         ��Name$ ListViewMenu��52      $��	0,63,0,76q�6-   .@�53      �� $��60��6   
�������.��54      �� $ 
Horizontal=�6!   .+�55        $ Person=�63   $��30��6A   $��30��6L   $��Center=�6X   $��5q�6s   �� 56      $��	Employees��6%   
������  �� Padding$ 0 1 0 1q�6O   
�������$��20(�6x   $��Center=�6�   $
��20 0q�6�   $��Comic Sans MS)�6�   57      58      �� 59      $��60��6   
�������.��5:      �� $ 
Horizontal=�6!   .+�5;        $ Books=�63   $��30��6@   $��30��6K   $��Center=�6W   $��5q�6r   �� 5<      $��Books��6%   
������ $ 0 1 0 1q�6K   
�������$��20(�6t   $��Center=�6�   $
��20 0q�6�   $��Comic Sans MS)�6�   5=      5>      �� 5?      $��60��6   
�������.��5@      �� $ 
Horizontal=�6!   .+�5A        $
 Bank=�63   $��30��6?   $��30��6J   $��Center=�6V   $��5q�6q   �� 5B      $��
Money bank��6%   
������ $ 0 1 0 1q�6P   
�������$��20(�6y   $��Center=�6�   $
��20 0q�6�   $��Comic Sans MS)�6�   5C      5D      �� 5E      $��60��6   
�������.��5F      �� $ 
Horizontal=�6!   .+�5G        $ ArrowBackCircle=�63   $��30��6J   $��30��6U   $��Center=�6a   $��5q�6|   �� 5H      $
��Back��6%   
������ $ 0 1 0 1q�6J   
�������$��20(�6s   $��Center=�6�   $
��20 0q�6�   $��Comic Sans MS)�6�   5I      5J      5K      5L      5M      5N      