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

namespace BMI_Wpf
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void heightclear_Click(object sender, RoutedEventArgs e)
        {
            height.Text = "";
            height.Background = Brushes.Aqua;
        }

        private void weightclear_Click(object sender, RoutedEventArgs e)
        {
            weight.Text = "";
            weight.Background = Brushes.Aqua;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            height.Text = heightbar.Value.ToString();
            weight.Text = weightbar.Value.ToString();

            double Height = double.Parse(height.Text);
            double Weight = double.Parse(weight.Text);
            double BMI;
            BMI = Weight / ((Height / 100) * (Height / 100));

            total.Text = BMI.ToString();
        }

        private void height_TextChanged(object sender, TextChangedEventArgs e)
        {
            height.Background = Brushes.White;
        }

        private void weight_TextChanged(object sender, TextChangedEventArgs e)
        {
            weight.Background = Brushes.White;
        }

        private void count_Click(object sender, RoutedEventArgs e)
        {
            double Height = double.Parse(height.Text);
            double Weight = double.Parse(weight.Text);
            double BMI;
            BMI = Weight / ((Height/100) * (Height / 100));

            total.Text = BMI.ToString();
        }
    }
}
