   M S B A M L   `   `   `  ����G  CJewerlyStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:JewerlyStore.View.Pages.FunctionsWithData)JewerlyStore.View.Pages.FunctionsWithData  5      8    2JewerlyStore.View.Pages.FunctionsWithData.EditPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Clocal7clr-namespace:JewerlyStore.View.Pages.FunctionsWithData  5        N� Title$'  !Обновление данных��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      � $��0��6   .+�5      �� $��Center=�6   $��Center=�5       �� Orientation$ Vertical=�5      .+�5      �� -   5         ��Name$ imgLoad��5      $	��200��5      $	��200��5      $��0,0,0,20q�5      �� 5       -   5         ��Name$ openBtn��5       +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5!      $��Выбрать��5"      
���   �
�������$��35��5%      6)   5&      5'      � 5)      $��1��6   .+�5*      �� $��Center=�6   $��Center=�5+      $ Vertical=�5,      .+�5-      �� $ 
Horizontal=�6!   $��0,0,0,20q�5.   !   .+�5/      �� -   5         ��Name$ 
jewNameTxb��5/   "    %  !MaterialDesignFloatingHintTextBox#��[  50   "   $��15(�51   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Изделие��52   "   $	��200��53   "   54      �� 55      $ 
Horizontal=�6!   $��0,0,0,20q�56   !   .+�57      �� -   5        	 ��Name$	 categoryCmb��57   #    & "MaterialDesignFloatingHintComboBox#��[ 58   "   $��15(�59   !   $ Категория��5:   #   $	��200��5;   "   5<      �� 5=      $ 
Horizontal=�6!   .+�5?      �� -   5        $ materialTxb��5?   "   #��[  5@   "   $ Материал��5A   "   $��15(�5B   "   $	��200��5C   "   5D      �� 5E      $ 
Horizontal=�6!   $��0,0,0,20q�5F   !   .+�5G      �� -   5        $ priceTxb��5G   "   $ Цена��5I   "   #��[  5J   "   $��15(�5L   "   $	��200��5M   "   5N      �� 5O      $ 
Horizontal=�6!   $��0,0,0,20q�5P   !   .+�5Q      �� -   5        $ 	heightTxb��5Q   "   #��[  5S   "   $ Высота��5T   "   $��15(�5U   "   $	��200��5V   "   5W      �� 5X      $ 
Horizontal=�6!   $��0,0,0,20q�5Y   !   .+�5Z      �� -   5        $ widthTxb��5Z   "   #��[  5\   "   $ Ширина��5]   "   $��15(�5^   "   $	��200��5_   "   5`      �� 5a      $ 
Horizontal=�6!   .+�5b      �� -	   5        $ 	weightTxb��5b   "   $ Вес��5d   "   #��[  5e   "   $��15(�5f   "   $	��200��5g   "   5h      �� 5i      .+�5j      �� -
   5        $��txbCount��5j   "   $' !Количество товара��5l   "   #��[  5m   "   $��15(�5n   "   $��0,10,0,0q�5o   "   $	��200��5p   "   5q      5r      5s      5t      � 5v   
   $��1��6   .+�5w      �� $��Center=�6   $��Center=�5x      $ 
Horizontal=�5y      .+�5z      �� -   5        $ backBtn��5z      $ 5��5{      $��
Назад��5|      
���   �
�������$	��200��5      $��35��5�      $��0,0,20,0q�5�      6+   �� 5�      -   5        $ editBtn��5�      $��Изменить��5�      $ 5��5�      
���   �
�������$	��200��5�      $��35��5�      6%   5�      5�      5�      5�      