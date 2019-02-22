using System;
using System.Collections.Generic;
using System.IO;
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

namespace AmazonRegistration
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        User mc;
        public Window1()
        {
            InitializeComponent();
            displayUser();
        }

        public void displayUser()
        {
             mc = new User();

            string[] sr = File.ReadAllLines("UserData.txt");
            string[] strUser = sr[0].Split(',');
            win2User.Content = strUser[0];
            string[] strAge = sr[0].Split(',');
            win2age.Content = strAge[3];
            string[] strPic = sr[0].Split(',');
            win2Pic.Source = new BitmapImage(new Uri(strPic[5]));
            string[] strPhone = sr[0].Split(',');
            win2Phone.Content = strPhone[4];

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    
}
