using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();


        }

        public double dollar =1;

        public double bitcoinPrice = 1700;
        public double ethereumPrice = 450;
        public double iotaPrice = 4.20;

        public double value1 = 0;
        public double result1 = 0;

        public double currency1 = 0;
        public double currency2 = 0;



        ApplicationDataContainer localSettings =
    Windows.Storage.ApplicationData.Current.LocalSettings;
        StorageFolder localFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;

      

        private void updateClick(object sender, RoutedEventArgs e)

        {

            //Button updateBut = (Button)sender;
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://coinmarketcap.com/");
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null )
            {
                string currName = rb.Tag.ToString();
                switch (currName)
                {
                    case "usd":
                        currency1 = dollar;
                        break;
                    case "btc":
                        currency1 = bitcoinPrice;
                        break;
                    case "eth":
                        currency1 = ethereumPrice;
                        break;
                    case "iota":
                        currency1 = iotaPrice;
                        break;
                }

            }
        }
        private void CRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null)
            {
                string currName = rb.Tag.ToString();
                switch (currName)
                {
                    case "usd2":
                        currency2 = dollar;
                        break;
                    case "btc2":
                        currency2 = bitcoinPrice;
                        break;
                    case "eth2":
                        currency2 = ethereumPrice;
                        break;
                    case "iota2":
                        currency2 = iotaPrice;
                        break;
                }

            }
        }

        private void Convert(object sender, RoutedEventArgs e)
        {
            if (value.Text != null)
            {
                value1 = double.Parse(value.Text);
            }
            else
            {
               result.Text = "Error";
            }

            result1 = (value1 * (currency1 / currency2));
            result.Text = result1.ToString("0.00");




            /*  if (usd.IsChecked == true)
              {
                  currency1 = dollar;
              }

              else if (btc.IsChecked == true)
              {
                  currency1 = bitcoinPrice;
              }else if (eth.IsChecked == true)
              {
                  currency1 = ethereumPrice;
              }
              else if (iota.IsChecked == true)
              {
                  currency1 = iotaPrice;
              }

              if (usd2.IsChecked == true)
              {
                  currency2 = dollar;
              }

              else if (btc2.IsChecked == true)
              {
                  currency2 = bitcoinPrice;
              }
              else if ((bool)eth2.IsChecked == true)
              {
                  currency2 = ethereumPrice;
              }
              else if ((bool)iota2.IsChecked == true)
              {
                  currency2 = iotaPrice;
              }
              */


            //result1 = (value1 * currency1 * currency2);




        }


        private void Red_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Background = new SolidColorBrush(Colors.Red);
        }
        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Background = new SolidColorBrush(Colors.Blue);
        }
        private void Green_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Background = new SolidColorBrush(Colors.Green);
        }
        private void Cyan_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Background = new SolidColorBrush(Colors.Cyan);
        }
        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Background = new SolidColorBrush(Colors.Yellow);
        }
        private void LightBlue_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Background = new SolidColorBrush(Colors.AliceBlue);
        }
    }
}
