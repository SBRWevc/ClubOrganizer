   M S B A M L   `   `   `  ����   ClubOrganizer#    ClubOrganizer.Pages.Auth.Auth   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
FontFamily$  Poppins)�.��� -   $��	Main_Back��
������ .+���  �� CornerRadius$ 8��$	��800��$	��500�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ Black��   ShadowDepth$ 0Q�   
BlurRadius$ 30Q��� $ 8��$	��800��$	��500������  �� Color$ White�� �� Opacity$	 0.2Q�._��  � ColumnDefinitions �� �� .+��� $��Center=�$��Center=�$��0��.+��� $%��Уже есть аккаунт?��
�������$��23(�$
��Thin"�	 �� ClearTypeHint$	 Enabled=��� -   $��	Form_Auth��$��Center=�
������ 
�������
���P��   MaterialDesignPaperButton#��[  .  (MaterialDesignThemes.Wpf.ElevationAssist
   	Elevation$	
 Dp0=�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 4��$"��Авторизоваться��$
��Thin"�$��16(�$��
15 15 15 0q��� $��Center=�$��Center=�$��1��.+��� $<��6Зарегестрировать сотрудника?��
�������$��23(�$
��Thin"�$	 Enabled=��� -   $��Form_Reg��$��Center=�
������ 
�������
���P��#��[  $	
 Dp0=�$ 4��$&�� Зарегистрировать��$
��Thin"�$��16(�$��
15 15 15 0q��� -   $��FormAn��$ 8��
�������$	��600��$	��400��$��	0 0 400 0q�._�� .+�� -   $��	Data_Auth��$	��600��$	��400��$��0 0 0 0q�.+��� $��Center=�$��Center=�$	��368��.+��� $#��/resources/logo/logo_text.png�� �� BitmapScalingMode$ HighQuality=�$��
30 0 30 15q�$	��114���� $��Вход��$��Poppins)�$��20(�$��
30 0 30 15q�$��DemiBold"����	#FF434343�� -   $��
Auth_Login��
�������)  #MaterialDesignThemes.Wpf.HintAssist   
Background
 ����� ! MaterialDesignOutlinedTextBox#��[ $	
 Dp0=�   Hint$ Введите логин��$��
30 0 30 15q�$��52��G� -   $��	Auth_Pass��
�������
 ����� + 'MaterialDesignOutlinedRevealPasswordBox#��[ $	
 Dp0=�$! Введите пароль��$��
30 0 30 30q�$��52���� -   $��btn_auth��
���P��
�������#��[  $	
 Dp0=�$ 5��$"��Авторизоваться��$
��Thin"�$��16(�$��45��$��	30 0 30 0q�� -	   $��Data_Reg��$	��600��$	��400��$��	800 0 0 0q�.+��� $��Center=�$	��574��.+��� $��Регистрация��$��Poppins)�$��20(�$��
30 0 30 15q�$��DemiBold"����	#FF434343 �� TextAlignment$ Right=��� -
   $��Reg_Lastname��
�������
 �����#��[ $	
 Dp0=�$# Введите фамилию��$��
30 0 30 12q�$��52���� -   $��Reg_Name��
�������
 �����#��[ $	
 Dp0=�$ Введите имя��$��
30 0 30 12q�$��52���� -   $��Reg_Secondname��
�������
 �����#��[ $	
 Dp0=�$% Введите отчество��$��
30 0 30 12q�$��52���� -   $��Reg_Position��
�������
 ����� " MaterialDesignOutlinedComboBox#��[ $	
 Dp0=�$) #Выберите должность��$��
30 0 30 12q�$��52��.@��� $��Управляющий���� $ ��Администратор���� $��Тренер���� -   $��	Reg_Login��
�������
 �����#��[ $	
 Dp0=�$ Введите логин��$��
30 0 30 12q�$��52��G� -   $��Reg_Pass��
�������
 �����#��[ $	
 Dp0=�$! Введите пароль��$��
30 0 30 12q�$��52��G� -   $��Reg_PassConf��
�������
 �����#��[ $	
 Dp0=�$) #Подтвердите пароль��$��
30 0 30 30q�$��52���� -   $��btn_reg��
��� � �
��� � �
�������#��[  $	
 Dp0=�$ 5��$*��$Зарегистрироваться��$
��Thin"�$��16(�$��45��$��
30 0 30 30q�)  #MaterialDesignThemes.Wpf.DialogHost  -   $��Conf_Dialog��   CloseOnClickAway$
 True��   DialogTheme$ Inherit=�  MaterialDesignShadowBrush   OverlayBackground# �     	Placement$ Center=�   DialogContent �� $ 10��
�������$��Center=�$��Center=�._��� .+��� $(��"/resources/logo/logo_text_conf.png��$ HighQuality=�$��30 30 30 30q�$	��114���� -   $��
Conf_Login��
�������
 �����#��[ $< 6Введите логин администратора��$��52��$��
30 0 30 15q�G� -   $��	Conf_Pass��
�������
 ����� % !MaterialDesignOutlinedPasswordBox#��[ $	
 Dp0=�$F @Подтвердите пароль администратора��$��
30 0 30 30q�$��52���� -   $��conf_btn��
��� � �
�������
��� � �#��[  $	
 Dp0=�$ 5��$��Подтвердить��$
��Thin"�$��16(�$��45��$��
30 0 30 30q�