using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
        

        


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // save the value of the check button
            RadioButton current = (RadioButton)sender;

            // save the tag value as the setting
            // access the data container called LocalSettings

            Windows.Storage.ApplicationDataContainer localSettings
                = Windows.Storage.ApplicationData.Current.LocalSettings;

            // within the container, save the name value pair of interest
            //localSettings.Values["nameOfSetting"] = "valueOfSetting";
            localSettings.Values["userChoice"] = current.Tag.ToString();
            // over writes any existing value of userChoice

            // just save the highest score a user got
            // need to check that value already stored.
            int newHighScore = 101;
            try
            {
                int temp = Convert.ToInt32(localSettings.Values["highScore"]);
                if (temp < newHighScore)
                {
                    localSettings.Values["highScore"] = newHighScore.ToString();
                }
            }
            catch
            {
                // doesn't exist, just set the value
                localSettings.Values["highScore"] = newHighScore.ToString();
            }




        }
        

        private void updateClick(object sender, RoutedEventArgs e)
        {
            //Button updateBut = (Button)sender;
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://coinmarketcap.com/");
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
