   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FinalProject.PagesFinalProject.Pages  5          FinalProject.Pages.Movies   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:FinalProject.Pages     5        N� Title$  Movies��5	       � 	Resources 5         movieViewSource��%   &	        �� 5   
   69   5      .��5      �� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��	35,5,35,0q�6.   .+�5      �� $��MOVIES PAGE��6     
HomeHeader#��[ 6+   $��	0,0,170,0q�6O   �� 5      -   5         ��Name$ movieSearch��5      $��i.e. movie name��6+     	SearchBox#��[ 6B   �� 5      -   5         ��Name$ 	btnSearch��5        	SearchBtn#��[ 6@   .��5      ��  
 search#��[ 6   5      5      �� 5   
     borders#��[ 6   ._�5      �� -   5         ��Name$ movieListView��5        lvStyle#��[ 6n   ��6.   ��  �� Source# [  ��5      �� 5      .R�5      � $��10,1,0,1q�6$    
 bgData#��[ 66   .+�5      �� $ Vertical=�6)   $	��540��6@   $��0,0,5,0q�6L   .+�5   "   ��   	dataTitle#��[ 6,   ��6O   �� *PrimaryTitle+6o   �� 5    "    	 dataDetails#��[	 6,   $
��Wrap=�6Q   ��5!       �� *	AirTime+6;   5"      �� 5%      $ Vertical=�6)   $	��150��6@   .+�5'   "   ��  
 datahighlights#��[
 6,   ��6T   �� *	TitleType+ �� StringFormat$ Show: {0:N0}��6�   �� 5(   "   #��[
 6,   ��6T   �� *
Duration+6p   �� 5)   "   #��[
 6,   ��6T   �� *	AdultFilm+6q   5*      5+      5,      5.      5/      50      51      