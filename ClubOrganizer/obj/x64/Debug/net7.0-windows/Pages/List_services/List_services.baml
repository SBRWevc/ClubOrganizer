   M S B A M L   `   `   `  ����  ClubOrganizer5    /ClubOrganizer.Pages.List_services.List_services   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
FontFamily$  Poppins)�5
      .��5      � .+�5   
   � $��108 38 38 58q�6   $��Center=�5       � RowDefinitions 5      �� 5      $��43 �6    �� 5       � ColumnDefinitions 5      �� 5      $
��0.3* �6#   �� 5      $��50 �6#   �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5      $��Center=�5      $��0��5      $��5��5      .+�5      F� ���� N����@H����	$��0 3 0 0q�5      $��2��5      $��1��5       
���   � �� Stretch$
 Fill=�5"      $��Center=�5#      $��50��5$      �� 5%      $��Club Oganizer��6   $��24(�5&      $
��Bold"�5'      
���P��$��Center=�5)      $��15 0 0 0q�5*      F� 5+      $��1��6   ���� T�* ��� T�*���	���	#FFF4F4F5$��Center=�5.      $��45��5/      $��2��50      
���   �$
 Fill=�52      $��Center=�53      $��1��54      $
��10 0q�55      �� 56      $��
Счета��6   $��24(�57      $
��Bold"�58      
���   �$��Center=�5:      $��0 0 15 0q�5;      F� 5<      ���� N����@H����	$��0 3 0 0q�5=      $��2��5>      $��1��5?      
���   �$
 Fill=�5A      $��Center=�5B      $��50��5C      5D      &   System.Windows.Controls.DataGrid  5E      -   5          Name$ DataServices��5E      $��1��5F      $��0��5G      
�������   MaterialDesignDataGrid#��[  5I         HeadersVisibility$ Column=�5J         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 auto 5K      $	��Top=�5L       �� TextAlignment$
 Left=�5M      	   CanUserAddRows$	 False��5N      
   CanUserDeleteRows$
 False��5O         CanUserReorderColumns$ False��5P         CanUserResizeColumns$ False��5Q         CanUserSortColumns$
 True��5R         
IsReadOnly$
 True��5S      
�������$��	0 10 19 0q�5U      $	��751��5V      $��1q�5W      
���   �$
��True��5Y         Columns 5Z      4  .System.Windows.Controls.DataGridCheckBoxColumn  5[       - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6-    4 0MaterialDesignDataGridCheckBoxColumnEditingStyle   EditingElementStyle# [ 5\   -   ,  &System.Windows.Controls.DataGridColumn   Width$ 60 5]   -      
IsReadOnly$ False��5^   -      CanUserSort$ False��5_   -   5`      5b      �� 5c      -   5        $��Choice��5c      $��1��5d      $��1��5e      $��Center=�5f      $��Center=�5g      
������ 
���P��  MaterialDesignPaperButton#��[ 5j      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=�5l      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 25��5m       � ToolTip$' !Отобразить данные��5n       ^� 	Placement$	 Top=�5o      $��50��5p      $��50��5q      $��0q�5r      ��5k      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ 
ArrowRight=�   Size 305s        5t      -   5        $ DataDays��5t      $��1��5u      $��2��5v      
�������#��[  5x      $ Column=�5y      $ 1* 5z      $	��Top=�5{      $
 Left=�5|      $	 False��5}      $
 False��5~      $ False��5      $ False��5�      $
 True��5�      $
 True��5�      
�������$��	19 10 0 0q�5�      $	��751��5�      $��1q�5�      
���   �$
��True��5�       5�        5�      # [ 6-   # [ 5�   -   $ 60 5�   -   $ False��5�   -   $ False��5�   -   5�      5�      5�      � 5�   
   -   5        $��Succes��5�      $��Center=�5�      $��Bottom=�5�      $��635 0 0 -90q�5�      $��70��5�      .+�5�      '	  !MaterialDesignThemes.Wpf.PackIcon	  -   5        $
��Icon��5�   &    	  Kind$ DeleteOutline=�5�   &   $��32��5�   &   $��32��5�   &   $��Center=�5�   &   
���P��5�   &   5�      � 5�   
   -   5        $��BottombarSearch��5�      $��-55 0 0 -90q�5�      $��2��5�      $��Center=�5�      $��Bottom=�5�      $��70��5�      .+�5�      ��  �� CornerRadius$ 8��6   
������� J� Effect 5�      3
  -System.Windows.Media.Effects.DropShadowEffect
  5�       
  ShadowDepth$ 0Q�6'    
  Color$
 Gray��5�   '     
  
BlurRadius$  20Q�5�   '   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� -   5        $��
ClientList��5�       " MaterialDesignOutlinedComboBox#��[ 5�      )  #MaterialDesignThemes.Wpf.HintAssist!   Hint$:! 4Поиск существующего клиента��5�      
������ "   
Background
" �����# �� 
IsEditable$
# True��5�      $	��400��5�      $��10 0 0 0q�5�      ��5�      �� 5�      �� 5�      $ 8��6   ���#2c3e50$��Center=�5�      $
��Left=�5�      $��20 0 0 0q�5�      ._�5�      �� 
������ $ 
Horizontal=�5�   !   .+�5�      �� -   5        $��ClientSearch��5�   !   $��2��5�   !   
������ 
�������
�������$��0q�5�   !   #��[ 5�   !   $	 Dp0=�5�   !   $ 8 0 0 8��5�   !   $7 1Поиск договоров по клиенту��5�   !   $ Bottom=�5�   !   $��0q�5�   !   $��70��5�   !   $��70��5�   !   ��5�   !     $ Search=� 305�   !   �� 5�      -	   5        $��ClientReset��5�   !   $��2��5�   !   $��Center=�5�   !   $
��Left=�5�   !   
������ 
�������
�������$��0q�5�   !   #��[ 5�   !   $	 Dp0=�5�   !   $ 0 8 8 0��5�   !   $0 *Сбросить выбор клиента��5�   !   $	 Top=�5�   !   $��0q�5�   !   $��70��5�   !   $��70��5�   !   ��5�   !     $ Cancel=� 305�   !   5�      5�      5�      5�      � 5�   
   -
   5        $��	Bottombar��5�      $��635 0 0 -90q�5�      $��2��5�      $��Center=�5�      $��Bottom=�5�      $��70��5�      .+�5�      �� $ 8��6   ���#2c3e50 5�      
  5�      $ 0Q�6'   $
 Gray��5�   '   $  20Q�5�   '   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� -   5        $��Print��5�      $��3��5�      $��Center=�5�      
������ 
�������
�������$��0q�5�      #��[ 5�      $	 Dp0=�5�      $ 8��5�      $ Печать��5�      $	 Top=�5      $ � Cursor$
$ Hand��5     $��0q�5     $��70��5     $��70��5     ��5�        $ PrinterOutline=� 305     5     5     5     5	     