   M S B A M L   `   `   `  ����G  CHotelManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HotelManager.ViewModelHotelManager.ViewModel  5   	   5clr-namespace:HotelManager.ViewHotelManager.View  5   	       HotelManager.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4vms$clr-namespace:HotelManager.ViewModel     5   	   1viewsclr-namespace:HotelManager.View     5   	   $	��600��5	   	   $	��920��6     � WindowStartupLocation$  CenterScreen=�5
   	   
������� � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	   .��5      �  � 	Resources 5   
    �� DataType-   'HotelManager.ViewModel.ProfileViewModel#   HotelManager.View.ProfileView6   0HotelManager.ViewModel.ApartmentListingViewModel%   HotelManager.View.ApartmentView1   +HotelManager.ViewModel.RoomListingViewModel    HotelManager.View.RoomView5   /HotelManager.ViewModel.FacilityListingViewModel$   HotelManager.View.FacilityView8	   2HotelManager.ViewModel.CreateDamageReportViewModel.
   (HotelManager.View.CreateDamageReportView��%w  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5       *,	 +)�� 5      "  6   .R�5        5      �� 5      "  6   .R�5        5      �� 5      "  6   .R�5        5      �� 5      "  6   .R�5        5      �� 5       " 	 6   .R�5!      
  5"      5#       � RowDefinitions 5%   
   �� 5&      $��30 �6   �� 5'      $
��575* �6   �� 5(      $��30 �6   .+�5+   
   �� -   5        $��2��5+      ���#E5E9F2._�5/      � $��Stretch=�6    � ColumnDefinitions 50      �� 51      $
��830* �6'   �� 52      $	��30* �6'   �� 53      $	��30* �6'   �� 54      $	��30* �6'   .+�57      (�  (� Stretch$ Uniform=�6   $
��Left=�58      $��8,0,0,0q�59      .��5:      �� $��Hotel Manager��6   ���#525D68$��SemiBold"�5<      $��16(�5=      5>      �� 5?      -   5        $��1��5?      $��14(�5@      $	��—��5A      
������ $��0q�5C      
�������$
��Bold"�5E      5F      �� 5H      -   5        $��2��5H      $��15(�5I      $	��☐��5J      
������ $��0q�5L      
�������$
��Bold"�5N      5O      �� 5R      -   5        $��3��5R      $��17(�5S      $	��✕��5T      $��0q�5U      
�������$
��Bold"�5W      ��5Y      �� 5Z      	 �� 
TargetType"	 ��6    .�5[      �� 
 �� Property
 � �� �� Value
 ���� 6;   �� 5\      
 � �� 5]   "   �� 5^   &    �� 
TargetType" ��66   .R�5_   *   �� #��z��61   ._�5`   .   �� $��Center=�6?   $��Center=�6\   5a   +   5b   '   5d       �� Triggers 5e      P� 5f   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5g   &   �� 
 � �� �#ED42456C   5h   #   5j      5l      5m      5n      �� 5r   
   $��1��6   $
��Auto��5s      ��5t      �� *CurrentViewModel+5v      5w      