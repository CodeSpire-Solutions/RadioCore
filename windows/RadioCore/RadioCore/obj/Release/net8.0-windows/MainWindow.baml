   M S B A M L   `   `   `  ����   	RadioCore    RadioCore.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  	RadioCore��$	��400��$	��600�����	#FF1E1E1E.���  � RowDefinitions �� $��* ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+�� ���	#FF333333$��60��$	��Top=�$��0��$��3��.+��� $%��RadioCore - RadioPSR Livestream��$��Center=�$��Center=�$��20(�$
��Bold"�
��������� -    ��Name$ 	SongTitle��$��Radio PSR Livestream��$��16(�$��Medium"�
�������$
��Left=�$��Bottom=�$��	10,0,0,10q�$��1��$��0���� -    ��Name$ PlayPauseButton��$��80��$��80��$��Center=�$��Bottom=�$��0,0,0,20q�$��1��$��1������  �� 
TargetType" ��.R�� .+�A� 
����·�
������ �� $��Center=�$��Center=�.��� .+�F� -    F�Name$ PlayIcon��"����        р�� @KL �    ��� 	
���   � �� Stretch$ Uniform=�$��30��$��30��$��Center=�$��Center=��� -    ��Name$ 	PauseIcon��	 �� Orientation$	 
Horizontal=�$��Center=�$��Center=�$y�	Collapsed=�.+��� $��8��$��30��
���   ��� $��8��$��30��
���   �$��4,0,0,0q��� -   
 ��Name$
 VolumeSlider�� � Minimum$ 0Q� � Maximum$	 100Q� � Value$ 50Q�$	��150��$��Bottom=�$��Right=� �� TickFrequency$ 1Q� �� IsSnapToTickEnabled$
 True��$��	0,0,10,20q�$��1��$��2��