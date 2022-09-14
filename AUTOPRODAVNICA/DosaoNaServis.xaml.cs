using AUTOPRODAVNICA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for DosaoNaServis.xaml
    /// </summary>
    public partial class DosaoNaServis : Window
    {
        List<Musterija> listaMusterija;
        private int clientID;
        private AUTOPRODAVNICAContext autoContext = new AUTOPRODAVNICAContext();
        private CollectionViewSource musterijaViewSource;
        public DosaoNaServis()
        {
            InitializeComponent();
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri("C://Users//vukmi//OneDrive//Radna površina//baze 2//Projekat//AUTOPRODAVNICA//AUTOPRODAVNICA//Images//autorad.jpg");
            img.EndInit();
            slika.Source = img;
            musterijaViewSource = (CollectionViewSource)FindResource(nameof(musterijaViewSource));
            listaMusterija = autoContext.Musterija.ToList();
            foreach (var item in listaMusterija)
            {
                musterijeComboBox.Items.Add(item.CId);
            }
        }

        public int ClientID { get => clientID; set => clientID = value; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clientID = musterijeComboBox.SelectedIndex;
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            autoContext.Musterija.Load();
            musterijaViewSource.Source = autoContext.Musterija.Local.ToObservableCollection();
        }
    }
}
