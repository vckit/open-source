   M S B A M L   `   `   `  ����G  CJewerlyStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:JewerlyStore.View.Pages.FunctionsWithData)JewerlyStore.View.Pages.FunctionsWithData  5      ;    5JewerlyStore.View.Pages.FunctionsWithData.HistoryPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:JewerlyStore.View.Pages.FunctionsWithData     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$#  История заказов��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��8* �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $
��Left=�6   $��0��5       �� Orientation$ 
Horizontal=�5      .+�5      �� -   5        $��
Назад��5      $	��100��5      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5      
�������
���   �$��5q�5       5!      5"      �� 5#      $��1��6   $ 
Horizontal=�5$      .+�5%      (  "System.Windows.Controls.DatePicker  -   5        $��dtpDate��5%      $	��200��5&      $��10q�5'      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Выберите дату��5)         MaterialDesignDatePicker#��[  5*      �� 5+      -   5        $��Сбросить��5+      
�������
���   �
���   �$ 5��5/      $��10,0,0,0q�50      51      52      53      � 54   
   $��1��6   .+�55      �� -   5        $��
ChecksList��55      ��56      �� 57      .R�58      �� .+�59      ��  �� ContentStringFormat$ ID: {0}��6;   ��6$   �� *ID+6;   �� 5:      $  ФИО Клиента: {0}��6H   ��6$   �� *Client.FullName+6H   �� 5;      $ Изделие: {0}��6P   ��6$   �� *Jewelry.JewelryCheckGet+6P   �� 5<      $A ;Количество проданного товара: {0}��6>   ��6$   �� *Count+6>   �� 5=      $ Телефон: {0}��6E   ��6$   �� *Client.Phone+6E   �� 5>      $" Дата покупки: {0}��6=   ��6$   �� *Date+6=   �� 5?      $1 +Итоговая цена: {0} рублей��6C   ��6$   �� *
TotalPrice+6C   5@      5A      5C      5D      � 5E   
   $��2��6   .+�5F      �� $��Right=�6   $��Center=�5G      .+�5H      �� -   5        $��Вывести PDF��5H      
�������
���   �$	��200��5K      $��0,0,10,0q�5L      $ 10��5M      5N      5O      5P      5Q      5R      