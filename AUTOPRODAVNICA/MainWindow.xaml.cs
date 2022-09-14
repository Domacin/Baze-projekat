using AUTOPRODAVNICA.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AUTOPRODAVNICA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AUTOPRODAVNICAContext autoContext = new AUTOPRODAVNICAContext();
        private CollectionViewSource zaposleniViewSource;
        private CollectionViewSource markaViewSource;
        private CollectionViewSource musterijaViewSource;
        private CollectionViewSource automobilViewSource;
        private CollectionViewSource cenovnikViewSource;
        private CollectionViewSource racunViewSource;
        List<Marka> listaMarki;
        List<int> idAuto;
         

        public MainWindow()
        {
            InitializeComponent();
            zaposleniViewSource = (CollectionViewSource)FindResource(nameof(zaposleniViewSource));
            markaViewSource = (CollectionViewSource)FindResource(nameof(markaViewSource));
            musterijaViewSource = (CollectionViewSource)FindResource(nameof(musterijaViewSource));
            automobilViewSource = (CollectionViewSource)FindResource(nameof(automobilViewSource));
            cenovnikViewSource = (CollectionViewSource)FindResource(nameof(cenovnikViewSource));
            racunViewSource = (CollectionViewSource)FindResource(nameof(racunViewSource));
        }


        //Dugem dodaj zaposlenog
        private void AddWorker_Click(object sender, RoutedEventArgs e)
        {
            AddZaposleni z = new AddZaposleni();
            z.ShowDialog();
            Zaposleni zz = new Zaposleni();

            zz.WfName = z.Name1;
            zz.WlName = z.Lastname;
            if (z.RadnoMjesto == "Servis")
                zz.RmId = 1;
            else if (z.RadnoMjesto == "Radnja")
                zz.RmId = 2;
            autoContext.Zaposleni.Add(zz);
            autoContext.SaveChanges();
            Window_Loaded(sender,e);
        }


        //dugme dodaj Auto
        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            AddAutomobil aa = new AddAutomobil();
            aa.ShowDialog();  
            listaMarki = autoContext.Marka.ToList();
            

            Automobil a = new Automobil();
            foreach (var item in listaMarki)
            {
                if(item.BrandName == aa.Marka)
                {
                    a.Marka = item.BrandId;
                    break;
                }

            }
            a.Model = aa.Model;
            a.YearP = aa.GodinaProizvodnje;
            a.Cenovnik = aa.Cenovnik;
            autoContext.Automobil.Add(a);
            autoContext.SaveChanges();

            List<Automobil> listA = new List<Automobil>();
            listA = autoContext.Automobil.ToList();
            idAuto = new List<int>();
            foreach (var item in listA)
            {
                idAuto.Add(item.ChasisNum);
            }
            int chasis = idAuto.Last();

            
            //ovo je zakomentarisano jer postoji triger koji poziva ovaj dio koda automatski
            //Radnjaautomobil ra = new Radnjaautomobil();
            //ra.AutoId = chasis;
            //ra.RadId = 2;
            //autoContext.Radnjaautomobil.Add(ra);
            //autoContext.SaveChanges();

           


            Window_Loaded(sender, e);
        }

        private void makeBillButton_Click(object sender, RoutedEventArgs e)
        {
            MakeBill mb = new MakeBill();
            mb.ShowDialog();

            Racun r = new Racun();

            r.BillDate = mb.Vrijeme;
            string vrijeme = r.BillDate.ToString("yyyy-MM-dd");
            r.BillPrice = mb.Ukupno;
            r.Musterija = mb.Musterija;
            r.Stavka = mb.Stavka;

            autoContext.Racun.Add(r);
            autoContext.SaveChanges();

            Window_Loaded(sender, e);

           

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            autoContext.Automobil.Load();
            autoContext.Cenovnik.Load();
            autoContext.Marka.Load();
            autoContext.Musterija.Load();
            autoContext.Racun.Load();
            autoContext.Zaposleni.Load();
            autoContext.Radnjaautomobil.Load();

            automobilViewSource.Source = autoContext.Automobil.Local.ToObservableCollection();
            cenovnikViewSource.Source = autoContext.Cenovnik.Local.ToObservableCollection();
            markaViewSource.Source = autoContext.Marka.Local.ToObservableCollection();
            musterijaViewSource.Source = autoContext.Musterija.Local.ToObservableCollection();
            racunViewSource.Source = autoContext.Racun.Local.ToObservableCollection();
            zaposleniViewSource.Source = autoContext.Zaposleni.Local.ToObservableCollection();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            autoContext.Dispose();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            int n = autoContext.SaveChanges();
            racunDataGrid.Items.Refresh();
            automobilaDataGrid.Items.Refresh();
            ZaposleniDataGrid.Items.Refresh();
            markaDataGrid.Items.Refresh();
            musterijaDataGrid.Items.Refresh();
            cenovnikDataGrid.Items.Refresh();
        }

        private void dosaoNaServisButton_Click(object sender, RoutedEventArgs e)
        {
            DosaoNaServis dns = new DosaoNaServis();
            dns.ShowDialog();

            Servismusterija sv = new Servismusterija();
            sv.MId = dns.ClientID + 1;
            sv.SId = 1;

            autoContext.Servismusterija.Add(sv);
            autoContext.SaveChanges();

        }

        private void ObrisiAutoButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveAutomobil ra = new RemoveAutomobil();
            ra.ShowDialog();
            int a = ra.Chasija;
            Radnjaautomobil s = autoContext.Radnjaautomobil.Local.Where(x => x.AutoId == a).First();
            autoContext.Radnjaautomobil.Remove(s);
            autoContext.SaveChanges();

            Automobil aa = autoContext.Automobil.Local.Where(x => x.ChasisNum == a).First();
            autoContext.Automobil.Remove(aa);
            autoContext.SaveChanges();

        }
    }
}
