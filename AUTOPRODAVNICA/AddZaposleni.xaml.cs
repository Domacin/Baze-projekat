using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddZaposleni.xaml
    /// </summary>
    public partial class AddZaposleni : Window
    {
        private string name;
        private string lastname;
        private string radnoMjesto;
        public AddZaposleni()
        {
            InitializeComponent();
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri("C://Users//vukmi//OneDrive//Radna površina//baze 2//Projekat//AUTOPRODAVNICA//AUTOPRODAVNICA//Images//autorad.jpg");
            img.EndInit();
            slika.Source = img;
        }

        public string Name1 { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string RadnoMjesto { get => radnoMjesto; set => radnoMjesto = value; }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Name1 = FirstNameBox.Text;
            Lastname = LastNameBox.Text;
            if (ServisRadioButton.IsChecked == true)
                RadnoMjesto = "Servis";
            else if (RadnjaRadioButton.IsChecked == true)
                RadnoMjesto = "Radnja";
            this.Close();
        }
    }
}
