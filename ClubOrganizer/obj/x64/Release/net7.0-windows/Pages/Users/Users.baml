   M S B A M L   `   `   `  ����   ClubOrganizer%    ClubOrganizer.Pages.Users.Users   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
FontFamily$  Poppins)�.��� .+�� $��108 38 38 58q�$��Center=� � RowDefinitions �� $��43 ��� .+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�$��0��$��5��.+�F� ���� N����@H����	$��0 3 0 0q�$��2��$��1��
���   � �� Stretch$
 Fill=�$��Center=�$��50���� $��Club Oganizer��$��24(�$
��Bold"�
���P��$��Center=�$��15 0 0 0q�F� $��1������ T�* ��� T�*���	���	#FFF4F4F5$��Center=�$��45��$��2��
���   �$
 Fill=�$��Center=�$��1��$
��10 0q��� $��Пользователи��$��24(�$
��Bold"�
���   �$��Center=�$��0 0 15 0q�F� ���� N����@H����	$��0 3 0 0q�$��2��$��1��
���   �$
 Fill=�$��Center=�$��50���� $��1��$��0 10 0 0q�.+�&   System.Windows.Controls.DataGrid  -     Name$ 
Data_users��
�������   MaterialDesignDataGrid#��[     HeadersVisibility$ Column=�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ 1* $	��Top=� �� TextAlignment$
 Left=�   CanUserAddRows$ False��	   CanUserDeleteRows$	 False��
   CanUserReorderColumns$
 False��   CanUserResizeColumns$ False��   CanUserSortColumns$
 True��
�������$	��751��   
IsReadOnly$
 True��$��1q�
���   �$
��True��   Columns 4  .System.Windows.Controls.DataGridCheckBoxColumn   - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [  4 0MaterialDesignDataGridCheckBoxColumnEditingStyle   EditingElementStyle# [ ,  &System.Windows.Controls.DataGridColumn   Width$ 60    
IsReadOnly$ False��   CanUserSort$ False��   CanUserResize$ False��� -   $��Succes��$��Center=�$��Bottom=�$��108 0 0 -70q�$��52��.+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $
��Icon��   Kind$ DeleteOutline=�$��32��$��32��$��Center=�
���P��� -   $��	Bottombar��$��108 0 0 -70q�$��2��$��Center=�$��Bottom=�$��50��.+���  �� CornerRadius$ 8�����#2c3e50 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q�   Color$
 Gray��   
BlurRadius$ 20Q��� $ 
Horizontal=�.+��� -    ��Name$ Update��$��3��$��Center=�
������ 
�������
�������$��0q�  MaterialDesignPaperButton#��[ .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=�+	  %MaterialDesignThemes.Wpf.ButtonAssist 	  CornerRadius$ 8�� � ToolTip$ Обновить�� ^� 	Placement$	 Top=�  � Cursor$
  Hand��$��0q�$��50��$��50����0
  *MaterialDesignThemes.Wpf.PackIconExtension
  *Update+! 
  Size! 30�� 
�������$ 8��._��� $ 
Horizontal=�.+��� -   $ Check��$��3��$��Center=�
������ 
���P��$��0q�#��[ $	 Dp0=�$ 8 0 0 8��$ Сохранить��$	 Top=�$
  Hand��$��0q�$��50��$��50����
  *Check+! 30�� -   $ Create��$��3��$��Center=�
������ 
���P��$��0q�#��[ $	 Dp0=�$ 0 8 8 0��$ Создать��$	 Top=�$
  Hand��$��0q�$��50��$��50����
  " 
  Kind$
" Plus=�! 30�� -   $ Delete��$��3��$��Center=�
������ 
�������
�������$��0q�#��[ $	 Dp0=�$ 8��$ Удалить��$	 Top=�$
  Hand��$��0q�$��50��$��50����
  *DeleteOutline+! 30