   M S B A M L   `   `   `  ????I  EAUTOPRODAVNICA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AUTOPRODAVNICAAUTOPRODAVNICA  5   	       AUTOPRODAVNICA.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AUTOPRODAVNICA     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5	         zaposleniViewSource  markaViewSource  musterijaViewSource  automobilViewSource  cenovnikViewSource  racunViewSource??%?   &	        &	      &	 &     &	 9     &	 L     &	 _     ?? 5
   
   6   ?? 5   
   6   ?? 5   
   6   ?? 5   
   6   ?? 5   
   6   ?? 5   
   6   5      .??5      ? .+?5   
   ?? $	??770??6   $	??375??6!   $	??Top=?6.   .@?5      ?? $??	Zaposleni??6   .??5      &   System.Windows.Controls.DataGrid  -   5          Name$ ZaposleniDataGrid??5         AutoGenerateColumns$ False??66      CanUserReorderColumns$
 True??6?   ??6R   ??  ?? Source# [     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6E      
IsReadOnly$
 True??6Q   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6-   ?? *WId+6Q     5      -   5        FirstNameColumn??$ 
First name??5   a   $ False??6u   	 6F   ?? *WfName+6u     5      -   5        LastNameColumn??$ 	Last name??5   `   $ False??6s   	 6E   ?? *WlName+6s     5      -   5        RadnoMjestoIDColumn??$ RM ID??5   c   $
 True??6r   	 6J   ?? *RmId+6r   5      5      ?? 5      $??Marka automobila??6   .??5         -   5        $ markaDataGrid??5       $ False??62   $
 True??6?   ??6N   ?? # [  5!        5"      $ ID??6I   $
 True??6U   	 6-   ?? *	BrandId+6U     5#      -   5        BrandNameColumn??$ 
Brand name??5#   d   $ false??6x   	 6F   ?? *	BrandName+6x     5$      -   5        BrandCountryColumn??$ Brand country??5$   d   $ false??6{   	 6I   ?? *BrandC+6{   5&      5'      ?? 5)      $??	Musterija??6   .??5*        -	   5        $ musterijaDataGrid??5*      $ False??66   $
 True??6?   ??6R   ?? # [  5+        5,      $ ID??6E   $
 True??6Q   	 6-   ?? *CId+6Q     5-      -
   5        CustomerFirstNameColumn??$ 
First name??5-   i   $ false??6}   	 6N   ?? *CfName+6}     5.      -   5        CustomerLastNameColumn??$ 	Last name??5.   h   $ false??6{   	 6M   ?? *ClName+6{   50      51      ?? 54      $??	Automobil??6   .??55        -   5        $ automobilaDataGrid??55      $ False??67   $
 True??6?   ??6S   ?? # [  56        57      $ Chasis Number??6K   $
 True??6b   	 6-   ?? *	ChasisNum+6b     58      -   5        ModelNameColumn??$ Model??58   `   $ false??6o   	 6F   ?? *Model+6o     59      -   5        YearOfProductionNameColumn??$ Year of production??59   k   $ false??6?   	 6Q   ?? *YearP+6?     5:      -   5        MarkaNameColumn??$ Marka ID??5:   `   $
 True??6r   	 6F   ?? *Marka+6r     5;      -   5        CenovnikNameColumn??$ Cenovnik ID??5;   f   $
 True??6{   	 6I   ?? *
Cenovnik+6{   5=      5>      ?? 5@      $??Cenovnik??6   .??5A        -   5        $ cenovnikDataGrid??5A      $ False??65   $
 True??6?   ??6Q   ?? # [  5B        5C      $ ID??6L   $
 True??6X   	 6-   ?? *
CenovnikId+6X     5D      -   5        StartDateColumn??$ 
Start date??5D      $ false??6?   	 6F   ?? *	DateStart+
 ?? StringFormat$
 
dd-MM-yyyy??6?     5E      -   5        EndDateColumn??$ End date??5E   {   $ false??6?   	 6D   ?? *	DateEnd+$
 
dd-MM-yyyy??6?   5G      5H      ?? 5J      $??Racun??6   .??5K        -   5        $ racunDataGrid??5K      $ False??62   $
 True??6?   ??6N   ?? # [  5L        5M      $ ID??6H   $
 True??6T   	 6-   ?? *BillId+6T     5N      -   5        PriceeColumn??$ Price??5N   a   $
 True??6p   	 6C   ?? *	BillPrice+6p     5O      -   5        BillDateColumn??$ 	Bill date??5O   }   $
 True??6?   	 6E   ?? *
BillDate+$
 
dd-MM-yyyy??6?     5P      -   5        MusterijaIDColumn??$ Musterija ID??5P   f   $
 True??6|   	 6H   ?? *	Musterija+6|     5Q      -   5        StavkaIDColumn??$ 	Stavka ID??5Q   `   $
 True??6s   	 6E   ?? *Stavka+6s   5S      5T      5X      ?? 5Z   
   -   5         ??Name$ 	AddWorker??5Z      $??Dodaj zaposlenog??6$   $
??Left=?6?   $??
15,389,0,0q?6Z   $	??Top=?6n   6?   ?? 5[   
   -   5        $??AddCar??5[      $??Dodaj automobil??6   $
??Left=?69   $??129,389,0,0q?6T   $	??Top=?6i   $	??100??6?   6?   ?? 5\   
   -   5        $??makeBillButton??5\      $??Izdaj racun??6'   $
??Left=?6=   $??244,389,0,0q?6X   $	??Top=?6m   $	??100??6?   6?   ?? 5]   
   -   5        $ 
saveButton??5]      $??Snimi??6%   $
??Left=?65   $??708,389,0,0q?6P   $	??Top=?6e   $??69??6}   6?   ?? 5^   
   -   5        $??dosaoNaServisButton??5^      $??Dosao na servis??6,   $
??Left=?6F   $??358,389,0,0q?6a   $	??Top=?6v   $	??100??6?   6?   ?? 5_   
   -   5        $ ObrisiAutoButton??5_      $??Obrisi auto??6J   $
??Left=?6`   $??474,389,0,0q?6{   $	??Top=?6?   $??98??6?   5`      5a      