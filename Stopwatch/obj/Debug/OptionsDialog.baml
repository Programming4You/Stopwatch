   M S B A M L   `   `   `  ����  	Stopwatch    Stopwatch.OptionsDialog   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=2.7.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f45xceed)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Options��5   	   $	��300��6   $	��300��6&    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterOwner=�6    � Icon$" resources/images/options.png��6C   .��5      ]� .+�5   
   �� $��Bottom=�6   $��Right=�6-    �� Orientation$ 
Horizontal=�6I   .+�5	      �� -   5        $��btnOK��5	   7    �� 	IsDefault . $��5,5,5,5q�6&   ��6D   ��  �� ElementName$ 	btnCancel�� �� Path$ ActualWidth�.��6�   OK6�   �� 5
      -   5        $��	btnCancel��5
   6    �� IsCancel . $��5,5,5,5q�6%   .��6G   Cancel6O   5      �� 5   
   $��10q�6   $��10q�6!   .@�5      �� $��General��6   .��5      � .+�5      �� -   5        $��chbStartStopInSplitTimes��5      .��6?   (&Add Start and Stop time in Split Times6g   5      5      �� 5      $
��View��6   .��5      � $	��200��6   	 � RowDefinitions	 5      �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   
 � ColumnDefinitions
 5      �� 5      $
��Auto �6+   �� 5      $��* �6+   .+�5      �� $��0��6   $��0��6)   .��69   Foreground Color:6L   #  Xceed.Wpf.Toolkit.ColorPicker  5      -   5        $��clpDisplayForegroundColor��5   (   $��0��6I   $��1��6V   �� 5      $��1��6   $��0��6)   .��69   Background Color:6L     5       -   5        $��clpDisplayBackgroundColor��5    (   $��1��6I   $��1��6V   5!      5"      5#      5%      5&      