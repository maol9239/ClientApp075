   M S B A M L   `   `   `  ����E  AUi.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:De.HsFlensburg.ClientApp075.Ui.Desktop&De.HsFlensburg.ClientApp075.Ui.Desktop  5   	   C ?Logic.Ui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Lclr-namespace:De.HsFlensburg.ClientApp075.Logic.Ui.Wrapper;assembly=Logic.Ui,De.HsFlensburg.ClientApp075.Logic.Ui.Wrapper 5   	   7    1De.HsFlensburg.ClientApp075.Ui.Desktop.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:De.HsFlensburg.ClientApp075.Ui.Desktop     5   	   b	viewModelLclr-namespace:De.HsFlensburg.ClientApp075.Logic.Ui.Wrapper;assembly=Logic.Ui     5   	     � Title$  
MainWindow��5	   	   $	��120��6   $	��500��6)    � 	Resources 5      L  FDe.HsFlensburg.ClientApp075.Logic.Ui.Wrapper.ClientCollectionViewModel 
  myList��%   &	          5      6;   5      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5      A� $��0��6    A� Rows$ 3��6"   .+�5   
   �� $��Center=�6   $��Right=�6+   .��6G   
Identifier6S   �� 5   
   $��Center=�6   ��6-   ��  �� ElementName$ 
myDataGrid�� �� Path$ SelectedItem.Id�6m   �� 5   
   $��Center=�6   $��Right=�6+   .��6G   Name6M   �� 5   
   $��Center=�6   ��6-   �� $ 
myDataGrid��$ SelectedItem.Name��� 5      -   5        .��5   *   Rename frist Item6=   �� 5      -   5        .��5   -   Debug MainWindow-Objecct6G   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��
myDataGrid��5   #   $��1��6   ��65   ��  �� Source# [  6n   5      5      