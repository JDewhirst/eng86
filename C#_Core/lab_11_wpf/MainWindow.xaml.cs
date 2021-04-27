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
        private static StringBuilder _input = new StringBuilder();
        private static string operation = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonInput_Click(object sender, RoutedEventArgs e)
        {
            
            if ( (string)LabelResult.Content == " " )
            {
                _input.Append((sender as Button).Content);
                LabelInput.Content = _input.ToString();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                _input.Append((sender as Button).Content);
                LabelInput.Content = _input.ToString();
            }
        }

        private void ButtonOperator_Click(object sender, RoutedEventArgs e)
        {
            // if there is no previous result, make the previous result the input, make the operator the +
            //if (LabelPrevResult.Content.ToString() == " ")
            //{
            //    LabelOperator.Content = (sender as Button).Content;
            //    LabelPrevResult.Content = LabelInput.Content;
            //    LabelInput.Content = "0";
            //    _input.Clear();
            //}
            //else
            //{
                LabelOperator.Content = (sender as Button).Content;
                if (LabelPrevResult.Content.ToString() != " ")
                {
                    string results = Calculator.Execute(LabelPrevResult.Content.ToString(), LabelInput.Content.ToString(), (sender as Button).Content.ToString());
                    LabelResult.Content = results;
                }
                else
                {
                    LabelPrevResult.Content = LabelInput.Content;
                    _input.Clear();
                    LabelInput.Content = "0";
                }
            //}

        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            // call the calculator Execute method which takes two number strings, and an operator. It outputs a number string.
            if (LabelResult.Content.ToString() == " ")
            {
                if (LabelPrevResult.Content.ToString() == " ")
                {
                    LabelPrevResult.Content = _input.ToString();
                    _input.Clear();
                    LabelInput.Content = _input.ToString();
                }
                else
                {
                    string results = Calculator.Execute(LabelPrevResult.Content.ToString(), LabelInput.Content.ToString(), LabelOperator.Content.ToString());
                    LabelResult.Content = results;
                    LabelPrevResult.Content = _input.ToString();
                    LabelInput.Content = " ";
                    _input.Clear();
                }
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                LabelInput.Content = " ";
            }
        }

        private void ButtonCancelEverything_Click(object sender, RoutedEventArgs e)
        {
            _input.Clear();
            LabelOperator.Content = " ";
            LabelPrevResult.Content = " ";
            LabelResult.Content = " ";
            LabelInput.Content = _input.ToString();
        }

        private void ButtonCancelInput_Click(object sender, RoutedEventArgs e)
        {
            _input.Clear();
            LabelInput.Content = _input.ToString();
            LabelResult.Content = " ";
        }
    }
}
