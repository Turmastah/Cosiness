   M S B A M L   `   `   `  ����C  ?Cosiness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CosinessCosiness  5   	   5clr-namespace:Cosiness.CommandsCosiness.Commands  5   	       Cosiness.PersonalOrders   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Cosiness     5   	   4commandsclr-namespace:Cosiness.Commands     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$) #Заказы покупателей��5
   	   $	��450��6$   $	��800��61   .��5      � ���	#FFF9D9B4 � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��20 �6   6+   �� 5      $��30 �6   6*   �� 5      $��35 �6   6*   �� 5      $��50 �6   6*   �� 5      $
��151* �6   6,   �� 5      $	��42* �6   �� 5      $
��122* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	orderGrid��5      $y�Visible=�6&   $��1��5      $��16(�5      $��2��5         
IsReadOnly .    AutoGenerateColumns .  $��6��5         RowBackground
 �����   AlternatingRowBackground
 �����	   	RowHeight$	 25Q�5"      
 � Cursor$

 Hand��5#      $��0,29.965,0.043,-0.27q�6!      Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ ID заказа��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
Order_ID+ �� Mode$ TwoWay=�  5&      $, &Дата создания заказа��6%    6C   �� *
Order_Date+$ TwoWay=�  5'      $ ID покупателя��6%    6<   �� *	User_ID+$ TwoWay=�  5(      $ Имя��6%    62   �� *Name+$ TwoWay=�  5)      $ Фамилия��6%    66   �� *	Surname+$ TwoWay=�  5*      $ Отчество��6%    67   �� *
Patronymic+$ TwoWay=�4  .System.Windows.Controls.DataGridComboBoxColumn  5+      -   5        
Точка��$ Точка выдачи��5+   8      DisplayMemberPath$
 Name��6N      SelectedValuePath$ Point_ID��6�      SelectedValueBinding 6g   �� *
Point_ID+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�     5,      -   5        Статус��$ Статус заказа��5,   9   $ Status��6P   $ 	Status_ID��6�    6k   �� *	Status_ID+$ TwoWay=�$ PropertyChanged=�6�   5.        5/   
   -   5        $ ordersGridProd��5/      $y�Hidden=�6+   $��1��50      $��16(�51      $��2��52       .  .  $��6��55      
 ���w�
 �����$	 25Q�58      $

 Hand��59      $��0,29.965,0.043,9.73q�6!    5:        5;      $ ID покупки��6%    69   �� *	List_ID+$ TwoWay=�  5<      $ ID заказа��6%    68   �� *
Order_ID+$ TwoWay=�  5=      -   5        Products��$ Товары��5=   ;   $
 Name��6K   $ 
Product_ID��6�    6d   �� *
Product_ID+$ TwoWay=�$ PropertyChanged=�6�   5?      �� 5@   
   -   5         ��Name$ 
BackButton��5@      $��21(�6&   $	��100��64   $
��Left=�6@   $��33��6t   $��Bottom=�6�   $��10,0,0,10.087q�6�   
�������$��
Назад��6�   $��2��6�   
�������6�   c� 5A   
   -   5         c�Name$ ToolBar��5A      $��2��6#   $��115,7,0.043,10.087q�67   $��2��6S   ��6d   Z� .@�5B      �� -   5        $
 Undo��5B       � ToolTip$# Отмена действия��6#   $
��Undo��6=   .��5C      �� $��/Images/Undo.png��6   5D      �� 5F      -	   5        $	 Add��5F      $ Добавить��6"   $	��New��65   .��5G      �� $��/Images/Add.png��6   5H      �� 5I      -
   5        $
 Edit��5I      $ Изменить��6#   $   Cosiness.Commands.DataCommands   Edit#��Z 66   .��5J      �� $��/Images/Edit.png��6   5K      �� 5M      -   5        $
 Save��5M      $+ %Сохранить изменения��6#   $
��Save��6A   .��5N      �� $��/Images/Save.png��6   5O      �� 5P      -   5        $ Delete��5P      $ Удалить��6%      Delete#��Z 67   .��5Q      �� $��/Images/Cancel.png��6   5R      �� 5S      -   5        $ Refresh��5S      $��Refresh��6&   $7 1Обновить данные по заказам��68   .��5T      �� $��/Images/refresh.png��6   5U      �� 5V      -   5        $ ToOrders��5V      $��Заказы��6'   $��33��68   $��21(�6D   
�������$��0,-2,0,-2.617q�6}   $	��119��6�   �� 5W      -   5        $ ToOrderProd��5W      $+��%Редактировать заказ��6*   $��21(�6H   $��33��6V   
�������$��0,-2,0,-2.617q�6�   $	��235��6�   5X      5Y       J� CommandBindings 5Z      )  #System.Windows.Input.CommandBinding  5[   
   -   5           Command# Z 5[      6t     5\   
   -   5        # Z 5\      6p     5]   
   -   5        $
 Save��5]      6S     5^   
   -   5        $
 Undo��5^      6S     5_   
   -   5        $	 New��5_      6Q     5`   
   -   5        $ Refresh��5`      6Y   5b      