   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	       Project.UserPanel   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$
  User��5	   	   $	��600��6   $
��1024��6#    � WindowStartupLocation$ CenterScreen=�60    � WindowStyle$
 None=�6U   .��5
      � .+�5   
   � $	��800��6   $��Right=�6   ��5      �� 5       �� ImageSource$ Manager/User.jpg��6    � ColumnDefinitions 5      �� 5      $��5* �6#   �� 5      $
��900* �6#   .+�5      �� $��1��6   $	��Top=�6)   .+�5      � ���	#FF0069C0$��10��6.   � 5      $��5q�6   .+�5      �� $��Center=�6!    �� Orientation$ 
Horizontal=�6>   .+�5      �� $��Welcome to User page��6$   $��Center=�6@   $��30(�6[   ���	#FF3C3C3C$��Showcard Gothic)�6�   $
��20 0q�6�   5      �� 5      $ 
Horizontal=�6!   $��Right=�6:   $
��10 0q�6V   .+�5      �� -   5         ��Name$ MinimizeBtn��5   !   $��50��66   $��30��6A   $��0q�6e   ���	#FF3C3C3C��6N   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Minus=�67   $��30��6D   $��30��6O   5      �� 5      -   5        $ MaximizeBtn��5   !   $��50��66   $��30��6A   $��0q�6e   ���	#FF3C3C3C��6N   Z� ��6�   Z� .��5        $ SquareOutline=�67   $��30��6L   $��30��6W   5      �� 5       -   5        $ closeBtn��5    !   $��50��63   $��30��6>   $��0q�6b   ���	#FF3C3C3C��6K   Z� ��6�   Z� .��5!        $ Power=�67   $��30��6D   $��30��6O   5"      5#      5$      5%      5&      � 5'   
   $��
255 55 0 0q�6   .+�5(      � -   5         �Name$ GridPrincipal��5(      $��Center=�6*   $��Center=�6G   5)      � 5+   
   $	��250��6   $
��Left=�6   ���	#FF3C3C3C.+�5,      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5        	  Name$	 TransitioningContentSlide��5,   3   $��	0,0,-19,0q�6�   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase
   OpeningEffect
 6V   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5-      � -   5        $ 
GridCursor��5-      $��10��6+   $��0,63,0,0q�66   $	��Top=�6H   $
��Left=�6`   $��60��6{   ���	#FF0069C06�   5.      �� 5/      -   5         ��Name$ ListViewMenu��5/      $��0,63,-19,76q�6-   .@�50      �� $��60��6   
�������.��51      �� $ 
Horizontal=�6!   .+�52        $ Books=�63   $��30��6@   $��30��6K   $��Center=�6W   $��5q�6r   �� 53      $��Books��6%   
������  �� Padding$ 0 1 0 1q�6K   
�������$��20(�6t   $��Center=�6�   $
��20 0q�6�   $��Comic Sans MS)�6�   54      55      �� 56      $��60��6   
�������.��57      �� $ 
Horizontal=�6!   .+�58        $ BookAccount=�63   $��30��6F   $��30��6Q   $��Center=�6]   $��5q�6x   �� 59      $��My Books��6%   
������ $ 0 1 0 1q�6N   
�������$��20(�6w   $��Center=�6�   $
��20 0q�6�   $��Comic Sans MS)�6�   5:      5;      �� 5<      $��60��6   
�������.��5=      �� $ 
Horizontal=�6!   .+�5>        $ Unity=�63   $��30��6@   $��30��6K   $��Center=�6W   $��5q�6r   �� 5?      $��Subscription��6%   
������ $ 0 1 0 1q�6R   
�������$��20(�6{   $��Center=�6�   $
��20 0q�6�   $��Comic Sans MS)�6�   5@      5A      �� 5B      $��60��6   
�������.��5C      �� $ 
Horizontal=�6!   .+�5D        $ Wallet=�63   $��30��6A   $��30��6L   $��Center=�6X   $��5q�6s   �� 5E      $��Wallet��6%   
������ $ 0 1 0 1q�6L   
�������$��20(�6u   $��Center=�6�   $
��20 0q�6�   $��Comic Sans MS)�6�   5F      5G      �� 5H      $��60��6   
�������.��5I      �� $ 
Horizontal=�6!   .+�5J        $
 Edit=�63   $��30��6?   $��30��6J   $��Center=�6V   $��5q�6q   �� 5K      $��Edit informations��6%   
������ $ 0 1 0 1q�6W   
�������$��20(�6�   $��Center=�6�   $
��20 0q�6�   $��Comic Sans MS)�6�   5L      5M      �� 5N      $��60��6   
�������.��5O      �� $ 
Horizontal=�6!   .+�5P        $ ArrowBackCircle=�63   $��30��6J   $��30��6U   $��Center=�6a   $��5q�6|   �� 5Q      $
��Back��6%   
������ $ 0 1 0 1q�6J   
�������$��20(�6s   $��Center=�6�   $
��20 0q�6�   $��Comic Sans MS)�6�   5R      5S      5T      5U      5V      5W      