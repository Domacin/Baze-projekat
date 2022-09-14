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
    /// Interaction logic for RemoveAutomobil.xaml
    /// </summary>
    public partial class RemoveAutomobil : Window
    {
        private AUTOPRODAVNICAContext autoContext = new AUTOPRODAVNICAContext();
        private CollectionViewSource automobilViewSource;
        List<Automobil> auta;
        private int chasija;

        public int Chasija { get => chasija; set => chasija = value; }

        public RemoveAutomobil()
        {
            InitializeComponent();
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri("C://Users//vukmi//OneDrive//Radna površina//baze 2//Projekat//AUTOPRODAVNICA//AUTOPRODAVNICA//Images//autorad.jpg");
            img.EndInit();
            slika.Source = img;
            automobilViewSource = (CollectionViewSource)FindResource(nameof(automobilViewSource));
            auta = autoContext.Automobil.ToList();

            foreach (var item in auta)
            {
                autoComboBox.Items.Add(item.ChasisNum);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            autoContext.Automobil.Load();
            automobilViewSource.Source = autoContext.Automobil.Local.ToObservableCollection();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            Chasija = Convert.ToInt32(autoComboBox.SelectedItem);
            this.Close();
        }
    }
}
