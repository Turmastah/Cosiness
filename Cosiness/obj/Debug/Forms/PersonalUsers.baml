   M S B A M L   `   `   `  ����C  ?Cosiness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CosinessCosiness  5   	   5clr-namespace:Cosiness.CommandsCosiness.Commands  5   	       Cosiness.PersonalUsers   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Cosiness     5   	   4commandsclr-namespace:Cosiness.Commands     5   	     � 
ResizeMode$  NoResize=�5	   	    � Title$ Пользователи��5
   	   $	��450��6   $	��800��6+   .��5      � ���#FFE4C4 � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��5.843 �6   6.   �� 5      $��44.243 �6   6.   �� 5      $��35 �6   6*   �� 5      $��50 �6   6*   �� 5      $
��137* �6   6,   �� 5      $	��57* �6   �� 5      $	��92* �6   .+�5   
   �� -   5         ��Name$ 
BorderFind��5      ���#FFE4C4$��1q�5   '   $y�Visible=�5      $��6��5      
���   �$��0,28.096,0.043,-0.27q�6B   $��2��6`   ._�5      � $��0.165,27.165,0.209,0.443q�6    5      �� 5      $
��398* �6'   �� 5      $
��395* �6'    5!      .+�5$      �� -   5         ��Name$ 
RoleSearch��5$      $��21(�6/    �� DisplayMemberPath$ 	Role_name��6=   $��0,0,155.374,1.001q�6�   
����������	#FF9C9C9C$��31��6�   $��Bottom=�6�   $��Right=�6�   $	��237��6  $��1��6  ��5%      �� 5&       �� EndPoint$	 0,1&�6.    �� 
StartPoint$	 0,0&�6=   .��5'      � 	 � Color$	 	#FFF0F0F0��6+   
 � Offset$
 0Q�6=   � 5(      $	 White��6+   $
 1Q�69   5)      5+      �� 5,      -   5         ��Name$ RoleSearchButton��5,       � ToolTip$W QПоиск по принадлежности к определенной роли��63   {�.  $��252.643,0,0,1.001q�6�   $��31��6�   $��Bottom=�6�   $
��Left=�6�   $��46��6�   $��1��6  
�������
�������.��5-      �� $��/Images/Find.png��6   5.      �� 5/      $��	Роль:��6   $��21(�6)   $��Right=�67    �� TextAlignment$ Center=�6S    J� RenderTransformOrigin$ 0.958,0.472&�6j   $��0,0,3.357,1.001q�6�   $��97��6�   $��31��6�   $��Bottom=�6�   �� 50      $!��Система поиска��6   $��21(�62   $
��Bold"�6[   $ Center=�6m   $
��Left=�6�   $	��297��6�   $��31��6�   $	��Top=�6�   $��0,3,0,0q�6�   ��6@   Z� 6�   51      52      c� 53   
   -   5         c�Name$ ToolBar��53      $��2��6#   $��115,1.157,0.043,10.087q�67   $��1��6W   ��6d   Z� .@�54      �� -   5        $
 Undo��54      $# Отмена действия��6#   $
��Undo��6=   .��55      �� $��/Images/Undo.png��6   56      �� 57      -   5        $
 Edit��57      $ Изменить��6#   $   Cosiness.Commands.DataCommands   Edit#��Z 66   .��58      �� $��/Images/Edit.png��6   59      �� 5;      -   5        $
 Save��5;      $+ %Сохранить изменения��6#   $
��Save��6A   .��5<      �� $��/Images/Save.png��6   5=      �� 5>      -   5        $ Delete��5>      $ Удалить��6%      Delete#��Z 67   .��5?      �� $��/Images/Cancel.png��6   5@      �� 5A      -	   5        $ Refresh��5A      $��Refresh��6&   $# Обновить данные��68   .��5B      �� $��/Images/refresh.png��6   5C      5D      &   System.Windows.Controls.DataGrid  5E   
   -
   5          Name$ DataGridUser��5E      $��1��5F      $��21(�5G      $��2��5H         
IsReadOnly .    AutoGenerateColumns .  $��6��5K         RowBackground
 �����   AlternatingRowBackground
 �����   	RowHeight$ 25Q�5N       � Cursor$
 Hand��5O      $��0,44.157,0.043,37.73q�6!      Columns 5P      0  *System.Windows.Controls.DataGridTextColumn  5Q      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	User_ID+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�4  .System.Windows.Controls.DataGridComboBoxColumn  5R      -   5        РольChange��$ Роль��5R   =      DisplayMemberPath$ 	Role_name��6K      SelectedValuePath$ Role_ID��6�       
IsReadOnly  .  !   SelectedValueBinding! 6i   �� *	Role_ID+$ TwoWay=�$ PropertyChanged=�6�     5S      $ Имя��6%    62   �� *Name+$ TwoWay=�$ PropertyChanged=�  5T      $ Фамилия��6%    66   �� *	Surname+$ TwoWay=�$ PropertyChanged=�  5U      $ Отчество��6%    67   �� *
Patronymic+$ TwoWay=�$ PropertyChanged=�  5V      $ 
Логин��6%    64   �� *Login+$ TwoWay=�$ PropertyChanged=�  5W      $ Пароль��6%    65   �� *
Password+$ TwoWay=�$ PropertyChanged=�  5X      $" Последний вход ��6%    6>   �� *Last_login_date+$ TwoWay=�5Z      �� 5[   
   -   5        $ 
BackButton��5[      $��21(�6%   $	��100��63   $
��Left=�6?   $��33��6s   $��Bottom=�6   $��10,0,0,11.087q�6�   
�������$��
Назад��6�   $��1��6�   
�������6�   5\      " J� CommandBindings" 5]      )  #System.Windows.Input.CommandBinding  5^   
   -   5        #   Command## Z 5^      6t     5_   
   -   5        ## Z 5_      6p     5`   
   -   5        $
# Save��5`      6S     5a   
   -   5        $
# Undo��5a      6S     5b   
   -   5        $# Refresh��5b      6Y   5d      