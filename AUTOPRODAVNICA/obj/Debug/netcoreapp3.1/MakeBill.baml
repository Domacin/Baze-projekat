   M S B A M L   `   `   `  ????I  EAUTOPRODAVNICA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AUTOPRODAVNICAAUTOPRODAVNICA  5   	       AUTOPRODAVNICA.MakeBill   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AUTOPRODAVNICA     5   	   -   5          ? Title$  MakeBill??5   	   $	??450??6   $	??800??6'    ? 	Resources 5	         stavkaViewSource??%   &	        ?? 5
   
   6   5      .??5      ? .+?5   
   ?? -   5        $??slika??5       $
??Fill=?6   $
??Left=?6-   $??97??6H   $??	29,10,0,0q?6T   $	??Top=?6g   $	??745??6   ?? 5   
   $??	Musterija??6   $
??Left=?6$   $??
19,127,0,0q?6?   $	??Top=?6S   $??71??6k   ?? 5   
   -   5        $??musterijaComboBox??5      $
??Left=?6,   $??152,129,0,0q?6G   $	??Top=?6\   $	??120??6t   ?? 5   
   $??Stavka??6   $
??Left=?6!   $??
19,163,0,0q?6<   $	??Top=?6P   $??71??6h   ?? 5   
   -   5         ??Name$ stavkaComboBox_Copy??5      $
??Left=?60   $??152,165,0,0q?6K   $	??Top=?6`   $	??120??6x   ?? 5   
   -   5        $??CijenaLabel??5      $??Cijena??6#   $
??Left=?64   $??
19,217,0,0q?6O   $	??Top=?6c   $	??109??6{   ?? 5   
   -   5        $??Izdaj racun??5      $
??Left=?6'   $??158,220,0,0q?6B   $	??Top=?6W   $	??108??6o   6{   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ stavkaDataGrid??5         AutoGenerateColumns$ False??6+   $??369,127,21,80q?6G      CanUserReorderColumns$
 True??6?   ??6^   ??  ?? Source# [     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6%   	   
IsReadOnly$
	 True??6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   ?? *ItemId+6L     5      $ Amount??6%   $
	 True??6P   
 65   ?? *Amount+6P     5      $ Price??6%   $
	 True??6R   
 64   ?? *	ItemPrice+6R   5      5      5      