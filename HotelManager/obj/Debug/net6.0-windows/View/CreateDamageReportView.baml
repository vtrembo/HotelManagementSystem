   M S B A M L   `   `   `  ����G  CHotelManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HotelManager.ViewHotelManager.View  5      .    (HotelManager.View.CreateDamageReportView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HotelManager.View     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $	��70* �6   �� 5      $
��430* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��100* �6#   �� 5      $	��70* �6#   �� 5      $	��70* �6#   �� 5      $
��100* �6#   �� 5      $	��50* �6#   .+�5      (� $��0��5      $
��Left=�5      $��5,0,0,0q�5      .��5      �� $��Damage Report��5      ���#525D68$��SemiBold"�5      5!      (� 5#      $��2��5$      $��Center=�5%      .��5'      �� $��Profile��5(      ���#525D68$��SemiBold"�5*      $��2(�5+      $��0q�6   
������ ��5-      �� *NavigateProfileCommand+5.      (� 50      $��3��51      $��Center=�52      .��54      �� $��vtrembovetsky@hotel.com��55      ���#525D68$��SemiBold"�57      $��8(�58      5:      (� 5<      $��4��5=      $��Right=�5>      $��0,0,5,0q�5?      .��5@      �� $��Log out��5A      ���#525D68$��SemiBold"�5C      $��6(�5D      5F      5H      �� 5J   
   $��1��5K      ���#E5E9F25M      �� 5O   
   $��1��6   $��50��5P      $	��100��6   $	��Top=�5R      $
��Left=�5S      $��	20,20,0,0q�5T      ���#525D68$��SemiBold"�5V      $��28(�5W      ��5Q      �� *ChoosenFacility+5W      (� 5Z   
   $��1��5[      $��center=�5\      $	��top=�5]      $��70��5^      $	��200��6   $��0,10,0,0q�5_      .��5a      �� $��Description��5b      ���#525D68$��SemiBold"�5d      5f      �� 5h   
   $��1��6   $	��400��5i      $	��180��5j      $	��Top=�5k      $��0,80,0,0q�5m      
���������5l      �� *Description+5n      �� 5q   
   $��1��6   $��70��5r      $	��180��6   $��Center=�5s      
�������$��SemiBold"�5u      $��16(�5v      $��Create report��5w      ���#525D68$��0q�5y      $��	0,200,0,0q�5z      ��5{      �� *CreateDamageReportCommand+5      5�      