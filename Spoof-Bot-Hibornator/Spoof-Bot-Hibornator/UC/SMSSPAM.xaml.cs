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
    /// Interaction logic for SMSSPAM.xaml
    /// </summary>
    public partial class SMSSPAM : UserControl
    {
        public SMSSPAM()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Output.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (number_input.Text == "")
            {
                MessageBox.Show("enter a number!");
            }
            else if (Message.Text == "")
            {
                MessageBox.Show("enter a message!");
            }
            else if (Amount.Text == "CUSTOM") 
            {
                string intitial_message = Message.Text;
                if ((bool)Verizon.IsChecked)
                {
                    Carrier_hold.Text = "@vzwpix.com";
                }
                else if ((bool)TMobile.IsChecked)
                {
                    Carrier_hold.Text = "@tmomail.net";
                }
                else if ((bool)ATT.IsChecked)
                {
                    Carrier_hold.Text = "@mms.att.net";
                }
                Output.Text = (".smsspam " + number_input.Text + Carrier_hold.Text + " " + intitial_message.Replace(" ", "-") + " " + Domain.Text + " " + CUSTOM_AMOUNT.Text + " " + "sms");
            }
            else
            {
                string intitial_message = Message.Text;
                if ((bool)Verizon.IsChecked)
                {
                    Carrier_hold.Text = "@vzwpix.com";
                }
                else if ((bool)TMobile.IsChecked)
                {
                    Carrier_hold.Text = "@tmomail.net";
                }
                else if ((bool)ATT.IsChecked)
                {
                    Carrier_hold.Text = "@mms.att.net";
                }
                Output.Text = (".smsspam " + number_input.Text + Carrier_hold.Text + " " + intitial_message.Replace(" ", "-") + " " + Domain.Text + " " + Amount.Text + " " + "sms");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://freecarrierlookup.com");
        }
    }
}
