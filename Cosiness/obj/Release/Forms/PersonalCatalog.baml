   M S B A M L   `   `   `  ���� C  ?Cosiness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CosinessCosiness  5clr-namespace:Cosiness.CommandsCosiness.Commands      Cosiness.PersonalCatalog   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Cosiness     4commandsclr-namespace:Cosiness.Commands       � 
ResizeMode$  NoResize=� � Title$) #Каталог сотрудника��$	��450��$	��800��.��� ���#FFE4C4 � ColumnDefinitions �� $
��477* ��� $
��316* � � RowDefinitions �� $��20 ��� $��30 ��� $��35 ��� $��50 ��� $
��151* ��� $	��42* ��� $
��122* �.+��� -    ��Name$ 
BorderFind��$��1q�$y�Visible=�$��6��$��2��$��0,0.461,0.043,-0.27q�._�� $&�� 476.165,-263.835,-464.791,-0.643q� �� $
��343* ��� $
��463* � �� �� �� �� �� .+��� -    ��Name$ 
NameSearch��$��21(�$��Center=�$��39��$��10,75,101.409,36.261q�
����������	#FFA6A6A6$��2���� -    ��Name$ NameSearchButton�� � ToolTip$3 -Поиск товара по названию��{�.  $��239,75,58.409,36.261q�$��2��
�������
�������
�������.���� $��/Images/Find.png���� -    ��Name$ StorageSearch��$��21(�	 �� DisplayMemberPath$	 Storage_Name��$��10,74.87,101.409,35.557q�
�������$��1��$��2�����	#FF9C9C9C�� -   $* $НаличиеСкладSearchButton��$\ VПоиск товара по наличию на определенном складе��{�.  $��239,74.87,58.409,35.557q�$��2��$��1��
�������
�������
�������.���� $��/Images/Find.png���� $��Center=�$��Название��$��0��$
��Bold"�$��21(�$��32��$��Center=�
 �� TextAlignment$
 Center=�$��13,43,194.409,0.13q�$	��124���� $��Center=�$��Категория��$
��Bold"�$��21(�$��36��$��Center=�$
 Center=�$��10,38.87,194.409,0.261q�$	��127��$��1���� $��Center=�$!��Система поиска��$��24(�$
��Bold"�$��37��$	��230��$
��Left=�$
 Center=�$��43,1,0,37.13q� J� RenderTransformOrigin$ 0.256,0.207&�c� -    c�Name$ ToolBar1�����#FFE4C4$��115,7,312.043,10.087q�$��2��$��2��.@��� -   $
 Undo��$# Отмена действия��$
��Undo��.���� $��/Images/Undo.png���� -   $	 Add��$ Добавить��$	��New��.���� $��/Images/Add.png���� -	   $
 Edit��$ Изменить��$   Cosiness.Commands.DataCommands   Edit#��Z .���� $��/Images/Edit.png���� -
   $
 Save��$+ %Сохранить изменения��$
��Save��.���� $��/Images/Save.png���� -   $ Delete��$ Удалить��   Delete#��Z .���� $��/Images/Cancel.png���� -   $ Refresh��$��Refresh��$7 1Обновить данные по заказам��.���� $��/Images/refresh.png���� -   $ ToImages��$1��+Редактировать картинки��$��1��$��4.339,7,10.043,10.087q�$��2��
�������
�������&   System.Windows.Controls.DataGrid  -     Name$ DataGridProduct��$��1��$��21(�   
IsReadOnly .    AutoGenerateColumns .  $��6��   RowBackground
 �����   AlternatingRowBackground
 �����   	RowHeight$ 31Q� � Cursor$
 Hand��$��0,29.965,0.661,-0.27q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Product_ID+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  $ Название�� �� *Name+$ TwoWay=�$ PropertyChanged=�  $ Цена�� �� *Price+$ TwoWay=�$ PropertyChanged=�4  .System.Windows.Controls.DataGridComboBoxColumn  -   СекторChange��$ Категория��   DisplayMemberPath$ Storage_Name��   SelectedValuePath$ 
Storage_ID��   
IsReadOnly .     SelectedValueBinding �� *
Storage_ID+$ TwoWay=�$ PropertyChanged=�  -   ImagesChange��$ Картинки��$ Image_ID��$ Image_ID�� .   �� *
Image_ID+$ TwoWay=�$ PropertyChanged=��� -   $ 
BackButton��$��21(�$	��100��$
��Left=�$��33��$��Bottom=�$��10,0,0,10.087q�
�������$��
Назад��$��2��
������� J� CommandBindings )  #System.Windows.Input.CommandBinding  -       Command#  Z   -   #  Z   -   $
  Save��  -   $
  Undo��  -   $	  New��  -   $  Refresh��