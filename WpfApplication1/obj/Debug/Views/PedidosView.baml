   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApplication1.ViewsWpfApplication1.Views  5      G(clr-namespace:WpfApplication1.ViewModelsWpfApplication1.ViewModels  5      '    !WpfApplication1.Views.PedidosView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfApplication1.Views     5      ?
viewModels(clr-namespace:WpfApplication1.ViewModels     5        � DataContext  5
      1   +WpfApplication1.ViewModels.PedidosViewModel  5   
   6(   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $
��Left=�6;   .+�5      �� $��Pedido��6   $��22(�6%   $
��Bold"�63   $��0��6E   $��0��6U   $��0,0,0,0q�6b   $
��Left=�6s   $	��Top=�6�   6�   �� 5       � ToolTip$ Guardar��6>   $��	622,0,0,0q�6P   $��30��6d   $��30��6p   ��6   �� *GuardarPedidoCommand+.��5      �� .��5      �� $0��*/WpfApplication1;component/Images/Save.png��6   $
��Fill=�6P   6a   5      5      �� 5      $ Cancelar��6?   $��5,0,0,0q�6R   $��30��6d   $��30��6p   ��6   �� *CancelarPedidoCommand+.��5      �� .��5      �� $2��,/WpfApplication1;component/Images/Cancel.png��6   $
��Fill=�6R   6c   5      5      5       � 5"   
   $��1��6   .+�5#      �� $��5q�6@   ��6   �� *SubPantallas+6M   5$      5&      5'      