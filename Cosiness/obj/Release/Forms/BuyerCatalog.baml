   M S B A M L   `   `   `  ���� C  ?Cosiness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CosinessCosiness      Cosiness.BuyerCatalog   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Cosiness       � Title$)  #Каталог покупателя��$	��600��$	��800�� � 
ResizeMode$ NoResize=���. $��Visible=�.��� ���#FFE4C4��. $��Visible=�.+��� -    ��Name$ productsListView��$��16(�$��Center=�$	��491����. $��Visible=�$	��Top=�$	��793��$��0,80,0.043,-0.009q�
�������
������� � ContextMenu �� -    ��Name$
 Menu��.@�m� -   $(��"Добавить в корзину������ .R��  � Orientation$ 
Horizontal=�$��Center=�$	��800������ .R�� $��20q�$	��350����. $��Visible=� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��Center=� �� TextAlignment$ Center=�$	��390��$
��Wrap=�$��Center=�$	��5 5q�$��16(�$��0������ *Name+�� $	��300��$	��200��$��1��$
��Fill=�$��Center=�$��5q�����  �� Path$ Images.Bytes��� $��16(�$��2������ *Price+	 �� Mode$	 OneWay=�
 �� StringFormat$
 Цена: {0}���� -    ��Name$ ClearBasket��$%��Очистить корзину��$
��Left=�$��34��$��
389,46,0,0q�$	��Top=�$	��194��$��21(�$y�Visible=� J� RenderTransformOrigin$ 0.658,0.438&�
����������	#FFEAEAEA�� -    ��Name$ 
Namesearch��$��21(�$'��!Поиск по названию:��$
��Left=�$��33��$��
176,10,0,0q�$	��Top=�$	��208��$ -0.209,0.55&��� -    ��Name$ SearchInput��$��34��$��389,10,0.043,0q�$	��Top=�$��16(��� -   $ 	AddBasket��$(��"Добавить в корзину��$
��Left=�$��34��$��
583,46,0,0q�$	��Top=�$	��210��$��21(�$y�Visible=�
����������	#FFEAEAEA�� -   $
 Back��$��
Назад��$��21(�$
��Left=�$��34��$��	10,10,0,0q�$	��Top=�$	��106��
�������