   M S B A M L   `   `   `  ����  ClubOrganizer%    ClubOrganizer.Pages.Users.Users   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
FontFamily$  Poppins)�5
      .��5      � .+�5   
   � $��108 38 38 58q�6   $��Center=�5       � RowDefinitions 5      �� 5      $��43 �6    �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5      $��Center=�5      $��0��5      $��5��5      .+�5      F� ���� N����@H����	$��0 3 0 0q�5      $��2��5      $��1��5      
���   � �� Stretch$
 Fill=�5      $��Center=�5      $��50��5      �� 5      $��Club Oganizer��6   $��24(�5       $
��Bold"�5!      
���P��$��Center=�5#      $��15 0 0 0q�5$      F� 5%      $��1��6   ���� T�* ��� T�*���	���	#FFF4F4F5$��Center=�5(      $��45��5)      $��2��5*      
���   �$
 Fill=�5,      $��Center=�5-      $��1��5.      $
��10 0q�5/      �� 50      $��Пользователи��6   $��24(�51      $
��Bold"�52      
���   �$��Center=�54      $��0 0 15 0q�55      F� 56      ���� N����@H����	$��0 3 0 0q�57      $��2��58      $��1��59      
���   �$
 Fill=�5;      $��Center=�5<      $��50��5=      5>      �� 5?      $��1��6   $��0 10 0 0q�5@      .+�5A      &   System.Windows.Controls.DataGrid  -   5          Name$ 
Data_users��5A      
�������   MaterialDesignDataGrid#��[  5C         HeadersVisibility$ Column=�5D         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ 1* 5E      $	��Top=�5F       �� TextAlignment$
 Left=�5G         CanUserAddRows$ False��5H      	   CanUserDeleteRows$	 False��5I      
   CanUserReorderColumns$
 False��5J         CanUserResizeColumns$ False��5K         CanUserSortColumns$
 True��5L      
�������$	��751��5N         
IsReadOnly$
 True��5O      $��1q�5P      
���   �$
��True��5R         Columns 5S      4  .System.Windows.Controls.DataGridCheckBoxColumn  5T       - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 61    4 0MaterialDesignDataGridCheckBoxColumnEditingStyle   EditingElementStyle# [ 5U   1   ,  &System.Windows.Controls.DataGridColumn   Width$ 60 5V   1      
IsReadOnly$ False��5W   1      CanUserSort$ False��5X   1      CanUserResize$ False��5Y   1   5Z      5\      5]      5^      � 5_   
   -   5        $��Succes��5_      $��Center=�5`      $��Bottom=�5a      $��108 0 0 -70q�5b      $��52��5c      .+�5d      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $
��Icon��5i   &      Kind$ DeleteOutline=�5d   &   $��32��5e   &   $��32��5f   &   $��Center=�5g   &   
���P��5i   &   5j      � 5k   
   -   5        $��	Bottombar��5k      $��108 0 0 -70q�5l      $��2��5m      $��Center=�5n      $��Bottom=�5o      $��50��5p      .+�5q      ��  �� CornerRadius$ 8��6   ���#2c3e50 J� Effect 5s      3  -System.Windows.Media.Effects.DropShadowEffect  5t         ShadowDepth$ 0Q�6'      Color$
 Gray��5u   '      
BlurRadius$ 20Q�5v   '   5x      �� 5y      $ 
Horizontal=�6   .+�5z      �� -   5         ��Name$ Update��5z      $��3��5{      $��Center=�5|      
������ 
�������
�������$��0q�5�        MaterialDesignPaperButton#��[ 5�      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=�5�      +	  %MaterialDesignThemes.Wpf.ButtonAssist 	  CornerRadius$ 8��5�       � ToolTip$ Обновить��5�       ^� 	Placement$	 Top=�5�        � Cursor$
  Hand��5�      $��0q�5�      $��50��5�      $��50��5�      ��5�      0
  *MaterialDesignThemes.Wpf.PackIconExtension
  *Update+! 
  Size! 305�      �� 5�      
�������$ 8��5�      ._�5�      �� $ 
Horizontal=�6!   .+�5�      �� -   5        $ Check��5�   !   $��3��5�   !   $��Center=�5�   !   
������ 
���P��$��0q�5�   !   #��[ 5�   !   $	 Dp0=�5�   !   $ 8 0 0 8��5�   !   $ Сохранить��5�   !   $	 Top=�5�   !   $
  Hand��5�   !   $��0q�5�   !   $��50��5�   !   $��50��5�   !   ��5�   !   
  *Check+! 305�   !   �� 5�      -   5        $ Create��5�   !   $��3��5�   !   $��Center=�5�   !   
������ 
���P��$��0q�5�   !   #��[ 5�   !   $	 Dp0=�5�   !   $ 0 8 8 0��5�   !   $ Создать��5�   !   $	 Top=�5�   !   $
  Hand��5�   !   $��0q�5�   !   $��50��5�   !   $��50��5�   !   ��5�   !   
  " 
  Kind$
" Plus=�! 305�   !   5�      5�      �� 5�      -   5        $ Delete��5�      $��3��5�      $��Center=�5�      
������ 
�������
�������$��0q�5�      #��[ 5�      $	 Dp0=�5�      $ 8��5�      $ Удалить��5�      $	 Top=�5�      $
  Hand��5�      $��0q�5�      $��50��5�      $��50��5�      ��5�      
  *DeleteOutline+! 305�      5�      5�      5�      5�      