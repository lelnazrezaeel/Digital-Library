   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5          Project.ManagerControl1   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Project     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesign11http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��450��5	      $	��600��6   .��5
      � .+�5   
   �� $��Right=�6   5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5   
   -   5           Name$  TransitioningContentSlide��5   /   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6R   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�62   $	��397��6M   .+�5      �� $	��300��6   .+�5      �� $��10q�6!   .+�5      �� $
��List��6$   $��50(�60   $��Gadugi)�6>   $
��Bold"�6R   ���	#FF3C3C3C6d   �� 5      -   5         ��Name$ lsDataBinding��5   0   $��10q�6$   ��6G   �� *emps+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5   "   .R�5   &   � .+�5   *   �� $��Name: ��64   �� 5   *   $
��Bold"�6J   ��64   �� *Name+6J   �� 5   *   $��, ��64   �� 5   *   $��Phone number: ��64   �� 5   *   $
��Bold"�6Q   ��64   �� *Phonenumber+6Q   5   '   5   #   5       5!      5"      �� 5#      $ Vertical=�6   $
��auto��64   $
��auto��6A   $��100 20 0 100q�6O   .+�5$      �� $ 
Horizontal=�6!   $
��0 20q�6:   .+�5%      '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FF17326A   Kind$ 	PersonAdd=�6J   $��30��6[   $��30��6f   �� 5&      -   5         ��Name$ 	AddPerson��5&   <   $��Add an employee��6!   $	��150��6O   $��30��6[   $��0q�6   ���	#FF17326A$
��Bold"�6�   ��6h   Z� ��6�   Z� 6�   5'      �� 5(      $ 
Horizontal=�6!   $
��0 20q�6:   .+�5)        ���	#FF17326A$ PersonRemove=�6J   $��30��6^   $��30��6i   �� 5*      -   5        $ RemovePerson��5*   >   $��Remove an employee��6!   $	��150��6T   $��30��6`   $��0q�6�   ���	#FF17326A$
��Bold"�6�   ��6m   Z� ��6�   Z� 6�   5+      �� 5,      $ 
Horizontal=�6!   $
��0 20q�6:   .+�5-        ���	#FF17326A$ Money100=�6J   $��30��6Z   $��30��6e   �� 5.      -   5        $ DepositOfSalaries��5.   ?   $��Deposit of salaries��6!   $	��150��6Z   $��30��6f   $��0q�6�   ���	#FF17326A$
��Bold"�6�   ��6s   Z� ��6�   Z� 6�   5/      50      51      52      53      54      