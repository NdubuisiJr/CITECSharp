using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CiteCalculator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
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
            else {
                screen.Text += "1";
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "2";
            }
            else {
                screen.Text += "2";
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "3";
            }
            else {
                screen.Text += "3";
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "4";
            }
            else {
                screen.Text += "4";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "5";
            }
            else {
                screen.Text += "5";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "6";
            }
            else {
                screen.Text += "6";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "9";
            }
            else {
                screen.Text += "9";
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "8";
            }
            else {
                screen.Text += "8";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) {
            if (screen.Text[0] == '0' && !screen.Text.Contains(".")) {
                screen.Text = "7";
            }
            else {
                screen.Text += "7";
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) {
            screen.Text = "0";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) {
            if (screen.Text.Contains('.')) {
                return;
            }
            screen.Text += ".";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) {
            if (screen.Text[0]=='0' && !screen.Text.Contains('.')) {
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
            if (screen.Text.Length==1) {
                screen.Text = "0";
            }
            else {
                string existing = screen.Text;
                screen.Text = existing.Remove(existing.Length-1);
            }
        }
    }
}
