   M S B A M L   `   `   `  ����P  LArtGalleryApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ArtGalleryApplication.ViewArtGalleryApplication.View  5   	   Q-clr-namespace:ArtGalleryApplication.ViewModelArtGalleryApplication.ViewModel  6@   2    ,ArtGalleryApplication.View.InformationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:ArtGalleryApplication.View     5   	   C	viewmodel-clr-namespace:ArtGalleryApplication.ViewModel     6@     � Title$  InformationWindow��5   	   $	��450��6#   $	��800��60   .��5	      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� 
�������$��3��6(    �� Orientation$ 
Horizontal=�6<   $��50��6U   $��Center=�6a   .+�5      �� $E��?Выберите интересующую вас картину��6   $��10q�6@   $	��250��6L   �� 5      $	��300��6   $��10q�6#    �� SelectedIndex 5      �� *PieceOfArts+5      �� 5   
   $��1��6   $��3��6"   $ 
Horizontal=�66   $��Center=�6O   $	��383��6j   
�������.+�5      �� $	��200��6   $	��200��6!   $	��Top=�6-   $��15q�6E   �� 5      $	��350��6   $	��500��6#   
�������$
��Auto=�5       �� TextWrapping$
 Wrap=�5       .��6*   5"      5#      5%      5&      