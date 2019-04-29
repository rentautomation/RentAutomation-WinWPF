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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Window2.xaml etkileşim mantığı
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            combo1.Items.Add("MÜŞTERİ");
            combo1.Items.Add("PERSONEL");
            combo1.Items.Add("YÖNETİCİ");
        }
        private void Geri_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }
        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combo1.SelectedIndex == 0)
            {
                combo2.Visibility = Visibility.Hidden;
                sirket.Visibility = Visibility.Hidden;
            }
            if (combo1.SelectedIndex == 1)
            {
                combo2.Visibility = Visibility.Visible;
                sirket.Visibility = Visibility.Hidden;
            }
            if (combo1.SelectedIndex == 2)
            {
                combo2.Visibility = Visibility.Hidden;
                sirket.Visibility = Visibility.Visible;
            }
        }
    }
}
