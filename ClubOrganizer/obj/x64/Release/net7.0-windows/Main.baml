   M S B A M L   `   `   `  ����   ClubOrganizer    ClubOrganizer.Main   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��Main_Window��$��Poppins)�  �� BitmapScalingMode$  HighQuality=� � Title$ Club Organizer��$	��900��$
��1600�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � AllowsTransparency$
 True��
������  � Icon$ /resources/logo/logo.ico��.��� 
�������.+��� -   $��Progress��$��Center=�$��Center=�.+��� $#��/resources/logo/logo_text.png��$  HighQuality=�$	��380��$��10 20q��� $��Загрузка...��$��14(�
���P��$
��Left=�$��0q�$	��0 5q��  � IsIndeterminate$
 True�� #  MaterialDesignLinearProgressBar#��[  	 � Value$	 0Q�$��3��$	��400��� -   $��Frame��.+� � -   $��
Main_Frame��
  � NavigationUIVisibility$
 Hidden=��� -   $��Controls�� �� CornerRadius$ 0 0 0 8��
�������$��Right=�$	��Top=�._��� $��32�� �� Orientation$ 
Horizontal=�
������ .+��� -   $��Minimize��
������ $��0q�
�������  MaterialDesignPaperButton#��[ .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 0 0 0 8����'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Minimize=��� -   $��Close_square��
������ $��0q�
���  ��#��[ $	 Dp0=�$ 0����  $ Close=�� -   $��Sidebar��$
��Left=�$��-70 30 0 30q�$��50��.+��� -	   $��
ShadEffect��$ 8�����#2c3e50 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 20Q�   ShadowDepth$ 0Q�   Color$
 Gray��._�� .+�o� -
    o�Name$ Menu_contracts��$��0q�$��0q�.@�m� -    m�Name$ Items_contracts��$��	60 50 0 0q�$��0q����#2c3e50
�������.@�m� -   $��Fast_Tennis������ $ 
Horizontal=�.+�  $ TennisRacket=�$��20��$��20���� $��15 0 0 0q�$��Center=�$2��,Создать договор | Теннис��m� -   $��	Fast_Rent��$y�	Collapsed=����� $ 
Horizontal=�.+�  $
 Room=�$��20��$��20���� $��15 0 0 0q�$��Center=�$2��,Создать договор | Аренда���� m� -   $��Contracts_List������ $ 
Horizontal=�.+�  $ PaperOutline=�$��20��$��20���� $��15 0 0 0q�$��Center=�$%��Список договоров���� m� -   $��Service_List������ $ 
Horizontal=�.+�  $ ServiceToolbox=�$��20��$��20���� $��15 0 0 0q�$��Center=�$��Список услуг��o� -   $ Menu_clients��$��0q�$��0q�.@�m� -   $ Items_clients��$��
60 100 0 0q�$��0q����#2c3e50
�������.@�m� -   $��Client_List������ $ 
Horizontal=�.+�  $ AccountsOutline=�$��20��$��20���� $��15 0 0 0q�$��Center=�$#��Список клиентов��m� -   $��
Black_List������ $ 
Horizontal=�.+�  $ AccountLockOutline=�$��20��$��20���� $��15 0 0 0q�$��Center=�$��Чёрный список��o� -   $ Menu_profile��$��0q�$��0q�$��Bottom=�.@�m� -   $ Items_profile��$��60 0 0 0q�$��0q�.@�m� -   $��	Data_User������ $ 
Horizontal=�.+�  $ AccountOutline=�$��20��$��20���� $��15 0 0 0q�$��Center=�$��Профиль��m� -   $��	User_List������ $ 
Horizontal=�.+�  $ PeopleGroupOutline=�$��20��$��20���� $��15 0 0 0q�$��Center=�$��Пользователи���� $	��Top=�$��	0 0 0 180q�
������ .+��� -   $��Go2Sport��
������ 
�������
�������$��0q�#��[ $ 8 8 0 0��$	 Dp0=� � ToolTip$ Go2Sport�� ^� 	Placement$ Right=� ^� VerticalOffset$ 10�� ^� HorizontalOffset$ 5��$��0q�$��0q�$��50��$��50����0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Tennis=�   Size 30�� -   $
��Mail��
������ 
�������
�������$��0q�#��[ $ 0��$	 Dp0=�$ 
Почта��$ Right=�$ 10��$ 5��$��0q�$��0q�$��50��$��50����  $ EmailOutline=� 30�� -   $��	Contracts��
������ 
�������
�������$��0q�#��[ $ 0��$	 Dp0=�$ Договоры��$ Right=�$ 10��$ 5��$��0q�$��0q�$��50��$��50����  $ ContractOutline=� 30�� -   $��Clients��
������ 
�������
�������$��0q�#��[ $ 0��$	 Dp0=�$ Клиенты��$ Right=�$ 10��$ 5��$��0q�$��0q�$��50��$��50����  $ PeopleOutline=� 30�� -   $��Payment��
������ 
�������
�������$��0q�#��[ $ 0��$	 Dp0=�$ Оплаты��$ Right=�$ 10��$ 5��$��0q�$��0q�$��50��$��50����  $ BankOutline=� 30�� $��Bottom=�
������ .+��� -   $��Small��
������ 
�������
�������$��0q�#��[ $ 8��$	 Dp0=�$# Свернуть панель��$ Right=�$ 10��$ 5��$��0q�$��0q�$��50��$��50����  -   $��Arrow��$ 	ArrowDown=�$��30��$��30��z���  �� Angle$ 0Q� �� CenterX$ 15Q� �� CenterY$ 15Q��� -   $��Profile��
�������$��0q�#��[ $ 8 8 0 0��$	 Dp0=�$ Профиль��$ Right=�$ 10��$ 5��$��0q�$��0q�$��50��$��50����  $ UserOutline=� 30�� -    $��
Requisites��
�������$��0q�#��[ $ 0��$	 Dp0=�$ Настройки��$ Right=�$ 10��$ 5��$��0q�$��0q�$��50��$��50����  -!   $��Settings��$ SettingsOutline=�$��30��$��30��z��� $ 0Q�$ 15Q�$ 15Q��� -"   $
��Exit��
�������$��0q�#��[ $ 0 0 8 8��$	 Dp0=�$$ Выйти из профиля��$ Right=�$ 5��$��0q�$��0q�$��50��$��50����  $ 	ExitToApp=� 30)  #MaterialDesignThemes.Wpf.DialogHost  -#   $��Main_Dialog��   CloseOnClickAway$ False��    DialogTheme$  Inherit=�  MaterialDesignShadowBrush!   OverlayBackground#! �  "   	Placement$" Center=�#   DialogContent# �� $ 8��
�������$��Center=�$��Center=�._��� .+�  $ ErrorOutline=�$��Center=�$��Center=�$��20q�$��45��$��45���� -$   $��Error_Title��$��
20 0 20 20q�$��Center=�$��Center=�$��20(�$
��Bold"�