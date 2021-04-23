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
using CalculatorLib;

namespace lab_11_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static StringBuilder _input = new StringBuilder("");
        private static StringBuilder _operator = new StringBuilder("");
        private static StringBuilder _result = new StringBuilder("");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            _input.Append("1");
            LabelInput.Content = _input.ToString();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            _input.Append("2");
            LabelInput.Content = _input.ToString();
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            _input.Append("3");
            LabelInput.Content = _input.ToString();
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            _input.Append("4");
            LabelInput.Content = _input.ToString();
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            _input.Append("5");
            LabelInput.Content = _input.ToString();
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            _input.Append("6");
            LabelInput.Content = _input.ToString();
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            _input.Append("7");
            LabelInput.Content = _input.ToString();
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            _input.Append("8");
            LabelInput.Content = _input.ToString();
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            _input.Append("9");
            LabelInput.Content = _input.ToString();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            _input.Append("0");
            LabelInput.Content = _input.ToString();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            _operator.Clear();
            _operator.Append("+");
            // _result = Calculator.Add(_input
            LabelResult.Content = $"{_input.ToString()} {_operator.ToString()}"; // what I actually want here is for the input to be evaluated and output.
            _input.Clear();
            _input.Append("0");
            LabelInput.Content = _input;
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
