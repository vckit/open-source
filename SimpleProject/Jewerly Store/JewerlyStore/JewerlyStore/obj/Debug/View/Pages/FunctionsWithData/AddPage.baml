   M S B A M L   `   `   `  ����G  CJewerlyStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:JewerlyStore.View.Pages.FunctionsWithData)JewerlyStore.View.Pages.FunctionsWithData  5      7    1JewerlyStore.View.Pages.FunctionsWithData.AddPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:JewerlyStore.View.Pages.FunctionsWithData     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  Добавление��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      � $��0��6   .+�5      �� $��Center=�6   $��Center=�5       �� Orientation$ Vertical=�5      .+�5      �� -   5         ��Name$ imgLoad��5      $	��200��5      $	��200��5      $��0,0,0,20q�5      �� 5       -   5         ��Name$ openBtn��5       +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5!      $��Выбрать��5"      
���   �
�������$	��200��5%      $��35��5&      6)   5'      5(      � 5*      $��1��6   .+�5+      �� $��Center=�6   $��Center=�5,      $ Vertical=�5-      .+�5.      �� $ 
Horizontal=�6!   $��0,0,0,20q�5/   !   .+�50      �� -   5         ��Name$ 
jewNameTxb��50   "    %  !MaterialDesignFloatingHintTextBox#��[  51   "   $��15(�52   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Изделие��53   "   $	��200��54   "   55      �� 56      $ 
Horizontal=�6!   $��0,0,0,20q�57   !   .+�58      �� -   5        	 ��Name$	 categoryCmb��58   #    & "MaterialDesignFloatingHintComboBox#��[ 59   "   $��15(�5:   !   $ Категория��5;   #   $	��200��5<   "   5=      �� 5>      $ 
Horizontal=�6!   .+�5?      �� -   5        $ materialTxb��5?   "   #��[  5@   "   $ Материал��5A   "   $��15(�5B   "   $	��200��5C   "   5D      �� 5E      $ 
Horizontal=�6!   $��0,0,0,20q�5F   !   .+�5G      �� -   5        $ priceTxb��5G   "   $��0,10,0,0q�5H   "   $ Цена��5J   "   #��[  5K   "   $��15(�5M   "   $	��200��5N   "   5O      �� 5P      $ 
Horizontal=�6!   $��0,0,0,20q�5Q   !   .+�5R      �� -   5        $ 	heightTxb��5R   "   #��[  5T   "   $ Высота��5U   "   $��15(�5V   "   $	��200��5W   "   5X      �� 5Y      $ 
Horizontal=�6!   $��0,0,0,20q�5Z   !   .+�5[      �� -   5        $ widthTxb��5[   "   #��[  5]   "   $ Ширина��5^   "   $��15(�5_   "   $	��200��5`   "   5a      �� 5b      $ 
Horizontal=�6!   .+�5c      �� -	   5        $ 	weightTxb��5c   "   $ Вес��5e   "   #��[  5f   "   $��15(�5g   "   $	��200��5h   "   5i      �� 5j      .+�5k      �� -
   5        $��txbCount��5k   "   $' !Количество товара��5m   "   #��[  5n   "   $��15(�5o   "   $��0,10,0,0q�5p   "   $	��200��5q   "   5r      5s      5t      5u      � 5w   
   $��1��6   .+�5x      �� $��Center=�6   $��Center=�5y      $ 
Horizontal=�5z      .+�5{      �� -   5        $ backBtn��5{      $ 5��5|      $��
Назад��5}      
���   �
�������$	��200��5�      $��35��5�      $��0,0,20,0q�5�      6+   �� 5�      -   5        $ addBtn��5�      $��Добавить��5�      
���   �
�������$ 5��5�      $	��200��5�      $��35��5�      6%   5�      5�      5�      5�      