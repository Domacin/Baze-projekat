using AUTOPRODAVNICA.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AUTOPRODAVNICA
{
    /// <summary>
    /// Interaction logic for MakeBill.xaml
    /// </summary>
    public partial class MakeBill : Window
    {
      
        private int musterija;
        private int kolicina;
        private int ukupno;
        DateTime vrijeme;
        private int stavka;
        List<Stavka> listaStavki;
        List<Musterija> listaMusterija;
        

        private AUTOPRODAVNICAContext autoContext = new AUTOPRODAVNICAContext();
        private CollectionViewSource stavkaViewSource;

        public int Musterija { get => musterija; set => musterija = value; }
        public int Stavka { get => stavka; set => stavka = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public int Ukupno { get => ukupno; set => ukupno = value; }
        public DateTime Vrijeme { get => vrijeme; set => vrijeme = value; }

      

        public MakeBill()
        {
            InitializeComponent();
            stavkaViewSource = (CollectionViewSource)FindResource(nameof(stavkaViewSource));

            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri("C://Users//vukmi//OneDrive//Radna površina//baze 2//Projekat//AUTOPRODAVNICA//AUTOPRODAVNICA//Images//autorad2.jpg");
            img.EndInit();
            slika.Source = img;
            listaStavki = autoContext.Stavka.ToList();
            listaMusterija = autoContext.Musterija.ToList();

            //ucitajMusterije();
            //ucitajStavke();

            foreach (var item in listaMusterija)
            {
                musterijaComboBox.Items.Add(item.CId +"."+item.CfName + " " + item.ClName);
            }

            foreach (var item in listaStavki)
            {
                stavkaComboBox_Copy.Items.Add(item.ItemId.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = musterijaComboBox.SelectedItem.ToString();
            string[] ss = s.Split('.');

            string a = stavkaComboBox_Copy.SelectedItem.ToString();
            int stavkaID = Convert.ToInt32(a);
            int musterijaID = Convert.ToInt32(ss[0]);
            Musterija = musterijaID;
            Stavka = stavkaID;
            foreach (var item in listaStavki)
            {
                if(item.ItemId == Stavka)
                {
                    Kolicina = item.Amount;
                    Ukupno = item.ItemPrice * Kolicina;
                }
            }
            Vrijeme = DateTime.Now;
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            autoContext.Stavka.Load();
            stavkaViewSource.Source = autoContext.Stavka.Local.ToObservableCollection();
        }

        
    }
}
