   M S B A M L   `   `   `  ����W  Shearthstonecopybraskoprojekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:hearthstonecopybraskoprojekthearthstonecopybraskoprojekt  5   	   -    'hearthstonecopybraskoprojekt.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:hearthstonecopybraskoprojekt     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $	��280 �6   �� 5      $��50 �6   �� 5      $��80 �6   �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ label1��5      $��2��6    $��1��6-   $��karta1��6=   $��Center=�6N   $��Center=�6i   
���   �$��1q�6�   �� 5   
   -   5        $ label2��5      $��2��6    $��2��6-   $��karta2��6=   $��Center=�6N   $��Center=�6i   
���   �$��1q�6�   �� 5   
   -   5        $ label3��5      $��2��6    $��3��6-   $��karta3��6=   $��Center=�6N   $��Center=�6i   
���   �$��1q�6�   �� 5   
   -   5         ��Name$ NewDraftButton��5      $��3��6)   $��3��66   $��30,20,30,20q�6F   $��	new draft��6[   6o   �� 5   
   -   5        $ showdeck��5      $��3��6#   $��2��60   $��30,20,30,20q�6@   $��	show deck��6U   6i   �� 5    
   -   5        $ PocetKaretLabel��5       $��3��6)   $��1��66   $��30,20,30,20q�6F   $��pocet karet: 0/?��6[   $��Center=�6v   $��Center=�6�   
���   �$��1q�6�   �� 5"   
   -   5        $ karta1��5"      $��1��6!   $��1��6.   $��10,10,10,10q�6>   6S   �� 5#   
   -   5        $ karta2��5#      $��1��6!   $��2��6.   $��10,10,10,10q�6>   6S   �� 5$   
   -	   5        $ karta3��5$      $��1��6!   $��3��6.   $��10,10,10,10q�6>   6S   5+      5,      