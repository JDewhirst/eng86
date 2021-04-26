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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if ( (string)LabelResult.Content == " " )
            {
                _input.Append('1');
                LabelInput.Content = _input.ToString();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                _input.Append('1');
                LabelInput.Content = _input.ToString();
            }
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if ((string)LabelResult.Content == " ")
            {
                _input.Append('2');
                LabelInput.Content = _input.ToString();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                _input.Append('2');
                LabelInput.Content = _input.ToString();
            }
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if ((string)LabelResult.Content == " ")
            {
                _input.Append('3');
                LabelInput.Content = _input.ToString();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                _input.Append('3');
                LabelInput.Content = _input.ToString();
            }
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if ((string)LabelResult.Content == " ")
            {
                _input.Append('4');
                LabelInput.Content = _input.ToString();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                _input.Append('4');
                LabelInput.Content = _input.ToString();
            }
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if ((string)LabelResult.Content == " ")
            {
                _input.Append('5');
                LabelInput.Content = _input.ToString();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                _input.Append('5');
                LabelInput.Content = _input.ToString();
            }
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if ((string)LabelResult.Content == " ")
            {
                _input.Append('6');
                LabelInput.Content = _input.ToString();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                _input.Append('6');
                LabelInput.Content = _input.ToString();
            }
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if ((string)LabelResult.Content == " ")
            {
                _input.Append('7');
                LabelInput.Content = _input.ToString();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                _input.Append('7');
                LabelInput.Content = _input.ToString();
            }
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if ((string)LabelResult.Content == " ")
            {
                _input.Append('8');
                LabelInput.Content = _input.ToString();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                _input.Append('8');
                LabelInput.Content = _input.ToString();
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if ((string)LabelResult.Content == " ")
            {
                _input.Append('9');
                LabelInput.Content = _input.ToString();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                _input.Append('9');
                LabelInput.Content = _input.ToString();
            }
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if ((string)LabelResult.Content == " ")
            {
                _input.Append('0');
                LabelInput.Content = _input.ToString();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                _input.Append('0');
                LabelInput.Content = _input.ToString();
            }
        }

        private void ButtonDot_click(object sender, RoutedEventArgs e)
        {
            _input.Append('.');
            LabelInput.Content = _input.ToString();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            // if there is no previous result, make the previous result the input, make the operator the +
            if (LabelPrevResult.Content.ToString() == " ")
            {
                LabelOperator.Content = "+";
                LabelPrevResult.Content = LabelInput.Content;
                LabelInput.Content = "0";
                _input.Clear();
            }
            else
            {
                LabelOperator.Content = "+";
                string results = Calculator.Execute(LabelPrevResult.Content.ToString(), LabelInput.Content.ToString(), "+");
                LabelResult.Content = results;
            }

        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            // call the calculator Execute method which takes two number strings, and an operator. It outputs a number string.
            if (LabelResult.Content.ToString() == " ")
            {
                string results = Calculator.Execute(LabelPrevResult.Content.ToString(), LabelInput.Content.ToString(), LabelOperator.Content.ToString());
                LabelResult.Content = results;
                LabelPrevResult.Content = _input.ToString();
                LabelInput.Content = " ";
                _input.Clear();
            }
            else
            {
                LabelPrevResult.Content = LabelResult.Content;
                LabelResult.Content = " ";
                _input.Clear();
                LabelInput.Content = " ";
            }
        }

        private void ButtonModulus_Click(object sender, RoutedEventArgs e)
        {
            if (LabelPrevResult.Content.ToString() == " ")
            {
                LabelOperator.Content = "%";
                LabelPrevResult.Content = LabelInput.Content;
                LabelInput.Content = "0";
                _input.Clear();
            }
            else
            {
                LabelOperator.Content = "%";
                string results = Calculator.Execute(LabelPrevResult.Content.ToString(), LabelInput.Content.ToString(), "%");
                LabelResult.Content = results;
            }

        }

        private void ButtonSubtract_Click(object sender, RoutedEventArgs e)
        {
            if (LabelPrevResult.Content.ToString() == " ")
            {
                LabelOperator.Content = "-";
                LabelPrevResult.Content = LabelInput.Content;
                LabelInput.Content = "0";
                _input.Clear();
            }
            else
            {
                LabelOperator.Content = "-";
                string results = Calculator.Execute(LabelPrevResult.Content.ToString(), LabelInput.Content.ToString(), "-");
                LabelResult.Content = results;
            }

        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (LabelPrevResult.Content.ToString() == " ")
            {
                LabelOperator.Content = "/";
                LabelPrevResult.Content = LabelInput.Content;
                LabelInput.Content = "0";
                _input.Clear();
            }
            else
            {
                LabelOperator.Content = "/";
                string results = Calculator.Execute(LabelPrevResult.Content.ToString(), LabelInput.Content.ToString(), "/");
                LabelResult.Content = results;
            }

        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (LabelPrevResult.Content.ToString() == " ")
            {
                LabelOperator.Content = "x";
                LabelPrevResult.Content = LabelInput.Content;
                LabelInput.Content = "0";
                _input.Clear();
            }
            else
            {
                LabelOperator.Content = "x";
                string results = Calculator.Execute(LabelPrevResult.Content.ToString(), LabelInput.Content.ToString(), "x");
                LabelResult.Content = results;
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
