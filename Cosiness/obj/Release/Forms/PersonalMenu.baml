   M S B A M L   `   `   `  ���� C  ?Cosiness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CosinessCosiness      Cosiness.PersonalMenu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Cosiness       � 
ResizeMode$  NoResize=� � Title$# Меню сотрудника��$	��450��$	��800��.��� ���#FFE4C4 � ColumnDefinitions ��  � RowDefinitions �� �� �� �� �� �� �� .+��� -    ��Name$ toPerOrd��$��Right=�$%��Просмотр заказов��$��1��$��0��$��Center=�$��24(�$	��231��
�������$��61��$��0,58.896,552.043,0.313q�$��2��
��������� -   $ toPerCat��$��Right=�$#��Каталог товаров��$��1��$��0��$��Center=�$��24(�$	��231��
�������$��60��$��0,59.896,552.043,0.313q�$��2��
��������� $��246,59.896,0.043,-0.27q�$ ��/Images/MenuBackground.jpg��$
��Fill=�$��1��$��6���� $��24(�$��0��$��0��$��0,0,-0.957,0.209q�$��2�����	#FFF9D9B4 �� TextAlignment$ Right=��� $
��Bold"�$��36(�$+�%Уют - товары для дома���� �� $��Italic$�$�Ваша роль - ���� $��Italic$�$�сотрудник�� �� TextDecorations Z� �� $�  ���� -   $ toUsers��$��Right=�$��Пользователи��$��3��$��0��$��Center=�$��24(�
�������$��62��$��0,58.687,552.043,59.626q�$	��231��$��3��
��������� $	��144��$
��Left=�$��Close��$��6��$��24(�$��10,0.374,0,-0.27q�$��
Выход��
��������� $��10,0,639.043,5.209q�$��2��$��/Images/Icon.ico��$
��Fill=��� -    ��Name$ userNameBox��$��21(�$��Bottom=�$��519,19.896,0.043,5.209q�$
��Bold"�$��Italic$�$��1�� J� CommandBindings )  #System.Windows.Input.CommandBinding  -   	   Command$	 Close��