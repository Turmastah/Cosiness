   M S B A M L   `   `   `  ���� B  >PC_Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PC_ShopPC_Shop      PC_Shop.UserOrders   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:PC_Shop     -     � 
ResizeMode$  NoResize=� � Title$% PC_Shop - Ваши заказы��$	��600��$	��800��.��� 
�������.+��� $7��1Информация о ваших заказах��$
��Left=�$��36��$��	10,10,0,0q�$	��Top=�$	��167��&   System.Windows.Controls.DataGrid  -     Name$ 
userOrders��   AutoGenerateColumns .  $��Center=�$	��515��$��0,46,-3.957,0q�$	��Top=�$	��797��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$, &Дата создания заказа��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Order_Date+ �� Mode$ OneWay=��� -    ��Name$ Backtocatalog��$��
Назад��$
��Left=�$��34��$��
695,12,0,0q�$	��Top=�$��88���� -   $ 
ToGuaranty��$��Гарантия��$
��Left=�$��34��$��
602,12,0,0q�$	��Top=�$��88��