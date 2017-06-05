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
//using Microsoft.WindowsAzure.MobileServices;
//using Windows.UI.Popups;
//using BrzaNaplataPutarineApp.Azure;
using BrzaNaplataPutarineApp.View;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BrzaNaplataPutarineApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija_korisnikaa : Page
    {
        public Registracija_korisnikaa()
        {
            this.InitializeComponent();
        }
        /*IMobileServiceTable<Korisnici> userTableObj = App.MobileService.GetTable<Korisnici>();

        private void btnSpasi_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                Korisnici obj = new Korisnici();
                obj.ime_i_prezime = textBox.Text;
                obj.id_uredjaja = textBox1.Text;
                obj.vozilo = textBox2.Text;
                obj.registarske_oznake = textBox3.Text;
                obj.stanje_racuna = Convert.ToDouble(textBox4.Text);
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste registrovali korisnika.");
                Frame rootFrame = Window.Current.Content as Frame;
                Frame.Navigate(typeof(Korisnikk));
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }*/
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            Frame.Navigate(typeof(Naslovna));
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            Frame.Navigate(typeof(Korisnik));
        }
    }
}
