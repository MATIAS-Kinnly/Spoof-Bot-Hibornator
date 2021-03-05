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

namespace Spoof_Bot_Hybernator.UC
{
    /// <summary>
    /// Interaction logic for EMAILSPAM.xaml
    /// </summary>
    public partial class EMAILSPAM : UserControl
    {
        public EMAILSPAM()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(output.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string intitial_message = (message.Text);
            if (amount.Text == "CUSTOM") 
            {
                output.Text = (".smsspam " + email.Text + " " + intitial_message.Replace(" ", "-") + " " + domain.Text + " " + custom_amount.Text + " " + "email");
            }
            else
            {
                output.Text = (".smsspam " + email.Text + " " + intitial_message.Replace(" ", "-") + " " + domain.Text + " " + amount.Text + " " + "email");
            }
        }
    }
}
