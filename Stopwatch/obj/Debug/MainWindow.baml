   M S B A M L   `   `   `  ����D  @Stopwatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Stopwatch.PropertiesStopwatch.Properties  5   	   %clr-namespace:Stopwatch	Stopwatch  5   	       Stopwatch.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   3prop"clr-namespace:Stopwatch.Properties     5   	   )localclr-namespace:Stopwatch     5   	     � Title$  	Stopwatch��5   	    � Icon$$ resources/images/stopwatch.png��5
   <   $	��650��6b   $	��450��6q   ��5   	   �� #  Stopwatch.Properties.Settings   Default �� Source# Z  �� Path$ MainWindowHeight� �� Mode$ TwoWay=���5   	      Stopwatch.SettingsBinding  $ MainWindowWidth�
 � Top 5	   	     $ MainWindowTop� � Left 5
   	     $ MainWindowLeft� J� InputBindings 5      �� 5   
   
	 �� Key$	 F5��6   
 �� Command
 6   �� $ Start�.��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5        $��mFileSaveAs��5      $��Save _As...��6.   6C   �� 5      m� 5      -   5        $��	mFileExit��5      $��E_xit��6,   6;   5      m� 5      $��_Tools��6   .@�5      m� -   5        $��mToolsOptions��5      $��
Options...��60   6D   5      m� 5      $��_Help��6   .@�5      m� -   5        $��
mHelpAbout��5      $��_About��6-   6=   5      5      �� 5   
   $��Bottom=�6   .@�5      �� .��5       �� -   5        $��txtSplitTimesCount��5       ��66   �� *SplitTimes.Count+ �� StringFormat$ Split times count: {0}��5!      5"      � 5#   
   $
��Left=�6    � RowDefinitions 5$      �� 5%      $��* �6    �� 5&      $
��Auto �6    �� 5'      $
��Auto �6     � ColumnDefinitions 5)      �� 5*      $��* �6#   �� 5+      $��* �6#   .+�5-      �� $��5,5,5,5q�6   $��0��6,   $��0��69   $��2��6I    �� ItemStringFormat$ hh\:mm\:ss\.ff��6�   ��6]   �� *
SplitTimes+6�   �� 5.      -   5        $��btnStart��5.      $��5,5,5,5q�6%   $��1��66   $��0��6C   ��6S   �� $ Start�.��5/      ��  �� Orientation$ 
Horizontal=�6   .+�50      �� $��10��6    $��10��6+   $��2,2,2,2q�67   
��� � �6H   �� 51      $��Start��6    52      53      �� 54      -   5        $��btnAdd��54      $��5,5,5,5q�6#   $��1��64   $��1��6A   .��6f   Add6k   �� 55      -   5        $��btnStop��55      $��5,5,5,5q�6$   $��2��65   $��0��6B   ��6S   �� $
 Stop�.��56      �� $ 
Horizontal=�6   .+�57      �� $��10��6    $��10��6+   $��2,2,2,2q�67   
���  ��6H   �� 58      $
��Stop��6    59      5:      �� 5;      -	   5        $��btnReset��5;      $��5,5,5,5q�6%   $��2��66   $��1��6C   ��6T   �� $ Reset�$��Reset��5<   7   5=      5>      � 5?      -
   5        $��
grdDisplay��5?      ��6%     $ DisplayBackgroundColor�.+�5@      (� .��5A      �� -   5        $��
txtDisplay��5A       ��62   �� $ Stopwatch.Elapsed�$ hh\:mm\:ss\.ff����5B        $ DisplayForegroundColor�5C      5D      5E      5F      