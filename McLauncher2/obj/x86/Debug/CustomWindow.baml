   M S B A M L   `   `   `  ����  McLauncher2    McLauncher2.CustomWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5           MetroWindow#���   5   	     � Topmost  . $	��400��5   	   $	��400��6    � SizeToContent$ Height=�6%   .��5      ]� .+�5   
   �� $	��Top=�6   
���#�k�._�5	      ]� ��.  .+�5
      �� $
��Left=�6   $��SETTING��5      $��10,0,0,0q�5      $
��Left=�5      
�������$��Segoe UI)�5   ,   $��20(�6B   �� 5      -   5        $��Button_Exit��5      $��Right=�5        ImageButton#���  5      $��32��5       � ToolTip$0 *ウィンドウを閉じて終了します��5      
���2͚�.��5      �� $1��+/McLauncher2;component/res/appbar.close.png��6   5      5      5      �� 5   
   $	��Top=�6   
���#�k�$��1q�6>   ._�5      ]� .+�5      � $	��Top=�6    � ColumnDefinitions 5      �� 5      �� 5      $	��150 �6+    � RowDefinitions 5       �� 5!      $��50 �6(   �� 5"      �� 5#      .+�5%      �� $��USE CUSTOM BAT��6   $��0��5&      $��0��6%   $��Center=�5'      $��20(�5(      $Z Tカスタマイズしたバッチファイルを使うかどうかを設定します��5)      �� 5*      -   5        $��Button_UseCustom��50      $��0��5*      $��1��6*   $��10q�5+      $��18(�5,      
���  ��  OnOffButton#���  5.      $	��OFF��5/      51      �� 52      -   5        $��TextBox_Bat��58      $��0��52      $��2��6.   $��1��6B   $	��200��53      $��10q�6+    �� AcceptsReturn .   
BorderGray#��[ 55       �� TextWrapping$
 Wrap=�56      $��Segoe UI)�57      $��14(�64   58      �� 59      $��2��6    $��2��6-   $��10q�6A   $��Segoe UI)�5:       $
��13.5(�66   SPECIAL WORD�� 5;   -   #!{target} : Replace to target path�� 5<   B   +){exepath} : Replace to Minecraft.exe path�� 5=   J   :8{noupdate} : Replace to argument if is no-update enabled�� 5>   Y   ,*{log} : Replace to pause if is log enabled5@      5A      � 5B      $��Bottom=�6   $��50��6/   $��Bottom=�6;    5C      �� 5D      �� 5E      .+�5G      �� -   5        $��	button_ok��5G      $��0��5H      $��5q�6-     
TextButton#���  5I      $
��SAVE��5J      
��� ���5L      �� 5M      $��1��6   $��5q�6-   #���  5N       �� IsCancel . $��CANCEL��5P      5Q      5R      5S      5T      5U      