   M S B A M L   `   `   `  ���� C  ?Cosiness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CosinessCosiness  5clr-namespace:Cosiness.CommandsCosiness.Commands      Cosiness.PersonalOrders   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Cosiness     4commandsclr-namespace:Cosiness.Commands       � 
ResizeMode$  NoResize=� � Title$) #Заказы покупателей��$	��450��$	��800��.��� ���	#FFF9D9B4 � ColumnDefinitions �� ��  � RowDefinitions �� $��20 ��� $��30 ��� $��35 ��� $��50 ��� $
��151* ��� $	��42* ��� $
��122* �.+�&   System.Windows.Controls.DataGrid  -     Name$ 	orderGrid��$y�Visible=�$��1��$��16(�$��2��   
IsReadOnly .    AutoGenerateColumns .  $��6��   RowBackground
 �����   AlternatingRowBackground
 �����	   	RowHeight$	 25Q�
 � Cursor$

 Hand��$��0,29.965,0.043,-0.27q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID заказа��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Order_ID+ �� Mode$ TwoWay=�  $, &Дата создания заказа�� �� *
Order_Date+$ TwoWay=�  $ ID покупателя�� �� *	User_ID+$ TwoWay=�  $ Имя�� �� *Name+$ TwoWay=�  $ Фамилия�� �� *	Surname+$ TwoWay=�  $ Отчество�� �� *
Patronymic+$ TwoWay=�4  .System.Windows.Controls.DataGridComboBoxColumn  -   
Точка��$ Точка выдачи��   DisplayMemberPath$
 Name��   SelectedValuePath$ Point_ID��   SelectedValueBinding �� *
Point_ID+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  -   Статус��$ Статус заказа��$ Status��$ 	Status_ID�� �� *	Status_ID+$ TwoWay=�$ PropertyChanged=�  -   $ ordersGridProd��$y�Hidden=�$��1��$��16(�$��2�� .  .  $��6��
 ���w�
 �����$	 25Q�$

 Hand��$��0,29.965,0.043,9.73q�   $ ID покупки�� �� *	List_ID+$ TwoWay=�  $ ID заказа�� �� *
Order_ID+$ TwoWay=�  -   Products��$ Товары��$
 Name��$ 
Product_ID�� �� *
Product_ID+$ TwoWay=�$ PropertyChanged=��� -    ��Name$ 
BackButton��$��21(�$	��100��$
��Left=�$��33��$��Bottom=�$��10,0,0,10.087q�
�������$��
Назад��$��2��
�������c� -    c�Name$ ToolBar��$��2��$��115,7,0.043,10.087q�$��2����Z� .@��� -   $
 Undo�� � ToolTip$# Отмена действия��$
��Undo��.���� $��/Images/Undo.png���� -	   $	 Add��$ Добавить��$	��New��.���� $��/Images/Add.png���� -
   $
 Edit��$ Изменить��$   Cosiness.Commands.DataCommands   Edit#��Z .���� $��/Images/Edit.png���� -   $
 Save��$+ %Сохранить изменения��$
��Save��.���� $��/Images/Save.png���� -   $ Delete��$ Удалить��   Delete#��Z .���� $��/Images/Cancel.png���� -   $ Refresh��$��Refresh��$7 1Обновить данные по заказам��.���� $��/Images/refresh.png���� -   $ ToOrders��$��Заказы��$��33��$��21(�
�������$��0,-2,0,-2.617q�$	��119���� -   $ ToOrderProd��$+��%Редактировать заказ��$��21(�$��33��
�������$��0,-2,0,-2.617q�$	��235�� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command# Z   -   # Z   -   $
 Save��  -   $
 Undo��  -   $	 New��  -   $ Refresh��