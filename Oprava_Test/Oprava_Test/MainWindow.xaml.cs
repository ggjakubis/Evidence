﻿using System;
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

namespace Oprava_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Zamestnanec> Zamestnanci { get; set; }
        public MainWindow()
        {
            Zamestnanci = new();
            InitializeComponent();
            seznam.ItemsSource = Zamestnanci;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogPridat dialog = new(Zamestnanci);
            dialog.Closing += Dialog_Closing;
            dialog.ShowDialog();
        }

        private void Dialog_Closing(object? sender, EventArgs e)
        {
            seznam.ItemsSource = null;
            seznam.ItemsSource = Zamestnanci;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Zamestnanec? info = seznam?.SelectedItem as Zamestnanec ?? new Zamestnanec(-1, "Neznámý", new DateOnly.FromDateTime(DateOnly.FromDateTime().Now));
            MessageBox.Show($"{info.Id} {info.Jmeno} {info.Prijmeni} {info.DatumNarozeni.ToShortDateString()}");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
