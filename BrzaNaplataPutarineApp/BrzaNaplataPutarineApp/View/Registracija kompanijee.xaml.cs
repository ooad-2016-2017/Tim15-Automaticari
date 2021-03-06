﻿using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BrzaNaplataPutarineApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija_kompanijee : Page
    {
        public Registracija_kompanijee()
        {
            this.InitializeComponent();

            this.DataContext = new Registracija_kompanijeVM(new NavigationService());
        }

        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame rootFrame = Window.Current.Content as Frame;
        //    Frame.Navigate(typeof(Naslovna));
        //}

        //private void button1_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame rootFrame = Window.Current.Content as Frame;
        //    Frame.Navigate(typeof(Korisnik));
        //}
    }
}
