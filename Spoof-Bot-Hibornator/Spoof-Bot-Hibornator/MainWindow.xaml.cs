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

namespace Spoof_Bot_Hybernator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Get Access To Optic Spoof Bot : https://discord.gg/fGtMyMHEtB");
        }

        private void SMS_SPAM_OPEN_Click(object sender, RoutedEventArgs e)
        {
            ucshow.Children.Clear();
            UC.SMSSPAM uc = new UC.SMSSPAM();
            ucshow.Children.Add(uc);
        }

        private void EMAIL_SPAM_OPEN_Click(object sender, RoutedEventArgs e)
        {
            ucshow.Children.Clear();
            UC.EMAILSPAM uc = new UC.EMAILSPAM();
            ucshow.Children.Add(uc);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ucshow.Children.Clear();
            UC.HELP uc = new UC.HELP();
            ucshow.Children.Add(uc);
        }
    }
}
