   M S B A M L   `   `   `  ????I  EAUTOPRODAVNICA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AUTOPRODAVNICAAUTOPRODAVNICA  5   	   "    AUTOPRODAVNICA.DosaoNaServis   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AUTOPRODAVNICA     5   	   -   5          ? Title$  DosaoNaServis??5   	   $	??350??6   $	??400??6,    ? 	Resources 5	         musterijaViewSource??%   &	        ?? 5
   
   6   5      .??5      ? $??10,0,0,0q?6    ? ColumnDefinitions 5   
   ?? 5      $??2* ?6   ?? 5      $	??63* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ musterijaDataGrid??5         AutoGenerateColumns$ False??6.      CanUserReorderColumns$
 True??6?   $??1??6?   $??158,117,10,10q?6?   ??6J   ??  ?? Source# [     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6=   	   
IsReadOnly$
	 True??6I   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   ?? *CId+6I     5      -   5        CustomerFirstNameColumn??$ 
First name??5   a   $
	 true??6u   
 6F   ?? *CfName+6u     5      -   5        CustomerLastNameColumn??$ 	Last name??5   `   $
	 True??6s   
 6E   ?? *ClName+6s   5      ?? 5   
   -   5        $??slika??5      $
??Left=?6   $??97??68   $??	33,10,0,0q?6D   $	??Top=?6W   $	??293??6o   $??1??6{   ?? 5   
   -   5        $??musterijeComboBox??5      $
??Left=?6,   $??	8,130,0,0q?6G   $	??Top=?6Z   $	??120??6r   $??1??6~   ?? 5   
   -   5        $??Ok??5      $
??Left=?6   $??
13,192,0,0q?69   $	??Top=?6M   $	??115??6e   $??1??6?   5      5      