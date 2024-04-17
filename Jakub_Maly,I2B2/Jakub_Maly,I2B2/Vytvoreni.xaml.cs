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

namespace Jakub_Maly_I2B2
{
    /// <summary>
    /// Interakční logika pro Vytvoreni.xaml
    /// </summary>
    public partial class Vytvoreni : Window
    {
        public Vytvoreni() => InitializeComponent();

        private void BT_Ulozit_Click(object sender, RoutedEventArgs e)
        {
            string novyZaznam = Text_jmeno.Text + Text_prijmeni.Text + Text_narozeni.Text;
           // List_Box.Items.Add(novyZaznam);
            Text_jmeno.Text = " ";
            Text_prijmeni.Text = " ";
            Text_narozeni.Text = " ";

        }

    }
}
