   M S B A M L   `   `   `  ����   ClubOrganizer7    1ClubOrganizer.Pages.List_contracts.List_contracts   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
FontFamily$  Poppins)�.��� .+�� $��108 38 38 58q�$��Center=� � RowDefinitions �� $��43 ��� .+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�$��0��$��5��.+�F� ���� N����@H����	$��0 3 0 0q�$��2��$��1��
���   � �� Stretch$
 Fill=�$��Center=�$��50���� $��Club Oganizer��$��24(�$
��Bold"�
���P��$��Center=�$��15 0 0 0q�F� $��1������ T�* ��� T�*���	���	#FFF4F4F5$��Center=�$��45��$��2��
���   �$
 Fill=�$��Center=�$��1��$
��10 0q��� $��Договоры��$��24(�$
��Bold"�
���   �$��Center=�$��0 0 15 0q�F� ���� N����@H����	$��0 3 0 0q�$��2��$��1��
���   �$
 Fill=�$��Center=�$��50��&   System.Windows.Controls.DataGrid  -     Name$ DataContracts��$��1��
�������   MaterialDesignDataGrid#��[     HeadersVisibility$ Column=�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ 1* $	��Top=� �� TextAlignment$
 Left=�   CanUserAddRows$ False��	   CanUserDeleteRows$	 False��
   CanUserReorderColumns$
 False��   CanUserResizeColumns$ False��   CanUserSortColumns$
 True��   
IsReadOnly$
 True��
�������$��0 10 0 0q�$	��751��$��1q�
���   �$
��True��   Columns 4  .System.Windows.Controls.DataGridCheckBoxColumn   - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [  4 0MaterialDesignDataGridCheckBoxColumnEditingStyle   EditingElementStyle# [ ,  &System.Windows.Controls.DataGridColumn   Width$ 60    
IsReadOnly$ False��   CanUserSort$ False��� -   $��Succes��$��Center=�$��Bottom=�$��705 0 0 -90q�$��70��.+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $
��Icon��   Kind$ DeleteOutline=�$��32��$��32��$��Center=�
���P��� -   $��BottombarSearch��$��-125 0 0 -90q�$��2��$��Center=�$��Bottom=�$��70��.+���  �� CornerRadius$ 8��
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q�   Color$
 Gray��   
BlurRadius$ 20Q��� $ 
Horizontal=�.+��� -   $��
ClientList�� " MaterialDesignOutlinedComboBox#��[ )  #MaterialDesignThemes.Wpf.HintAssist   Hint$: 4Поиск существующего клиента��
������    
Background
 ����� �� 
IsEditable$
 True��$	��400��$��10 0 0 0q����� �� $ 8�����#2c3e50$��Center=�$
��Left=�$��20 0 0 0q�._��� 
������ $ 
Horizontal=�.+��� -   $��ClientSearch��$��2��
������ 
�������
�������$��0q�  MaterialDesignPaperButton#��[ .	  (MaterialDesignThemes.Wpf.ElevationAssist 	  	Elevation$	 Dp0=�+
  %MaterialDesignThemes.Wpf.ButtonAssist 
  CornerRadius$ 8 0 0 8�� � ToolTip$7 1Поиск договоров по клиенту��  ^� 	Placement$  Bottom=�$��0q�$��70��$��70����0  *MaterialDesignThemes.Wpf.PackIconExtension  !   Kind$! Search=�"   Size" 30�� -   $��ClientReset��$��2��$��Center=�$
��Left=�
������ 
�������
�������$��0q�#��[ $	 Dp0=�$ 0 8 8 0��$0 *Сбросить выбор клиента��$	  Top=�$��0q�$��70��$��70����  $! Cancel=�" 30� -   $��	Bottombar��$��705 0 0 -90q�$��2��$��Center=�$��Bottom=�$��70��.+��� $ 8�����#2c3e50   $ 0Q�$
 Gray��$ 20Q��� $ 
Horizontal=�.+��� -	   $��Update��$��3��$��Center=�
������ 
�������
�������$��0q�#��[ $	 Dp0=�$ 8��$ Обновить��$	  Top=�# � Cursor$
# Hand��$��0q�$��70��$��70����  $! Update=�" 30�� 
�������$ 8��._��� -
   $	��Pay��$��3��$��Center=�
������ 
���P��$��0q�#��[ $	 Dp0=�$ 8��$ Оплатить��$	  Top=�$
# Hand��$��0q�$��70��$��70����  $! AccountPaymentOutline=�" 30�� -   $��Print��$��3��$��Center=�
������ 
�������
�������$��0q�#��[ $	 Dp0=�$ 8��$ Печать��$	  Top=�$
# Hand��$��0q�$��70��$��70����  $! PrinterOutline=�" 30)  #MaterialDesignThemes.Wpf.DialogHost  -   $��Main_Dialog��$   CloseOnClickAway$$ False��%   DialogTheme$% Inherit=�  MaterialDesignShadowBrush&   OverlayBackground#& �  '   	Placement$' Center=�(   DialogBackground
( ���� )   DialogContent) �� $��Center=�$��Center=�.+��� $��1��$��1��$��Center=�$	��380�����#2c3e50$ 8��._��� $��15q�.+��� $��Оплатить?��$��25(�$��Center=�$	��Top=�$��0 0 0 20q�
��������� $ 5��
�������._��� .+��� $ 
Horizontal=�$��Center=�.+��� $!��Сумма к оплате:��$��15(�$��12 12 15 12q��� -   $
��Rest��$��15(�
���P��$
��Bold"�$��15 12 12 12q��� -   $	��Sum��
������ 
 ����� ! MaterialDesignOutlinedTextBox#��[ $, &Введите сумму оплаты��$��12q��� $��0 20 0 0q�$��Center=����#2c3e50$ 8��$��50��._��� $ 
Horizontal=�.+��� $ 8��
�������._��� -   * ��Name$* PayRest��
������ 
���P��$��0q�#��[ $	 Dp0=�$ 8��$
��Да��$
��Thin"�$��16(�$��50��$��60��$
# Hand���� -   $* Cancel��
������ 
�������
�������$��0q�#��[ $	 Dp0=�$ 8��$��Нет��$
��Thin"�$��16(�$��50��$��60��$
# Hand��