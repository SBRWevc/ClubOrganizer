   M S B A M L   `   `   `  ����  ClubOrganizer-    'ClubOrganizer.Pages.Profile.UserProfile   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
FontFamily$  Poppins)�5
      .��5      � .+�5   
   �� $��16q�6   $��Center=�5      $��Center=�5      .+�5      �� -   5         ��Name$ 
PRF_avatar��5      $��/resources/avatar/man.png��5       �� BitmapScalingMode$ HighQuality=�5      $	��150��5      $	��150��5      $��10q�5      �� 5      -   5         ��Name$ PRF_fullname��5      $��Center=�5      $4��.Имя пользователя - полное��5      $
��Bold"�5      $��20(�5      �� 5      -   5        $ PRF_position��5      $��Center=�5      $��Должность��5      $��12(�5      $��Italic$�5      �� 5      $��	0 20 0 10q�6    �� Orientation$ 
Horizontal=�5       .+�5!      �� -   5         ��Name$ 	PRF_login��5!      
�������)  #MaterialDesignThemes.Wpf.HintAssist   
Background
 ����� !  MaterialDesignOutlinedTextBox#��[  5$         Hint$* $Введите новый логин��5%       �� 	MaxLength$ 15��5&      $	��240��5'      $��0 0 20 0q�5(      G� 5)      -   5        	 G�Name$	 PRF_pass��5)      
�������
 ����� + 'MaterialDesignOutlinedRevealPasswordBox#��[ 5,      $, &Введите новый пароль��5-      $	��240��5.      
 G� 	MaxLength$
 15��5/      50      51      � 52   
   -   5        $��Succes��52      $��Center=�53      $��Bottom=�54      $��	0 0 0 -70q�55      $��52��56      .+�57      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $
��Icon��5<   &      Kind$ DeleteOutline=�57   &   $��32��58   &   $��32��59   &   $��Center=�5:   &   
���P��5<   &   5=      � 5>   
   -   5        $��	Bottombar��5>      $��	0 0 0 -70q�5?      $��Center=�5@      $��Bottom=�5A      $��50��5B      .+�5C      ��  �� CornerRadius$ 8��6   ���#2c3e50 J� Effect 5E      3  -System.Windows.Media.Effects.DropShadowEffect  5F         ShadowDepth$ 0Q�6'      Color$
 Gray��5G   '      
BlurRadius$ 20Q�5H   '   5J      �� 5K      $ 
Horizontal=�6   .+�5L      �� 
�������$ 8��5M      ._�5N      �� -	   5         ��Name$
 Save��5N      $��3��5O      
������ 
���P��$��0q�5R        MaterialDesignPaperButton#��[ 5S      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=�5T      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 8��5U      $��Сохранить��5V      $
��Thin"�5W      $��16(�5X       � Cursor$
 Hand��5Y      $��50��5Z      5[      5\      �� 5]      -
   5        $ Clear��5]      $��3��5^      
������ 
�������
�������$��0q�5b      #��[ 5c      $	 Dp0=�5d      $ 8��5e      $��Очистить��5f      $
��Thin"�5g      $��16(�5h      $
 Hand��5i      $��50��5j      5k      5l      5m      5n      5o      