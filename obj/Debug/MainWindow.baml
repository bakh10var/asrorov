   M S B A M L   `   `   `  ����C  ?asrorov1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:asrorov1asrorov1  5   	       asrorov1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:asrorov1     5   	     � Title$-  'Графический редактор��5   	   $	��350��6&   $	��525��63   .��5      � .+�5
   
   �� -   5        $��BrushColorComboBox��5
      $
��Left=�6-   $	��Top=�6H   $	��150��6`   $��	10,10,0,0q�6l   .@�5      �� $��Черный��6   �� 5      $��Красный��6   �� 5      $��Зеленый��6   �� 5      $��
Синий��6   5      �� 5   
   -   5        $��BrushSizeSlider��5      $
��Left=�6(   $	��Top=�6C   $	��150��6[    � Minimum$ 1Q�6g    � Maximum$ 50Q�6s    � Value$ 10Q�6�   $��	10,50,0,0q�6�   6�   �� 5   
   $
��Left=�6   $	��Top=�6/   $��
170,50,0,0q�6G   $��Размер кисти��6[   �� 5   
   $
��Left=�6   $	��Top=�60   $��
10,100,0,0q�6H   .+�5      	� -   5        $��DrawModeRadioButton��5      $��Рисование��65    d� 	IsChecked$
 TrueY�6I   6Z   	� 5      -   5        $��EditModeRadioButton��5      $"��Редактирование��65   6N   	� 5      -   5        $��DeleteModeRadioButton��5      $��Удаление��67   6J   5      �� 5   
   -   5        $��DrawingCanvas��5      
�������$��200,10,10,10q�69   6s   5      5      