   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FinalProjectFinalProject  5   	       FinalProject.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:FinalProject     5   	   -   5           icon  � Icon#  [  5   	    � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)   
�������.��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5        $��_Exit��5      6*   5      m� 5      $��_Pages��6   .@�5      m� -   5         m�Name$
 Home��5      $��_Home��6)    m� Icon 5      �� 5        home#��[ 6    5      m� 5      -   5        $ 
ViewMovies��5      $��_View Movies��6/    5      �� 5       	 movie#��[ 6    5      m� 5      -   5        $ 
ViewActors��5      $��_View Actors��6/    5      �� 5       	 actor#��[ 6    5!      m� 5"      -   5        $ 
ViewGenres��5"      $��_View Genres��6/    5#      �� 5$       	 genre#��[ 6    5&      5'      5(      c� 5)   
   -   5         c�Name$ toolbar��5)      $��Bottom=�6#    `� IsLocked$
 True��5*        
NavToolbar#��[ 5+       � 	Resources 5,       �� 
TargetType �� Property	 �� Value��%V   ']�       �� 5-      " ]�6   .�5.      ��  � ��$	 Center=�6<   5/      50      .@�52      �� 
 �� Orientation$
 
Horizontal=�6   $��50��62    c� OverflowMode$ Never=�6>   .+�53      �� -   5         ��Name$ 
HomeButton��53       � ToolTip$ Go to Home Page��6@     	NavButton#��[ 6Z   .��54      �� #��[ 6   55      �� 56      -	   5        $ MovieButton��56      $ Go to Movies Page��6G   #��[ 6c   .��57      �� #��[ 6   58      �� 59      -
   5        $ ActorButton��59      $ Go to Actors Page��6G   #��[ 6c   .��5:      �� #��[ 6   5;      �� 5<      -   5        $ GenreButton��5<      $ Go to Genres Page��6G   #��[ 6c   .��5=      �� #��[ 6   5>      5?      5@       � 5A   
   -   5          �Name$ 	mainFrame��5A      $
��Auto��6#   $
��Auto��61     � NavigationUIVisibility$ Hidden=�6>   $��Bottom=�5B      5C      5D      5E      