   M S B A M L   `   `   `  ����   ClubOrganizer/    )ClubOrganizer.Pages.Requisites.Requisites   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
FontFamily$  Poppins)�.��� -   $��ReqSettings��
������ .+���  �� CornerRadius$ 8��
�������$��Center=�$��Center=�$��1��$��1��._�� .+�� $��10q� � RowDefinitions �� $��50 ��� $��35 ��� �� $��35 ���  � ColumnDefinitions �� �� $��3 ��� $	��300 �.+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�$��0��$��5��.+�F� ���� N����@H����	$��0 3 0 0q�$��2��$��1��
���   � �� Stretch$
 Fill=�$��Center=�$��50���� $��Club Oganizer��$��24(�$
��Bold"�
���P��$��Center=�$��15 0 0 0q�F� $��1������ T�* ��� T�*���	���	#FFF4F4F5$��Center=�$��45��$��2��
���   �$
 Fill=�$��Center=�$��1��$
��10 0q��� $��Настройки��$��24(�$
��Bold"�
���   �$��Center=�$��0 0 15 0q�F� ���� N����@H����	$��0 3 0 0q�$��2��$��1��
���   �$
 Fill=�$��Center=�$��50���� $(��"Юридический. адрес��$��1��$��0��$��Center=�$��Center=��� -   $��InputsAddress��$��2��$��0��.+��� $ 
Horizontal=�.+��� -    ��Name$ YrIndex��
������ )  #MaterialDesignThemes.Wpf.HintAssist   
Background
 ����� !  MaterialDesignOutlinedTextBox#��[     Hint$ Индекс��$��
10 0 10 10q�$	��137��	 �� 	MaxLength$	 6���� -   $ YrCity��
������ 
 �����#��[  $ 
Город��$��
10 0 10 10q�$	��294���� $ 
Horizontal=�.+��� -   $ YrStreet��
������ 
 �����#��[  $ 
Улица��$��
10 10 10 0q�$	��137���� -   $ YrHouse��
������ 
 �����#��[  $ Дом / Корпус��$��
10 10 10 0q�$	��137���� -   $ YrFlat��
������ 
 �����#��[  $ Помещение��$��
10 10 10 0q�$	��137���� $'��!Фактический адрес��$��Center=�$��Center=�$
��10 5q��� $ 
Horizontal=�.+��� -   $ FcIndex��
������ 
 �����#��[  $ Индекс��$��
10 0 10 10q�$	��137��$	 6���� -	   $ FcCity��
������ 
 �����#��[  $ 
Город��$��
10 0 10 10q�$	��294���� $ 
Horizontal=�.+��� -
   $ FcStreet��
������ 
 �����#��[  $ 
Улица��$��
10 10 10 0q�$	��137���� -   $ FcHouse��
������ 
 �����#��[  $ Дом / Корпус��$��
10 10 10 0q�$	��137���� -   $ FcFlat��
������ 
 �����#��[  $ Помещение��$��
10 10 10 0q�$	��137��F� ���� T�* ��� T�*���	���	#FFF4F4F5$��Center=�$	��276��$��2��$��1��
���   �$
 Fill=�$	��Top=�$��1���� $-��'Банковские реквизиты��$��1��$��4��$��Center=�$��Center=��� $��2��$��4��.+��� -   $	 Inn��
������ 
 �����#��[  $ ИНН��$��10 0 12.5 10q�$	 12���� -   $	 Kpp��
������ 
 �����#��[  $ КПП��$��10 10 12.5 0q�$	 9���� $��Данные счетов��$��Center=�$��Center=�$
��10 5q��� -   $
 Rass��
������ 
 �����#��[  $! Расчётный счёт��$��10 0 12.5 10q�$	 20���� -   $
 Korr��
������ 
 �����#��[  $1 +Корреспондентский счёт��$��10 10 12.5 10q�$	 20���� $��Управляющий��$��3��$��3��$��Center=�$��Center=��� $��4��$��Center=�$��Center=�$��3��$ 
Horizontal=�.+��� -   $ Lastname��
������ 
 �����#��[  $# Введите фамилию��$��10q�$	��200���� -   $ Username��
������ 
 �����#��[  $ Введите имя��$��10q�$	��200���� -   $ 
Secondname��
������ 
 �����#��[  $% Введите отчество��$��10q�$	��200��� -   $��Succes��$��Center=�$��Bottom=�$��	0 0 0 -70q�$��52��.+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $
��Icon��
   Kind$
 DeleteOutline=�$��32��$��32��$��Center=�
���P��� -   $��	Bottombar��$��	0 0 0 -70q�$��Center=�$��Bottom=�$��50��.+��� $ 8�����#2c3e50 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q�   Color$
 Gray��   
BlurRadius$ 20Q��� $ 
Horizontal=�.+��� $ 8��
�������._��� -    ��Name$
 Save��$��3��
������ 
���P��
���P��$��0q�  MaterialDesignPaperButton#��[ .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 8��$��Сохранить��$
��Thin"�$��16(� � Cursor$
 Hand��$��50���� -   $ Clear��$��3��
������ 
�������
�������$��0q�#��[ $	 Dp0=�$ 8��$��Очистить��$
��Thin"�$��16(�$
 Hand��$��50��