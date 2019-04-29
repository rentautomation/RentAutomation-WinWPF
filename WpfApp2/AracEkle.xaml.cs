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
    /// AracEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class AracEkle : Window
    {
        public AracEkle()
        {
            InitializeComponent();
            combo4.Items.Add("VAR");
            combo4.Items.Add("YOK");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ARAÇ EKLENDİ");
            this.Hide();
        }
    }
}
