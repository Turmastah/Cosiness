   M S B A M L   `   `   `  ����C  ?Cosiness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CosinessCosiness  5   	       Cosiness.AddImages   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Cosiness     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$+ %Добавление картинок��5	   	   $	��400��6%   $	��500��62   .��5
      � ���#FFE4C4.+�5   
   �� -   5        $��Upload��5      $��Сохранить��6   $��23��63   $��
335,38,0,0q�6?   $	��Top=�6T   $
��Left=�6�   $��75��6�   
�������
�������6�   �� 5   
   -   5        $��Browse��5      $��Выбрать��6   $��23��61   $
��Left=�6=   $��	90,10,0,0q�6X   $	��Top=�6l   $��75��6�   
�������
�������6�   �� 5   
   -   5        $
��Path��5      $��23��6   $
��Left=�6*   $��
170,10,0,0q�6E   $	��Top=�6Z   $	��240��6r    �� 
IsReadOnly . 6   �� 5   
   -   5        $��Preview��5      $��51��6   $
��Left=�6+   $��
416,10,0,0q�6F   $
��Fill=�6[   $	��Top=�6j   $��73��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��DataGridImages��5   n      AutoGenerateColumns .  $	��305��6/   $
��Left=�6<   $��0,66,0,-0.357q�6W   $	��Top=�6�   $	��493��6�   
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$ Image_ID�6T     5      $ 	ImagePath��6%   $ 80 6[    68   �� $ 	ImagePath�6[   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Image��6*   $ 80 69   	   
IsReadOnly	 . 
   CellTemplate
 5      �� 5      .R�5      �� $��50��6C   $��50��6N   ��6%   �� $ Bytes�6N   5      5      5      �� 5   
   -   5         ��Name$ 
BackButton��5      $��
Назад��6%   $��23��65   $
��Left=�6A   $��	10,10,0,0q�6\   $	��Top=�6p   $��75��6�   
�������
�������6�   5      5      