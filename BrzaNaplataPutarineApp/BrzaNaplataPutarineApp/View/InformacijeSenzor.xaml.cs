using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using BrzaNaplataPutarineApp.ViewModel;
using BrzaNaplataPutarineApp.Helper;
using Windows.Devices.SerialCommunication;
using BrzaNaplataPutarineApp.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238


namespace BrzaNaplataPutarineApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InformacijeSenzor : Page
    {
        Arduino uredjaj;
        List<string> stringovi;
        List<SerialDevice> uredjaji;
        public const String UDALJENOST = "Udaljenost";
        

        public InformacijeSenzor()
        {
            this.InitializeComponent();
            this.DataContext = new InformacijeSenzorVM(new NavigationService());
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            await Arduino.skenirajPortove();
            stringovi = new List<string>();
            uredjaji = new List<SerialDevice>();
            foreach (SerijskiUredjajIIme i in Arduino.serijskiUredjaji)
            {
                stringovi.Add(i.Ime);
                uredjaji.Add(i.Uredjaj);
            }
            OdaberiteUredaj.ItemsSource = stringovi;
        }

        private async void OdaberiteUredaj_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ime = OdaberiteUredaj.SelectedItem.ToString();
            if (ime != null)
            {
                uredjaj = new Arduino(uredjaji[stringovi.IndexOf(ime)]);
                //uredjaj = new Arduino(uredjaji[0]);

            }
            await uredjaj.dajUdaljenost();
            textBox.Text = uredjaj.udaljenost;
            uredjaj.udaljenost = "Nije ocitano";
        }

    }
}