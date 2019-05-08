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

namespace RentAutomationWPF
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Kayit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window2 wnd = new Window2();
            wnd.ShowDialog();
        }

        private void Giris_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Personel prs = new Personel();
            prs.ShowDialog();
        }
    }
}
