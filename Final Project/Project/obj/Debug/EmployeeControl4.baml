   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5          Project.EmployeeControl4   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5      !localclr-namespace:Project  5      .��5
      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TransitioningContentSlide��5   /   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6R   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      �  � RowDefinitions 5      �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   .+�5      �� $	��Top=�6   $��47��65   5      �� 5      $��0��6    �� Orientation$ Vertical=�6*   $
��Left=�6A   $��Center=�6\   $	��380��6w   .+�5      �� $
��Name��6    $��30(�6,   ���	#FF3C3C3C$
��10 5q�6Q   $��Mongolian Baiti)�6_   �� 5      $ 
Horizontal=�6!   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	RenameBox=�63   $��30��6D   $	��30 ��6O   $
��10 5q�6\   ���	#FF17326A6j   �� 5      -   5         ��Name$ txtName��5   $   $��20(�65   $	��0 0q�6C   $��40��6P   ���	#FF60048B$	��500��6s   $��Simplified Arabic)�6   5      5      �� 5      $��1��6   $ Vertical=�6*   $
��Left=�6A   $��Center=�6\   $	��380��6w   .+�5      �� $��Email��6    $��30(�6-   ���	#FF3C3C3C$
��10 5q�6R   $��Mongolian Baiti)�6`   �� 5      $ 
Horizontal=�6!   .+�5         $ Email=�63   $��30��6@   $	��30 ��6K   $
��10 5q�6X   ���	#FF17326A6f   �� 5!      -   5         ��Name$ txtEmail��5!   "   ���	#FF17326A$��20(�6L   $	��0 0q�6Z   $��40��6g   ���	#FF60048B$	��500��6�   $��Simplified Arabic)�6�   5"      5#      �� 5$      $��2��6   $ Vertical=�6*   $
��Left=�6A   $��Center=�6\   $	��380��6w   .+�5%      �� $��Phone number��6    $��30(�64   ���	#FF3C3C3C$
��10 5q�6Y   $��Mongolian Baiti)�6g   �� 5&      $ 
Horizontal=�6!   .+�5'        $ Phone=�63   $��30��6@   $��30��6K   $
��10 5q�6W   ���	#FF17326A6e   �� 5(      -   5        $ txtPhoneNumber��5(   "   ���	#FF17326A$��20(�6R   $	��0 0q�6`   $��40��6m   ���	#FF60048B$	��500��6�   $��Simplified Arabic)�6�   5)      5*      �� 5+      $��3��6   $ Vertical=�6*   $
��Left=�6A   $��Center=�6\   $	��380��6w   $	��0,2q�6�   .+�5,      �� $��Password��6    $��30(�60   ���	#FF3C3C3C$
��10 5q�6U   $��Mongolian Baiti)�6c   �� 5-      $ 
Horizontal=�6!   .+�5.        $ Password=�63   $��30��6C   $	��30 ��6N   $
��10 5q�6[   ���	#FF17326A6i   G� 5/      -   5         G�Name$ txtPassword��5/   &   ���	#FF17326A$��20(�6S   $	��0 0q�6a   $��40��6n   ���	#FF60048B$	��332��6�   $��Simplified Arabic)�6�   50      51      �� 52      $��4��6   $ 
Horizontal=�6*   $
��Left=�6C   $��Center=�6^   .+�53      �� -   5        	 ��Name$	 EditBtn��53      $
��Edit��6.   $��15 20q�6=   $	��297��6L   $��50��6X   ���	#FF17326A
���   �$��35(�6�   $��Mongolian Baiti)�6�   $
��Bold"�6�   ���	#FF3C3C3C6�   54      �� 55      -   5        
 ��Name$
 
ProfileImg��55      $
��Left=�6,   $��390,10,0,84q�6G   $��3��6\   $	��200��6m    J� RenderTransformOrigin$ 0.208,0.536&�6y   �� 56      -   5        $	 ChoosePhotoBtn��56      $��Choose a photo��61   $
��Left=�6J   $��
390,30,0,0q�6e   $��2��6y   $	��Top=�6�   $	��200��6�   $
��Bold"�6�   $��50��6�   ���	#FF17326A
���   �$��20(�6�   $��Mongolian Baiti)�6   $ 
0.48,1.438&�6  ���	#FF3C3C3C6X  57      58      59      5:      