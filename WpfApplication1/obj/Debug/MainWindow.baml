   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WpfApplication1.ViewModelsWpfApplication1.ViewModels  5   	   =#clr-namespace:WpfApplication1.ViewsWpfApplication1.Views  5   	        WpfApplication1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   >	ViewModel(clr-namespace:WpfApplication1.ViewModels     5   	   5views#clr-namespace:WpfApplication1.Views     5   	     � Title$&   Gestion de Pedidos - Offline App��5   	   $	��600��62   $	��800��6?    � DataContext 5      4   .WpfApplication1.ViewModels.MainWindowViewModel  5   
   6*   .��5
      � ���	#FFD2EBF9 � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   � -   5         �Name$
 Menu��5      $��0��6   .+�5      c� $
��Left=�6   $	��Top=�61   $��0��6I   .@�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  � ToolTip$ Opcion 1��6   $��30��60   $��30��6<   .��5      �� .��5      �� $��images/String.jpg��6$   $
��Fill=�6?   6P   5      5      �� 5      $ Sincronizar Pedidos��6   $��5,0,0,0q�6;   $��30��6L   $	��150��6X   ��6d   �� *PedidosWebServiceCommand+.��5      �� .+�5      �� $��Sincronizar Pedidos��6(   6E   5!      5"      �� 5#      $&  Sincronizar Productos y Clientes��6   $��5,0,0,0q�6H   $��30��6Z   $	��180��6f   ��6r   �� *ProductWebServiceCommand+.��5$      �� .+�5%      �� $&�� Sincronizar Productos y Clientes��6(   $
��Left=�6P   6m   5'      5(      5)      5*      5+      �� 5-   
   $��1��6   6$   � 5/   
   $��2��6   .+�50      �� $��5q�6=   ��6   �� *	Pantallas+6J   51      �� 53   
   $��3��6   6$   �� 55   
   $��4��6   $��Right=�6"   $ 
Horizontal=�6>   .+�56      �� -   5         ��Name$ txtPieVista��56      $��22��6+   $��Right=�67   $��0,4,0,0q�6S    �� TextAlignment$ Right=�6d   $	��Top=�6z   $	��500��6�   ���	#FFD2EBF9���	#FFD2EBF96�   57      59      5:      