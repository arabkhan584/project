   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfApp3.viuWpfApp3.viu  5          WpfApp3.viu.Page_qw   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:WpfApp3.viu     5      -   5          N� Title$  Page_qw��5
      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      6   �� 5      $	��100 �6   6,   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ GridUser��5      $��1��5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Id+  5      $ * 6%   $ Login��6/    6>   �� *login1+  5      $ * 6%   $ Password��6/    6A   �� *	password1+  5      $ * 6%   $
 Role��6/    6=   �� *
Role.role1+5      �� 5"   
   -   5        $��	riges_bth��5#      $	��100��5$      $��30��5%      $��
Назад��5&      $
��Left=�5'      $��0��5(      $
��10 3q�5)      �� 5*   
   $��Right=�6   $��10q�5+       �� Orientation$ 
Horizontal=�5,      .+�5.   
   �� -   5        	 ��Name$	 poisk��5.      $	��150��5/      $��20��50      $	��5 0q�51      �� 52      -   5        
 ��Name$
 	poisk_bth��52      $��50��54      $��20��55      $��
Поиск��56      57      �� 5=   
   $��2��6   $��Center=�5>      $��Center=�5?      $ 
Horizontal=�5@      .+�5A      �� -   5        $��add_bth��5C      $��Добавить��5A      $	��100��5D      $��30��5E      �� 5F      -   5        $��
delete_bth��5H      $��Удалить��5F      $	��100��5I      $��30��5J      $��20q�5K      �� 5L      -   5        $��pech_bth��5N      $��Печатать��5L      $	��100��5O      $��30��5P      �� 5Q      -	   5        $��izm_bth��5S      $ ��Редактировать��5Q      $	��100��5T      $��30��5U      $��20q�5V      5X      5Z      5[      