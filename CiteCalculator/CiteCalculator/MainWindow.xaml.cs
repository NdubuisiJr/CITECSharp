using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CiteCalculator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        string _operation = "NONE";
        double _firstValue;
        bool _isSecond = false;

        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && screen.Text.Length < 2) {
                return;
            }
            screen.Text += "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "1";
            }
            else if (_isSecond) {
                screen.Text = "1";
                _isSecond = false;
            }
            else {
                screen.Text += "1";
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "2";
            }
            else if (_isSecond) {
                screen.Text = "2";
                _isSecond = false;
            }
            else {
                screen.Text += "2";
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "3";
            }
            else if (_isSecond) {
                screen.Text = "3";
                _isSecond = false;
            }
            else {
                screen.Text += "3";
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "4";
            }
            else if (_isSecond) {
                screen.Text = "4";
                _isSecond = false;
            }
            else {
                screen.Text += "4";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "5";
            }
            else if (_isSecond) {
                screen.Text = "5";
                _isSecond = false;
            }
            else {
                screen.Text += "5";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "6";
            }
            else if (_isSecond) {
                screen.Text = "6";
                _isSecond = false;
            }
            else {
                screen.Text += "6";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "9";
            }
            else if (_isSecond) {
                screen.Text = "9";
                _isSecond = false;
            }
            else {
                screen.Text += "9";
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "8";
            }
            else if (_isSecond) {
                screen.Text = "8";
                _isSecond = false;
            }
            else {
                screen.Text += "8";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "7";
            }
            else if (_isSecond) {
                screen.Text = "7";
                _isSecond = false;
            }
            else {
                screen.Text += "7";
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) {
            screen.Text = "0";
            _operation = "NONE";
            _isSecond = false;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) {
            if (screen.Text.Contains('.')) {
                return;
            }
            screen.Text += ".";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains('.')) {
                return;
            }
            else if (screen.Text.Contains("-")) {

                screen.Text = screen.Text.Substring(1);
            }
            else {
                string existing = screen.Text;
                screen.Text = "-" + existing;
            }
            
        }

        private void Button_Click_13(object sender, RoutedEventArgs e) {
            if (screen.Text.Length == 1) {
                screen.Text = "0";
            }
            else {
                string existing = screen.Text;
                screen.Text = existing.Remove(existing.Length - 1);
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e) {
            _operation = "ADD";
            _firstValue = double.Parse(screen.Text);
            _isSecond = true;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e) {
            double secondValue = double.Parse(screen.Text);
            switch (_operation) {
                case "ADD": {
                        double result = _firstValue + secondValue;
                        screen.Text = result.ToString();
                        _isSecond = true;
                        _operation = "NONE";
                        break;
                    }
                case "SUBSTRACT": {
                        double result = _firstValue - secondValue;
                        screen.Text = result.ToString();
                        _isSecond = true;
                        _operation = "NONE";
                        break;
                    }
                case "MULTIPLY": {
                        double result = _firstValue * secondValue;
                        screen.Text = result.ToString();
                        _isSecond = true;
                        _operation = "NONE";
                        break;
                    }
                case "DIVIDE": {
                        double result = _firstValue / secondValue;
                        screen.Text = result.ToString();
                        _isSecond = true;
                        _operation = "NONE";
                        break;
                    }
                default:
                    break;
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e) {
            _operation = "SUBSTRACT";
            _firstValue = double.Parse(screen.Text);
            _isSecond = true;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e) {
            _operation = "MULTIPLY";
            _firstValue = double.Parse(screen.Text);
            _isSecond = true;
        }

        private void Button_Click_18(object sender, RoutedEventArgs e) {
            _operation = "DIVIDE";
            _firstValue = double.Parse(screen.Text);
            _isSecond = true;
        }

        private void Button_Click_19(object sender, RoutedEventArgs e) {
            double value = double.Parse(screen.Text);
            double result = Math.Pow(value, 2); //value * value;
            screen.Text = result.ToString();
            _isSecond = true;
        }

        private void Button_Click_20(object sender, RoutedEventArgs e) {
            double value = double.Parse(screen.Text);
            double result = Math.Sqrt(value); //Math.Pow(value,0.5)
            screen.Text = result.ToString();
            _isSecond = true;
        }

        private void Button_Click_21(object sender, RoutedEventArgs e) {
            double value = double.Parse(screen.Text);
            double valueToUse = (value * Math.PI) / 180; //Convert to radians
            double result = Math.Sin(valueToUse);
            screen.Text = result.ToString();
            _isSecond = true;
        }

        private void Button_Click_22(object sender, RoutedEventArgs e) {
            double value = double.Parse(screen.Text);
            double valueToUse = (value * Math.PI) / 180; //Convert to radians
            double result = Math.Cos(valueToUse);
            screen.Text = result.ToString();
        }

        private void Button_Click_23(object sender, RoutedEventArgs e) {
            double value = double.Parse(screen.Text);
            double valueToUse = (value * Math.PI) / 180; //Convert to radians
            double result = Math.Tan(valueToUse);
            screen.Text = result.ToString();
            _isSecond = true;
        }
    }
}
