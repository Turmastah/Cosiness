   M S B A M L   `   `   `  ���� C  ?Cosiness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CosinessCosiness      Cosiness.AddImages   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Cosiness       � 
ResizeMode$  NoResize=� � Title$+ %Добавление картинок��$	��400��$	��500��.��� ���#FFE4C4.+��� -   $��Upload��$��Сохранить��$��23��$��
335,38,0,0q�$	��Top=�$
��Left=�$��75��
�������
��������� -   $��Browse��$��Выбрать��$��23��$
��Left=�$��	90,10,0,0q�$	��Top=�$��75��
�������
��������� -   $
��Path��$��23��$
��Left=�$��
170,10,0,0q�$	��Top=�$	��240�� �� 
IsReadOnly . �� -   $��Preview��$��51��$
��Left=�$��
416,10,0,0q�$
��Fill=�$	��Top=�$��73��&   System.Windows.Controls.DataGrid  -   $��DataGridImages��   AutoGenerateColumns .  $	��305��$
��Left=�$��0,66,0,-0.357q�$	��Top=�$	��493��
�������   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ Image_ID�  $ 	ImagePath��$ 80  �� $ 	ImagePath�4  .System.Windows.Controls.DataGridTemplateColumn  $ Image��$ 80 	   
IsReadOnly	 . 
   CellTemplate
 �� .R��� $��50��$��50������ $ Bytes��� -    ��Name$ 
BackButton��$��
Назад��$��23��$
��Left=�$��	10,10,0,0q�$	��Top=�$��75��
�������
�������