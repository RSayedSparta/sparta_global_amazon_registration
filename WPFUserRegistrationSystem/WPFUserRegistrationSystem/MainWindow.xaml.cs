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
using System.IO;
using Microsoft.Win32;

namespace AmazonRegistration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User kc;
        public MainWindow()
        {
            InitializeComponent();
            kc = new User();
            
        }

        private void ViewProfile_Copy_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select an image from your computer";
            ofd.Filter = "All Support image image|*.jpeg;*.jpg;*.png";
            if (ofd.ShowDialog()==true)
            {
                picture.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {

            kc.Name = username.Text;
            kc.Password = password.Text;
            kc.Repassword = repassword.Text;
            string date = dob.SelectedDate.ToString();
            kc.Age = DateTime.Now.Year - dob.SelectedDate.Value.Year;
            StringBuilder sb = new StringBuilder(picture.Source.ToString());
            kc.PicturePath = sb.Remove(0, 8).ToString();
            kc.PhoneNumber = phoneNum.Text;

            if (kc.Name != "" && kc.Password != "" && kc.PhoneNumber != ""  && kc.PicturePath != "")
            {
                if (kc.Password == kc.Repassword)
                {
                    if (kc.Age != 0)
                    {
                        kc.saveData();
                    }
                    else
                    {
                        MessageBox.Show("How are you 0 years old!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Your confirmation on password is incorrect,please try again");
                }

            }
            else
            {
                MessageBox.Show("Enter all fields please");
            }
            
        }

        private void Sex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void ViewProfile_Click(object sender, RoutedEventArgs e)
        {
            string[] sr = File.ReadAllLines("UserData.txt");
            if (sr[0] != "")
            {
                Window1 win = new Window1();
                win.Show();
            }
            else
            {
                MessageBox.Show("Please Register");
            }
            
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
