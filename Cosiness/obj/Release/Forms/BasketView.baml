   M S B A M L   `   `   `  ���� C  ?Cosiness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CosinessCosiness      Cosiness.BasketView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Cosiness     -   $	��600��$	��800��  � 
ResizeMode$  NoResize=� � Title$' !Оформление заказа��.��� ���#FFE4C4 � RowDefinitions �� $
��124* ��� $
��447* �.+��� -    ��Name$ BasketListView��
�������$��Center=�$	��519�� �� PanningMode$
 Both=���. $��Visible=�$	��Top=�$	��607��$��0,0,186.043,0q����	#FFB1B1B1$��2�� � ContextMenu �� .@�m� -    m�Name$ DelMEnu��$(��"Удалить из корзины������ .R��  � Orientation$ Vertical=�$��Center=�$	��800������ .R�� $��20q�$	��350����. $��Visible=� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��Center=� �� TextAlignment$ Center=�$	��390��$
��Wrap=�$��Center=�$	��5 5q�$��26(�$��0������ *Name+�� $��2������ *Price+	 �� Mode$	 OneWay=�
 �� StringFormat$
 Цена: {0}���� -    ��Name$	 Buy��$*��$Сформировать 
заказ��$��21(�$��Center=�$
��Left=�$��55��$��612,382.617,0,0q�$	��Top=�$	��171��$��1��
�������
��������� -   $
 Back��$��
Назад��$��21(�$��Center=�$
��Left=�$��38��$��10,399.617,0,0q�$	��Top=�$	��101��$��1��
�������
��������� -   $	 Del��$��Удалить товар��$��Center=�$��21(�$
��Left=�$��38��$��436,399.617,0,0q�$	��Top=�$	��171��$��1��
�������
��������� $��Ваш заказ:��$��21(�$
��Left=�$��63��$��
607,-3,0,0q�$	��Top=�$	��186�� J� RenderTransformOrigin$ 0.518,0.119&�$
��Bold"��� -    ��Name$ 	resultSum��$#��Итоговая сумма:
��$��21(�$
��Left=�$��82��$��608,295.617,0,0q�$	��Top=�$	��185��$��1���� -    ��Name$ 	SurnameBl��$
��Wrap=�$��21(�$��608,102.617,0.043,269.991q�$��1���� $�Ваш���� $�а фамилия���� $�:���� -	   $ NameBl��$��Ваше имя:��$
��Wrap=�$��21(�$
��Left=�$��73��$	��Top=�$	��186��$��607,29.617,0,0q�$y�Visible=�$��1���� -
   $ PatronymicBl��$
��Wrap=�$��21(�$��607,176.617,0.043,195.991q�$��1���� $�	Ваше ���� $�отчество���� $�:���� -    ��Name$ SurnameInput��$��21(�$��0,147.617,0,0q� �� TextWrapping$
 Wrap=�$��1��$��40��$	��Top=�$
��Left=�$	��187����Z� ��Z� �� -   $ PatronymicInput��$��21(�$��0,220.617,0,0q�$
 Wrap=�$��1��$��39��$	��Top=�$
��Left=�$	��188����Z� ��Z� �� -   $ 	NameInput��$��21(�$
 Wrap=�$��1,74.617,0,0q�$��1��$��39��$	��Top=�$
��Left=�$	��187����Z� ��Z� �� -   $ PointCh��$��Точка выдачи:��$��21(�$
��Left=�$��38��$��
608,60,0,0q�$	��Top=�$	��185���� -    ��Name$ Points��$��21(� �� DisplayMemberPath$
 Name�� �� SelectedValuePath$ 
Product_ID��$��607,98,-4.957,0q�
�������
�������$��2��$��56��$	��Top=�$
��Left=�$	��191��