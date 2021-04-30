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
            if (ButtonPower.Content.ToString() == "On")
            {
                RadioPlayer.Source = radio.ChannelURI;
                RadioPlayer.Play();
            }
            else
            {
                RadioPlayer.Pause();
            }
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content.ToString() == "Off")
            {
                radio.TurnOn();
                ButtonPower.Content = "On";
            }
            else
            {
                radio.TurnOff();
                ButtonPower.Content = "Off";
            }
            UpdateLabel();
        }

        private void ButtonChannel_Click(object sender, RoutedEventArgs e)
        {
            // take the content from the button, try to change the channel. Return the string to the output label.
            radio.Channel = int.Parse((sender as Button).Content.ToString());
            UpdateLabel();
        }

        //private void ButtonVolume(object sender, RoutedEventArgs e)
        //{
        //    if ((sender as Button).Content.ToString() == "+")
        //    {
        //        RadioPlayer.Volume += 0.05;
        //    }
        //    else
        //    {
        //        RadioPlayer.Volume -= 0.05;
        //    }
        //}

        private void Volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RadioPlayer.Volume = e.NewValue/20;
        }
    }
}
