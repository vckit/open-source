   M S B A M L   `   `   `  ����G  CJewerlyStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:JewerlyStore.View.Pages.FunctionsWithData)JewerlyStore.View.Pages.FunctionsWithData  5      ;    5JewerlyStore.View.Pages.FunctionsWithData.PaymentPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:JewerlyStore.View.Pages.FunctionsWithData     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$)  #Оформление покупки��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $	��Top=�6   $
��Left=�5      .+�5      �� -   5        $��btnBack��5      $��
Назад��5      $��10q�5      
�������
���   �$	��150��5      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5      5      �� 5   
   $��Center=�6   $��Center=�5      .+�5      �� $	��Top=�6   $
��Left=�5      .+�5       �� $!��Оформите заказ��6   $��14(�5!      5"      �� 5#      -   5        $��cmbSelectClient��5#      $	��400��5$       &  "MaterialDesignFloatingHintComboBox#��[  5%      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$% Выберите клиента��5&      �� 5'       �� Orientation$ 
Horizontal=�6   .+�5(      �� -   5        $��cmbSelectJewely��5(      $	��280��5)      #��[  5+      $% Выберите изделие��5,      �� 5.      -   5        $��txbCount��5.      $��30��5/      $��15(�50      $��1��51      $��10,0,0,0q�52      $��Center=�53      �� 54      -   5        $��+��54      
�������
���   �57      �� 58      -   5        $��-��58      
�������
���   �5;      5<      �� 5>      -   5        $��txbTotalPrice��5>       % !MaterialDesignFloatingHintTextBox#��[ 5?      $ Итоговая цена��5@      �� 5A      -   5        $��btnOrderDone��5E      $(��"Добавить в корзину��5A      
�������
���   �$��0,10,0,0q�5D      $ 15��5G      5I      � 5J   
   $��1��6    � RowDefinitions 5K      �� 5L      $��8* �6    �� 5M      $��* �6    .+�5O      &   System.Windows.Controls.DataGrid  -	   5        $��
BasketList��5R      $��0,10,0,0q�5O      $��0��5P         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5S         Columns 5T      0  *System.Windows.Controls.DataGridTextColumn  5U      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ФИО Клиента��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6>   �� *Client.FullName+  5V      $	 Бижютерий��6)   
 6<   �� *Jewelry.JewName+  5W      $	 Количество��6)   
 6=   �� *Count+  5X      $	 Цена��6)   
 67   �� *
TotalPrice+5Z      �� 5[      $��1��6   $ 
Horizontal=�5\      $��Center=�5]      $��Center=�5^      .+�5_      �� -
   5        $��btnGetBasket��5c      $��Оформить��5_      
�������
���   �$��0,5,0,0q�5b      $	��250��5d      $ 15��5f      �� 5g      -   5        $��	btnRemove��5k      $��Удалить��5g      
�������
���   �$��10,5,0,0q�5j      $	��250��5l      $ 15��5n      5o      5p      5q      5r      