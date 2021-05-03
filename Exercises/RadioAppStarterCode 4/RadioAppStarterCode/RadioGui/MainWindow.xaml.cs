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
        private Radio _radio = new();

        public MainWindow()
        {
            _radio.LoadPreviousChannel();
            InitializeComponent();
        }

        private void UpdateLabel()
        {
            LabelOutput.Content = _radio.Play();
            if (ButtonPower.Content.ToString() == "On")
            {
                RadioPlayer.Source = _radio.ChannelURI;
                RadioPlayer.Play();
                _radio.SaveChannel();
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
                _radio.TurnOn();
                ButtonPower.Content = "On";
            }
            else
            {
                _radio.TurnOff();
                ButtonPower.Content = "Off";
            }
            UpdateLabel();
        }

        private void ButtonChannel_Click(object sender, RoutedEventArgs e)
        {
            _radio.Channel = int.Parse((sender as Button).Content.ToString());
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
            _radio.Volume = e.NewValue / 20;
            RadioPlayer.Volume = e.NewValue / 20;
        }

        private void ButtonChannelArrows_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content.ToString() == ">")
            {
                _radio.Channel++;
            } 
            else
            {
                _radio.Channel--;
            }
            UpdateLabel();
        }
    }
}
