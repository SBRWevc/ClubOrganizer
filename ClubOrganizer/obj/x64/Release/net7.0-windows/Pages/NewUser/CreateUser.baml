   M S B A M L   `   `   `  ����   ClubOrganizer,    &ClubOrganizer.Pages.NewUser.CreateUser   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
FontFamily$  Poppins)�.��� .+�� $��Center=�$��Center=�$	��850�� � ColumnDefinitions �� $
��1.2* ���  � RowDefinitions �� $��60 ��� $��3 ��� .+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�$��0��$��5��.+�F� ���� N����@H����	$��0 3 0 0q�$��2��$��1��
���   � �� Stretch$
 Fill=�$��Center=�$��50���� $��Club Oganizer��$��24(�$
��Bold"�
���P��$��Center=�$��15 0 0 0q�F� $��1������ T�* ��� T�*���	���	#FFF4F4F5$��Center=�$��45��$��2��
���   �$
 Fill=�$��Center=�$��1��$
��10 0q��� $��Настройки��$��24(�$
��Bold"�
���   �$��Center=�$��0 0 15 0q�F� ���� N����@H����	$��0 3 0 0q�$��2��$��1��
���   �$
 Fill=�$��Center=�$��50���� $��Center=�$��2��.+��� -    ��Name$ 
USR_avatar��$��/resources/avatar/man.png�� �� BitmapScalingMode$ HighQuality=�$	��180��$	��180���� $ 
Horizontal=�$��Center=�$��10q�.+��� -    ��Name$ Lastname_text��$��Фамилия��$
��Bold"�$��20(�
���   �$��0 0 8 0q��� -   $ 	Name_text��$��Имя��$
��Bold"�$��20(�
���   �$��0 0 8 0q��� -   $ Secondname_text��$��Отчество��$
��Bold"�$��20(�
���   ��� -   $ Position_text��$��Должность��$��Center=�$��15(�
���   �� $��2��$��Center=�$��	15 0 30 0q�$��2�� �� �� �� �� �� �� �� .+��� -    ��Name$ Lastname��$��0��
�������)  #MaterialDesignThemes.Wpf.HintAssist	   
Background
	 ����� !  MaterialDesignOutlinedTextBox#��[  
   Hint$#
 Введите фамилию��$��5q��� -   $ Username��$��1��
�������
	 �����#��[  $
 Введите имя��$��5q��� -   $ 
Secondname��$��2��
�������
	 �����#��[  $%
 Введите отчество��$��5q��� $ 
Horizontal=�$��Center=�$��3��$��7q�.+�	� -	    	�Name$	 Man��
�������   MaterialDesignTabRadioButton#��[ $��Мужской�� d� 	IsChecked$
 TrueY�$��0 0 20 0q�	� -
   $ Woman��
�������#��[ $��Женский��$ FalseY�$��20 0 0 0q��� -    ��Name$ Position��$��4��$��1��
�������
	 ����� " MaterialDesignOutlinedComboBox#��[ $)
 #Выберете должность��$��5q�.@��� $��Директор���� $ ��Администратор���� $��Тренер���� -   $ Login��$��5��$��1��
�������
	 �����#��[  $
 Введите логин��$��5q�G� -    G�Name$
 Pass��$��6��$��1��
�������
	 ����� + 'MaterialDesignOutlinedRevealPasswordBox#��[ $!
 Введите пароль��$��5q�� -   $��Succes��$��Center=�$��Bottom=�$��	0 0 0 -70q�$��52��.+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $
��Icon��   Kind$ DeleteOutline=�$��32��$��32��$��Center=�
���P��� -   $��	Bottombar��$��	0 0 0 -70q�$��Center=�$��Bottom=�$��50��.+���  �� CornerRadius$ 8�����#2c3e50 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q�   Color$
 Gray��   
BlurRadius$ 20Q��� $ 
Horizontal=�.+��� -    ��Name$
 Back��$��3��
������ 
�������
�������$��0q�  MaterialDesignPaperButton#��[ .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 8��$��
Назад��$
��Thin"�$��16(� � Cursor$
 Hand��$��50��$	��105���� 
�������$ 8��._��� -   $
 Save��$��3��
������ 
���P��$��0q�#��[ $	 Dp0=�$ 8��$��Сохранить��$
��Thin"�$��16(�$
 Hand��$��50��$	��105���� -   $ Clear��$��3��
������ 
�������
�������$��0q�#��[ $	 Dp0=�$ 8��$��Очистить��$
��Thin"�$��16(�$
 Hand��$��50��$	��105��