using AUTOPRODAVNICA.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddAutomobil.xaml
    /// </summary>
    public partial class AddAutomobil : Window
    {
        AUTOPRODAVNICAContext autoContext = new AUTOPRODAVNICAContext();
        private List<Marka> listaMarki;
        private List<Cenovnik> listaCenovnika;
        private string marka;
        private int cenovnik;
        private string model;
        private int godinaProizvodnje;

        public string Marka { get => marka; set => marka = value; }
        public int Cenovnik { get => cenovnik; set => cenovnik = value; }
        public string Model { get => model; set => model = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }

      

     
        public AddAutomobil()
        {
            InitializeComponent();
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri("C://Users//vukmi//OneDrive//Radna površina//baze 2//Projekat//AUTOPRODAVNICA//AUTOPRODAVNICA//Images//autorad.jpg");
            img.EndInit();
            slika.Source = img;
            listaMarki = autoContext.Marka.ToList();
            listaCenovnika = autoContext.Cenovnik.ToList();
            foreach (var item in listaMarki)
            {
                MarkaComboBox.Items.Add(item.BrandName);
            }
            foreach (var item in listaCenovnika)
            {
                CenovnikComboBox.Items.Add(item.CenovnikId);
            }
        }

        private void AddCarButton_Click(object sender, RoutedEventArgs e)
        {
            Model = ModelTextBox.Text;
            GodinaProizvodnje = Convert.ToInt32(GodinaProizvodnjeTextBox.Text);
            Marka = MarkaComboBox.SelectedItem.ToString();
            Cenovnik = int.Parse(CenovnikComboBox.SelectedItem.ToString());
            this.Close();
        }

        private void GodinaProizvodnjeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
