   M S B A M L   `   `   `  ����L  HCalender Projects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Calender_ProjectsCalender_Projects  5   	   '    !Calender_Projects.CreateEventPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Calender_Projects     5   	     N� Title$  Create Event Page��5   	   $	��600��6#   $
��1080��60    N� ShowsNavigationUI .   � 	Resources 5
       �� 
TargetType �� Property �� Value��%  '��       '�� l     '�� �     �� 5   
   " ��6   .�5      ��  � ��$ 30��6.   �� 5       � ��$ 80��6-   5      �� 5   
   " ��6   .�5      ��  � ��$	  13(�6/   5      �� 5   
   " ��6   .�5      ��  � ��$	 150��6/   5      5      .��5      � 
����·�.+�5   
   ]� $��0,0,363,550q�6   .+�5      �� -   5         ��Name$ 	SaveEvent��5      $
��Save��5      $��10 0 0 0q�5      5      �� 5      -   5        $ GoBackEvent��5      $��Go Back��5      $��	0 0 450 0q�5      5       5!      �� 5"   
   $��0 62 1 0q�6   $��Center=�5#      .+�5%      ]� $��Center=�6   .+�5&      �� -   5         ��Name$ messages��5&      $��5q�5'      
�������$	��Top=�5)      $��Center=�5*      $	��Top=�5+      $��18(�5,      5.      ]� 50      $��0 0 0 20q�6   .+�51      �� -   5         ��Name$ EventNameLabel��51      $��Event Name:��52      $��0 0 0 0q�53      �� 54      -   5        	 ��Name$	 	EventName��54      $	��400��6.   $��25��55      $��	0 0 400 0q�56      57      �� 59      -   5        $ 
StartLabel��59      $��Start��5:      $��	0 0 980 0q�5;      �� 5<      -   5        
 ��Name$
 StartBox��5<      $��	0 0 860 0q�5=      �� 5>      -   5        $ EndLabel��5>      $	��End��5?      $��	0 0 980 0q�5@      �� 5A      -	   5        $
 EndBox��5A      $��0 0 860 150q�5B      6,   �� 5F      -
   5        $ 	DescLabel��5F      $��Description��5G      $��0 -120 0 110q�5H      �� 5I      -   5        $	 DescriptionBox��5I      $
��1000��6.   $	��300��5J      $��10,-110,9,0q�5K      5L      5M      5N      