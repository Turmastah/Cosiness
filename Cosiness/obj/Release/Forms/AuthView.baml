   M S B A M L   `   `   `  ���� C  ?Cosiness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CosinessCosiness      Cosiness.AuthView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Cosiness       � 
ResizeMode$  NoResize=� � Title$ Авторизация��$	��450��$	��450��.��� ���#FFE4C4.+��� -    ��Name$ 
LoginInput��$
��Left=�$	��Top=�$��21(�$��40��$��	10,50,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��225��
��������� -    ��Name$ ButtonEnterApp��$	��Top=�$
��Left=�$��21(�$��
Войти��$��40��$��
10,186,0,0q�$	��225��
�������
��������� -   $ ButtonEnterAsGuest��$	��Top=�$
��Left=�$��21(�$"��Войти как гость��$��40��$	��225��$��
10,371,0,0q����	#FFFDFDFD���	#FFFDFDFDG� -    G�Name$ PasswordInput��$��21(�$
��Left=�$��39��$��
10,129,0,0q�$	��Top=�$	��225��
��������� $��Логин:��$��21(�$
��Left=�$��35��$��	10,10,0,0q�$	��Top=�$��90���� $��Пароль:��$��21(�$
��Left=�$��34��$��	10,95,0,0q�$	��Top=�$��90���� -   $ Registration��$*��$Зарегистрироваться��$	��Top=�$
��Left=�$��21(�$��40��$��
10,231,0,0q�$	��225��
�������
�������� -    �Name$ CaptchaGrid��$��240,10,-79.73,252.73q�.+��� $ ��Введите капчу:��$��21(�$
��Left=�$	��231��$��-5,0,0,0q�$��42��$	��Top=��� -   $ CapthaInput��$��	10,42,0,0q�$
��Left=�$	��135��$��37��$	��Top=�
��������� -    ��Name$ Captcha��$
��Left=�$
��Wrap=�$��0,84,0,0q�$	��151��$
��Bold"�$��16(� �� TextAlignment$ Center=�$��40��$	��Top=��� $�loading���� ���	#FFF4F4F5$
��Left=�$��	41,96,0,0q�
���   �$��80��$��2��$	��Top=��� $��Close��$��21(�$��305,371,0,0q�$��
Выход��$��40��$	��Top=�$
��Left=�$	��128��
�������
�������
���   �	 J� CommandBindings	 )  #System.Windows.Input.CommandBinding  -	   
   Command$
 Close��