   M S B A M L   `   `   `  ����   ClubOrganizer-    'ClubOrganizer.Pages.Profile.UserProfile   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
FontFamily$  Poppins)�.��� .+��� $��16q�$��Center=�$��Center=�.+��� -    ��Name$ 
PRF_avatar��$��/resources/avatar/man.png�� �� BitmapScalingMode$ HighQuality=�$	��150��$	��150��$��10q��� -    ��Name$ PRF_fullname��$��Center=�$4��.Имя пользователя - полное��$
��Bold"�$��20(��� -   $ PRF_position��$��Center=�$��Должность��$��12(�$��Italic$��� $��	0 20 0 10q� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ 	PRF_login��
�������)  #MaterialDesignThemes.Wpf.HintAssist   
Background
 ����� !  MaterialDesignOutlinedTextBox#��[     Hint$* $Введите новый логин�� �� 	MaxLength$ 15��$	��240��$��0 0 20 0q�G� -   	 G�Name$	 PRF_pass��
�������
 ����� + 'MaterialDesignOutlinedRevealPasswordBox#��[ $, &Введите новый пароль��$	��240��
 G� 	MaxLength$
 15��� -   $��Succes��$��Center=�$��Bottom=�$��	0 0 0 -70q�$��52��.+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $
��Icon��   Kind$ DeleteOutline=�$��32��$��32��$��Center=�
���P��� -   $��	Bottombar��$��	0 0 0 -70q�$��Center=�$��Bottom=�$��50��.+���  �� CornerRadius$ 8�����#2c3e50 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q�   Color$
 Gray��   
BlurRadius$ 20Q��� $ 
Horizontal=�.+��� 
�������$ 8��._��� -	    ��Name$
 Save��$��3��
������ 
���P��$��0q�  MaterialDesignPaperButton#��[ .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 8��$��Сохранить��$
��Thin"�$��16(� � Cursor$
 Hand��$��50���� -
   $ Clear��$��3��
������ 
�������
�������$��0q�#��[ $	 Dp0=�$ 8��$��Очистить��$
��Thin"�$��16(�$
 Hand��$��50��