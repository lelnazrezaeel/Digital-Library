   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	       Project.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��600��6   $
��1024��6)    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6[   ��5
      �� 5   
    �� ImageSource$ Manager/Images.jpg��6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $
��0.5* �6    �� 5      $
��1.5* �6    �� 5      �� 5      �� 5      �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $
��10 0q�6N   .+�5      �� -   5         ��Name$ MinimizeBtn��5      $��50��6.   $��30��69   $��0q�6]   
���������6F   Z� ��6|   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Minus=�6/   $��30��6<   $��30��6G   5      �� 5      -   5        $ MaximizeBtn��5      $��50��6.   $��30��69   $��0q�6]   
���������6F   Z� ��6|   Z� .��5        $ SquareOutline=�6/   $��30��6D   $��30��6O   5      �� 5      -   5        $ closeBtn��5      $��50��6+   $��30��66   $��0q�6Z   
���������6C   Z� ��6y   Z� .��5        $ Power=�6/   $��30��6<   $��30��6G   5       5!      �� 5"      $��1��6   $��Welcome��6%   
�������$��Center=�6G   $��Center=�6d   $��60(�6   $
��Bold"�6�   $��Snap ITC)�6�   �� 5#      $��2��6   .+�5$      �� $��Username��6   
�������$��30(�6?   $��Center=�6M   $��100,0q�6h   $��35��6w   $��Sylfaen)�6�   �� 5%      -   5         ��Name$ userBox��5%      $��Center=�6+   
�����@�$��100,0q�6]   $��35��6l   $��25(�6x   
������ 	 �� LineStackingStrategy$	 	MaxHeight=�6�   5&      �� 5'      $��3��6   .+�5(      �� $��Password��6   
�������$��30(�6?   $��Center=�6M   $��100,0q�6h   $��35��6w   $��Sylfaen)�6�   G� 5)      -   5        
 G�Name$
 passwordBox��5)      $��Center=�64   
�����@�$��100,0q�6f   $��35��6u   $��25(�6�   
������ $	 	MaxHeight=�6�   5*      �� 5+      -   5        $ 	signInBtn��5+      $��4��6(   $��Sign in��65   
�������$��100,0q�6Z   $��Center=�6i   $��50��6�   $��30(�6�   $
��10,0q�6�   $��Sylfaen)�6�   
�����@�6�   �� 5,      -   5        $ 	signUpBtn��5,      $��5��6(   $��Sign up��65   
�������$��100,0q�6Z   $��Center=�6i   $��50��6�   $��30(�6�   $
��10,0q�6�   $��Sylfaen)�6�   
�����@�6�   5-      5.      5/      