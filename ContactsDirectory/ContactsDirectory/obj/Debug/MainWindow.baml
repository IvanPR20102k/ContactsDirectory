   M S B A M L   `   `   `  ����L  HContactsDirectory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ContactsDirectoryContactsDirectory  5   	   "    ContactsDirectory.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ContactsDirectory     5   	     � Title$  
MainWindow��5   	   $	��450��6   $
��1920��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��120 �6   �� 5      $	��120 �6   �� 5       � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      .+�5   
   �� -   5         ��Name$ 	btnImport��5      $��Импорт��6$   $��10,10,10,10q�65   6J   �� 5   
   $��0��6   $��1��6"   $��Center=�62    �� Orientation$ Vertical=�6M   .+�5      �� $"��Сортировать по:��6   $
��Left=�6/   $��5,0,0,0q�6J   �� 5      -   5        $��
cmbSorting��5       �� SelectedIndex$ 0��6)   $��Stretch=�6;   $��5,5,5,5q�6Y   ��6j   �� *SortingList+6�   5      �� 5   
   $��0��6   $��2��6"   $��Center=�62   $ Vertical=�6M   .+�5      �� $��
Поиск��6   $
��Left=�6%   $��5,0,0,0q�6@   �� 5      -   5        $��	txtSearch��5      $��5,5,5,5q�6U   5      �� 5    
   -   5        $��LViewInstitution��5       $��0��6+   $��3��6;   $��1��6O   $��5,5,5,5q�6\    �� View 5!      �� 5"      .P�5#      ��  �� Width$	 600��6P    �� DisplayMemberBinding 6%   �� 	 �� Path$
	 Name�.��6\   Название6f   �� 5$      $	 600��6S    6%   �� $	 Address�.��6_   
Адрес6f   �� 5%      $	 200��6Q    6%   �� $	 Email�.��6]   Email6d   �� 5&      $	 200��6S    6%   �� $	 Website�.��6_   
Сайт6e   �� 5'      $	 200��6Q    6%   �� $	 Phone�.��6]   Телефон6f   5(      5*      5+      5,      