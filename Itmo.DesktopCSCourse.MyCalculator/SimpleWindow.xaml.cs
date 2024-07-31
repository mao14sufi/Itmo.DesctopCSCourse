using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpfcacl
{
    /// <summary>
    /// Interaction logic for SimpleWindow.xaml
    /// </summary>
    public partial class SimpleWindow : Window

    {
        public MainWindow mainwindow { get; set; }

        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";


        public SimpleWindow() 
        {
            InitializeComponent();
        }

        private void KeyOne_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcNumber(oneOut);
        }

        private void KeyTwo_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcNumber(twoOut);
        }

        private void KeyThree_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcNumber(threeOut);
        }

        private void KeyFour_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcNumber(fourOut);
        }

        private void KeyFive_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcNumber(fiveOut);
        }

        private void KeySix_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcNumber(sixOut);
        }

        private void KeySeven_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcNumber(sevenOut);
        }

        private void KeyEight_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcNumber(eightOut);
        }

        private void KeyNine_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcNumber(nineOut);
        }

        private void KeyZero_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcNumber(zeroOut);
        }

        private void KeySign_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcSign();
        }

        private void KeyPoint_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcDecimal();
        }

        private void KeyPlus_Click(object sender, RoutedEventArgs e)
        {
            MyCalc.CalcOperation(MyCalc.Operator.eAdd);
        }

        private void KeyMinus_Click(object sender, RoutedEventArgs e)
        {
            MyCalc.CalcOperation(MyCalc.Operator.eSubtract);
        }

        private void KeyMultiply_Click(object sender, RoutedEventArgs e)
        {
            MyCalc.CalcOperation(MyCalc.Operator.eMultiply);
        }

        private void KeyDivide_Click(object sender, RoutedEventArgs e)
        {
            MyCalc.CalcOperation(MyCalc.Operator.eDivide);
        }

        private void KeyEqual_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = MyCalc.CalcEqual();
        }

        private void KeyClear_Click(object sender, RoutedEventArgs e)
        {
            MyCalc.CalcReset();
            Display.Content = "0";
        }

        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            MyCalc.CalcReset();
            mainwindow = new MainWindow();
            mainwindow.Top = this.Top;
            mainwindow.Left = this.Left;



            mainwindow.Show();
            this.Close();

        }
        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}

