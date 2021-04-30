using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using RadioApp;

namespace RadioGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Radio radio = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateLabel()
        {
            LabelOutput.Content = radio.Play();
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content.ToString() == "Off")
            {
                radio.TurnOn();
                ButtonPower.Content = "On";
                RadioPlayer.Source = radio.ChannelURI;
            }
            else
            {
                radio.TurnOff();
                ButtonPower.Content = "Off";
                RadioPlayer.Source = new Uri(" ");
            }
            UpdateLabel();
        }

        private void ButtonChannel_Click(object sender, RoutedEventArgs e)
        {
            // take the content from the button, try to change the channel. Return the string to the output label.
            radio.Channel = int.Parse((sender as Button).Content.ToString());
            RadioPlayer.Source = radio.ChannelURI;
            UpdateLabel();
        }
    }
}
