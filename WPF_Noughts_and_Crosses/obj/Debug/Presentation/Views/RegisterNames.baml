   M S B A M L   `   `   `  ����R  NWPF_Noughts_and_Crosses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:WPF_Noughts_and_Crosses.Presentation.Views*WPF_Noughts_and_Crosses.Presentation.Views  5   	   q=clr-namespace:WPF_Noughts_and_Crosses.Presentation.ViewModels/WPF_Noughts_and_Crosses.Presentation.ViewModels  6P   >    8WPF_Noughts_and_Crosses.Presentation.Views.RegisterNames   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Jlocal8clr-namespace:WPF_Noughts_and_Crosses.Presentation.Views     5   	   Plocal1=clr-namespace:WPF_Noughts_and_Crosses.Presentation.ViewModels     6P     � Title$  Register Names��5   	   $	��560��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69    � 
ResizeMode$ NoResize=�6^    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $K E/WPF_Noughts_and_Crosses;component/Presentation/Styles/AppStyles.xaml?�6%   5      %    5       � DataContext 5      C   =WPF_Noughts_and_Crosses.Presentation.ViewModels.GameViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5       $��* �6   6)   �� 5!      $��* �6   6)   .+�5#   
   �� $��../Images/ttt.jpg��6   $
��Fill=�6+   $��3��6:   $��6��6N   �� 5$   
   $��0��6   $��3��6    $��Player X Name:��6-   
�������$��24(�6Y   $
��0 10q�6g   $��Right=�6u   $��Center=�6�   �� 5%   
   $��0��6   $��4��6    $��Player O Name:��6-   
�������$��24(�6Y   $
��0 10q�6g   $��Right=�6u   $��Center=�6�   �� 5&   
   -   5        $��1��5&      $��5��6!   $��Register Names��6.   $��10 20 10 20q�6G      WindowButtonStyle#���   6x   �� 5(   
   -   5        $��_playerX��5(   /   $��1��6   $��3��6"   $��50 30 50 20q�6?   $��24(�6T   �� 5)   
   -   5        $��_playerO��5)   /   $��1��6   $��4��6"   $��50 30 50 20q�6?   $��24(�6T   �� 5*   
   $��16(�6   
���  ��$��0��6S   $��5��6c   $��Center=�6p   $��Center=�6�   ��63   �� *MessageContext+6�   5,      5-      