   M S B A M L   `   `   `  ����   ClubOrganizer1    +ClubOrganizer.Pages.Fast_Tennis.Fast_Tennis   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $	��900��$
��1600��  N� 
FontFamily$  Poppins)�.��� .+��� $��Center=�$��Center=�$��108 38 38 38q�$	��830��$	��560��.+��  � RowDefinitions �� $��43 ��� �� .+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�$��0��.+�F� ���� N����@H����	$��0 3 0 0q�$��2��$��1��
���   � �� Stretch$
 Fill=�$��Center=�$��50���� $��Club Oganizer��$��24(�$
��Bold"�
���P��$��Center=�$��15 0 0 0q�F� $��1������ T�* ��� T�*���	���	#FFF4F4F5$��Center=�$��45��$��2��
���   �$
 Fill=�$��Center=�$��1��$
��10 0q��� $��Теннис��$��24(�$
��Bold"�
���   �$��Center=�$��0 0 15 0q�F� ���� N����@H����	$��0 3 0 0q�$��2��$��1��
���   �$
 Fill=�$��Center=�$��50��� $��1�� �� �� $��72 �.+��� $!��Данные клиента��$��0��$��Center=�$��Center=�$
��0 10q��� $��1��$ 
Horizontal=�$��Center=�$
��0 10q�.+��� -    ��Name$ Lastname��$��Center=�$
��Left=�$��1��
������ )  #MaterialDesignThemes.Wpf.HintAssist   
Background
 ����� "  MaterialDesignOutlinedComboBox#��[     Hint$# Введите фамилию�� �� 
IsEditable$
 True��$��184.5��$��0 0 10 0q��� -   $ Username��$��Center=�$
��Left=�$��1��
������ 
 �����#��[  $ Введите имя��$
 True��$��184.5��$��0 0 10 0q�${�False���� -   $ 
Secondname��$��Center=�$
��Left=�$��1��
������ 
 �����#��[  $% Введите отчество��$
 True��$��184.5��$��0 0 10 0q�${�False���� -   $ Phone��$��Center=�$
��Left=�$��1��
������ 
 �����#��[  $# Введите телефон��$
 True��$��184.5��$��0 0 10 0q�${�False���� -   $��Client_Save��$��Center=�
������ 
���P��$��1q�  MaterialDesignPaperButton#��[ .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=�+  %MaterialDesignThemes.Wpf.ButtonAssist	   CornerRadius$	 5��
 � ToolTip$4
 .Сохранить данные клиента��$��0q�$��52��$��52����0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$
 Done=�   Size 30� $��2�� �� �� $	��144 ���  � ColumnDefinitions �� �� $	��200 �.+��� $��Данные услуг��$��0��$��3��$��Center=�$��Center=�$
��0 10q�� -   $��ServiceData��$��1��$��0��$��Right=�${�False�� �� $��72 ��� $��72 �.+��� $ 
Horizontal=�$
��0 10q�.+��� -   $	 Day��$��Center=�$
��Left=�$��1��
������ 
 �����#��[  $ Выберите день��$ False�� �� 
IsReadOnly$
 True��$	��200��$��0 0 10 0q�.@��� $��Понедельник���� $��Вторник���� $��
Среда���� $��Четверг���� $��Пятница���� $��Суббота���� $��Воскресенье���� -	    ��Name$ Price��
������ 
 ����� ! MaterialDesignOutlinedTextBox#��[ $ Введите цену��$	��200���� -
   $ HourST��$��Center=�$
��Left=�$��1��
������ 
 �����#��[  $ Начало��$ False��$
 True��$��95��$��	10 0 10 0q�.@��� $��07���� $��08���� $��09���� $��10���� $��11���� $��12���� $��13���� $��14���� $��15���� $��16���� $��17���� $��18���� $��19���� $��20���� $��21���� $��22���� $��23���� -   $ MinST��$��Center=�$
��Left=�$��1��
������ 
 �����#��[  $ Мин��$ False��$
 True��$��95��$��0 0 10 0q�.@��� $��00���� $��30���� $��1��$
��0 10q�$ 
Horizontal=�.+�(  "System.Windows.Controls.DatePicker  -   $��	Day_Start��
������ 
 ����� $  MaterialDesignOutlinedDatePicker#��[ $! Начальная дата��-  'MaterialDesignThemes.Wpf.CalendarAssist   IsHeaderVisible$
 True��   Orientation$ 
Horizontal=�$	��200��$��0 0 10 0q�  -   $��Day_End��
������ 
 �����#��[ $ Конечная дата��$
 True��$ 
Horizontal=�$	��200���� -   $ HourED��$��Center=�$
��Left=�$��1��
������ 
 �����#��[  $ 
Конец��$ False��$
 True��$��95��$��	10 0 10 0q�.@��� $��07���� $��08���� $��09���� $��10���� $��11���� $��12���� $��13���� $��14���� $��15���� $��16���� $��17���� $��18���� $��19���� $��20���� $��21���� $��22���� $��23���� -   $ MinED��$��Center=�$
��Left=�$��1��
������ 
 �����#��[  $ Мин��$ False��$
 True��$��95��.@��� $��00���� $��30����  �� CornerRadius$ 5��
�������$��Right=�$	��Top=�$��1��$��1��$��	10 10 0 0q�$	��190��._��� -   $��Day_save��
������ 
���P��$��1q�#��[ $	 Dp0=�$	 5��$��Записать день��${�False��$
��Thin"�$��16(�$��52���� $ 5�����#2c3e50$��Right=�$��Bottom=�$��1��$��1��$��0 0 0 10q�$	��190��._��� -   $��Cancel_save��
������ 
�������
�������$��0q�#��[ $	 Dp0=�$	 5��$��Очистить��${�False��$
��Thin"�$��16(�$��52��&   System.Windows.Controls.DataGrid  -     Name$ Data_services��$��1��
�������  MaterialDesignDataGrid#��[    HeadersVisibility$ Column=�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ 1* $	��Top=� �� TextAlignment$
 Left=�   CanUserAddRows$ False��   CanUserDeleteRows$ False��   CanUserReorderColumns$ False��   CanUserResizeColumns$ False��   CanUserSortColumns$
 True��
�������$
��0 10q�$
��True��$	��205��� -   $��Succes��$��Center=�$��Bottom=�$��108 0 0 -90q�$��70��.+�'	  !MaterialDesignThemes.Wpf.PackIcon	  -   $
��Icon�� 	  Kind$ DeleteOutline=�$��32��$��32��$��Center=�
���P��� -   $��	Bottombar��$��108 0 0 -90q�$��2��$��Center=�$��Bottom=�$��50��.+��� $ 8�����#2c3e50 J� Effect 3
  -System.Windows.Media.Effects.DropShadowEffect
   
  ShadowDepth$ 0Q� 
  Color$
 Gray��  
  
BlurRadius$  20Q��� $ 
Horizontal=�.+��� $ 8��
�������._��� -   ! ��Name$
! Save��$��3��
������ 
���P��$��0q�#��[ $	 Dp0=�$	 8��$��Сохранить��$
��Thin"�$��16(�" � Cursor$
" Hand��$��50��$	��120��