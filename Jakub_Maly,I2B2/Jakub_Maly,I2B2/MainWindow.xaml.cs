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
using static System.Net.Mime.MediaTypeNames;

namespace Jakub_Maly_I2B2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BT_vytvorit_Click(object sender, RoutedEventArgs e)
        {
            string novyZaznam = Text_jmeno.Text + Text_prijmeni.Text + Text_narozeni.Text;
            List_Box.Items.Add(novyZaznam);
            Text_jmeno.Text = " ";
            Text_prijmeni.Text = " ";
            Text_narozeni.Text = " ";

            // Vytvoreni secondWindow = new Vytvoreni();
            //secondWindow.ShowDialog();

        }

        private void BT_detail_Click(object sender, RoutedEventArgs e)
        {
            Detail thirdWindow = new Detail();
            thirdWindow.ShowDialog();

        }

        private void BT_smazat_Click(object sender, RoutedEventArgs e)
        {
            List_Box.Items.RemoveAt(List_Box.SelectedIndex);

            //Smazat fourthWindow = new Smazat();
           // fourthWindow.ShowDialog();

        }

        private void BT_editovat_Click(object sender, RoutedEventArgs e)
        {
            if (List_Box.SelectedIndex != -1)
            {


                int selectedIndex = List_Box.SelectedIndex;
                string selectedRecord = List_Box.SelectedItem.ToString();

                List_Box.Items[selectedIndex] = text.Text;
                text.Text = "";
            }
            else
            {
                MessageBox.Show("Vyber záznam, který chceš idetovat");
            }
           // Editovat fifthWindow = new Editovat();
           // fifthWindow.ShowDialog();

        }
    }
}
