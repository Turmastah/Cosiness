   M S B A M L   `   `   `  ����B  >PC_Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PC_ShopPC_Shop  5   	       PC_Shop.UserOrders   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:PC_Shop     5   	   -   5          � 
ResizeMode$  NoResize=�5	   	    � Title$% PC_Shop - Ваши заказы��5
   	   $	��600��6'   $	��800��64   .��5      � 
�������.+�5   
   �� $7��1Информация о ваших заказах��6   $
��Left=�65   $��36��6P   $��	10,10,0,0q�6\   $	��Top=�6o   $	��167��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
userOrders��5         AutoGenerateColumns .  $��Center=�6C   $	��515��6`   $��0,46,-3.957,0q�6m   $	��Top=�6�   $	��797��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$, &Дата создания заказа��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *
Order_Date+ �� Mode$ OneWay=�6q   5      �� 5   
   -   5         ��Name$ Backtocatalog��5      $��
Назад��6(   $
��Left=�68   $��34��6S   $��
695,12,0,0q�6_   $	��Top=�6s   $��88��6�   6�   �� 5   
   -   5        $ 
ToGuaranty��5      $��Гарантия��6%   $
��Left=�68   $��34��6S   $��
602,12,0,0q�6_   $	��Top=�6s   $��88��6�   6�   5      5      