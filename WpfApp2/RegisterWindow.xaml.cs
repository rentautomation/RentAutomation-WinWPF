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
using Rent.Model.Concretes;
using WpfApp2.CustomerWebService;

namespace RentAutomationWPF
{
    /// <summary>
    /// Window2.xaml etkileşim mantığı
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
            combo_state.Items.Add("MÜŞTERİ");
            combo_state.Items.Add("PERSONEL");
            combo_state.Items.Add("YÖNETİCİ");
        }
        private void Geri_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }
        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combo_state.SelectedIndex == 0)
            {
                combo_company.Visibility = Visibility.Hidden;
                company_Name.Visibility = Visibility.Hidden;
            }
            if (combo_state.SelectedIndex == 1)
            {
                combo_company.Visibility = Visibility.Visible;
                company_Name.Visibility = Visibility.Hidden;
            }
            if (combo_state.SelectedIndex == 2)
            {
                combo_company.Visibility = Visibility.Hidden;
                company_Name.Visibility = Visibility.Visible;
            }
        }

        private void btn_Register_Click(object sender, RoutedEventArgs e)
        {
            if (combo_state.SelectedIndex == 0)
                CustomerInsert();
        }

        public void CustomerInsert()
        {
            try
            {
                string name = txt_name.Text;
                string lastname = txt_lastname.Text;
                string username = txt_username.Text;
                string password = txt_password.Password;
                DateTime birthDate = datePicker_birthDate.SelectedDate.Value;

                
                int age = DateTime.Now.Year - birthDate.Year;
                WpfApp2.CustomerWebService.Customer customer = new WpfApp2.CustomerWebService.Customer()
                {
                    name = name,
                    lastname = lastname,
                    username = username,
                    password = password,
                    birthdate = birthDate,
                    age = age,
                    isactive = 1
                };

                var client = new CustomerWebServiceSoapClient();
                WpfApp2.CustomerWebService.Customer insert = client.CustomerInsert(customer);
                if (insert != null)
                    MessageBox.Show("Operation Pass");
                else
                    MessageBox.Show("Operation Fail");


            }
            catch (Exception ex)
            {

                throw new Exception("RegisterWindow::btn_Register_Click: Error occured ", ex);
            }
        }
    }
}
