   M S B A M L   `   `   `  ����  ClubOrganizer)    #ClubOrganizer.Pages.Payment.Payment   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
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
��10 0q�5/      �� 50      $��Оплаты��6   $��24(�51      $
��Bold"�52      
���   �$��Center=�54      $��0 0 15 0q�55      F� 56      ���� N����@H����	$��0 3 0 0q�57      $��2��58      $��1��59      
���   �$
 Fill=�5;      $��Center=�5<      $��50��5=      5>      &   System.Windows.Controls.DataGrid  5?      -   5          Name$ DataPayment��5?      $��1��5@      
�������   MaterialDesignDataGrid#��[  5B         HeadersVisibility$ Column=�5C         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ 1* 5D      $	��Top=�5E       �� TextAlignment$
 Left=�5F         CanUserAddRows$ False��5G      	   CanUserDeleteRows$	 False��5H      
   CanUserReorderColumns$
 False��5I         CanUserResizeColumns$ False��5J         CanUserSortColumns$
 True��5K         
IsReadOnly$
 True��5L      
�������$��0 10 0 0q�5N      $	��751��5O      $��1q�5P      
���   �$
��True��5R      5S      � 5T   
   -   5        $��BottombarSearch��5T      $��108 0 0 -90q�5U      $��2��5V      $��Center=�5W      $��Bottom=�5X      $��70��5Y      .+�5Z      ��  �� CornerRadius$ 8��6   
������� J� Effect 5\      3  -System.Windows.Media.Effects.DropShadowEffect  5]         ShadowDepth$ 0Q�6'      Color$
 Gray��5^   '      
BlurRadius$ 20Q�5_   '   5a      �� 5b      $ 
Horizontal=�6   .+�5c      �� -   5        $��
ClientList��5c       " MaterialDesignOutlinedComboBox#��[ 5d      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$: 4Поиск существующего клиента��5e      
������    
Background
 ����� �� 
IsEditable$
 True��5i      $	��400��5j      $��10 0 0 0q�5k      ��5h      �� 5l      �� 5m      $ 8��6   ���#2c3e50$��Center=�5o      $
��Left=�5p      $��20 0 0 0q�5q      ._�5r      �� 
������ $ 
Horizontal=�5s   !   .+�5t      �� -   5        $��ClientSearch��5t   !   $��2��5u   !   
������ 
�������
�������$��0q�5y   !     MaterialDesignPaperButton#��[ 5z   !   .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=�5{   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 8 0 0 8��5|   !    � ToolTip$7 1Поиск договоров по клиенту��5~   !    ^� 	Placement$ Bottom=�5   !   $��0q�5�   !   $��70��5�   !   $��70��5�   !   ��5}   !   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Search=�   Size 305�   !   �� 5�      -   5        $��ClientReset��5�   !   $��2��5�   !   $��Center=�5�   !   $
��Left=�5�   !   
������ 
�������
�������$��0q�5�   !   #��[ 5�   !   $	 Dp0=�5�   !   $ 0 8 8 0��5�   !   $0 *Сбросить выбор клиента��5�   !   $	 Top=�5�   !   $��0q�5�   !   $��70��5�   !   $��70��5�   !   ��5�   !     $ Cancel=� 305�   !   5�      5�      5�      5�      5�      5�      