   M S B A M L   `   `   `  ���� C  ?Cosiness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CosinessCosiness  5clr-namespace:Cosiness.CommandsCosiness.Commands      Cosiness.PersonalUsers   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Cosiness     4commandsclr-namespace:Cosiness.Commands       � 
ResizeMode$  NoResize=� � Title$ Пользователи��$	��450��$	��800��.��� ���#FFE4C4 � ColumnDefinitions �� ��  � RowDefinitions �� $��5.843 ��� $��44.243 ��� $��35 ��� $��50 ��� $
��137* ��� $	��57* ��� $	��92* �.+��� -    ��Name$ 
BorderFind�����#FFE4C4$��1q�$y�Visible=�$��6��
���   �$��0,28.096,0.043,-0.27q�$��2��._�� $��0.165,27.165,0.209,0.443q� �� $
��398* ��� $
��395* � .+��� -    ��Name$ 
RoleSearch��$��21(� �� DisplayMemberPath$ 	Role_name��$��0,0,155.374,1.001q�
����������	#FF9C9C9C$��31��$��Bottom=�$��Right=�$	��237��$��1������  �� EndPoint$	 0,1&� �� 
StartPoint$	 0,0&�.��� 	 � Color$	 	#FFF0F0F0��
 � Offset$
 0Q�� $	 White��$
 1Q��� -    ��Name$ RoleSearchButton�� � ToolTip$W QПоиск по принадлежности к определенной роли��{�.  $��252.643,0,0,1.001q�$��31��$��Bottom=�$
��Left=�$��46��$��1��
�������
�������.���� $��/Images/Find.png���� $��	Роль:��$��21(�$��Right=� �� TextAlignment$ Center=� J� RenderTransformOrigin$ 0.958,0.472&�$��0,0,3.357,1.001q�$��97��$��31��$��Bottom=��� $!��Система поиска��$��21(�$
��Bold"�$ Center=�$
��Left=�$	��297��$��31��$	��Top=�$��0,3,0,0q���Z� c� -    c�Name$ ToolBar��$��2��$��115,1.157,0.043,10.087q�$��1����Z� .@��� -   $
 Undo��$# Отмена действия��$
��Undo��.���� $��/Images/Undo.png���� -   $
 Edit��$ Изменить��$   Cosiness.Commands.DataCommands   Edit#��Z .���� $��/Images/Edit.png���� -   $
 Save��$+ %Сохранить изменения��$
��Save��.���� $��/Images/Save.png���� -   $ Delete��$ Удалить��   Delete#��Z .���� $��/Images/Cancel.png���� -	   $ Refresh��$��Refresh��$# Обновить данные��.���� $��/Images/refresh.png��&   System.Windows.Controls.DataGrid  -
     Name$ DataGridUser��$��1��$��21(�$��2��   
IsReadOnly .    AutoGenerateColumns .  $��6��   RowBackground
 ���w�   AlternatingRowBackground
 �����   	RowHeight$ 25Q� � Cursor$
 Hand��$��0,44.157,0.043,37.73q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	User_ID+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�4  .System.Windows.Controls.DataGridComboBoxColumn  -   РольChange��$ Роль��   DisplayMemberPath$ 	Role_name��   SelectedValuePath$ Role_ID��    
IsReadOnly  .  !   SelectedValueBinding! �� *	Role_ID+$ TwoWay=�$ PropertyChanged=�  $ Имя�� �� *Name+$ TwoWay=�$ PropertyChanged=�  $ Фамилия�� �� *	Surname+$ TwoWay=�$ PropertyChanged=�  $ Отчество�� �� *
Patronymic+$ TwoWay=�$ PropertyChanged=�  $ 
Логин�� �� *Login+$ TwoWay=�$ PropertyChanged=�  $ Пароль�� �� *
Password+$ TwoWay=�$ PropertyChanged=�  $" Последний вход �� �� *Last_login_date+$ TwoWay=��� -   $ 
BackButton��$��21(�$	��100��$
��Left=�$��33��$��Bottom=�$��10,0,0,11.087q�
�������$��
Назад��$��1��
�������" J� CommandBindings" )  #System.Windows.Input.CommandBinding  -   #   Command## Z   -   ## Z   -   $
# Save��  -   $
# Undo��  -   $# Refresh��