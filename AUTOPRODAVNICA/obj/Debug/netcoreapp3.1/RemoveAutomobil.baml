   M S B A M L   `   `   `  ????I  EAUTOPRODAVNICA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AUTOPRODAVNICAAUTOPRODAVNICA  5   	   $    AUTOPRODAVNICA.RemoveAutomobil   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AUTOPRODAVNICA     5   	   -   5          ? Title$  RemoveAutomobil??5   	   $	??450??6!   $	??800??6.    ? 	Resources 5
         automobilViewSource??%   &	        ?? 5   
   6   5      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??46* ?6   ?? 5      $
??333* ?6   .+?5   
   ?? -   5        $??slika??5      $
??Left=?6   $??97??68   $??	29,10,0,0q?6D   $	??Top=?6W   $	??759??6o   $??2??6{   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ automobilaDataGrid??5         AutoGenerateColumns$ False??6/      CanUserReorderColumns$
 True??6?   $??329,143,10,41q?6?   $??1??6?   ??6K   ??  ?? Source# [     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Chasis Number??6C   	   
IsReadOnly$
	 True??6Z   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   ?? *	ChasisNum+6Z     5      -   5        ModelNameColumn??$ Model??5   X   $
	 True??6g   
 6>   ?? *Model+6g     5      -   5        YearOfProductionNameColumn??$ Year of production??5   c   $
	 True??6   
 6I   ?? *YearP+6     5      -   5        MarkaNameColumn??$ Marka ID??5   X   $
	 True??6j   
 6>   ?? *Marka+6j     5      -   5        CenovnikNameColumn??$ Cenovnik ID??5   ^   $
	 True??6s   
 6A   ?? *
Cenovnik+6s   5      ?? 5   
   -   5        $??autoComboBox??5      $
??Left=?6'   $??
29,143,0,0q?6B   $	??Top=?6V   $	??120??6n   $??2??6z   ?? 5   
   -	   5         ??Name$
 Done??5      $??Ok??62   $
??Left=?6?   $??
29,373,0,0q?6Z   $	??Top=?6n   $	??120??6?   $??2??6?   5      5       