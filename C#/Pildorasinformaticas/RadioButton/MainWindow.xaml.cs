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

namespace RadioButton
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            ElipseRojo.Visibility = Visibility.Visible;
            ElipseVerde.Visibility = Visibility.Hidden;
            ElipseAmarillo.Visibility = Visibility.Hidden;

        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            ElipseVerde.Visibility = Visibility.Visible;
            ElipseAmarillo.Visibility = Visibility.Hidden;
            ElipseRojo.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            ElipseAmarillo.Visibility = Visibility.Visible;
            ElipseRojo.Visibility = Visibility.Hidden;
            ElipseVerde.Visibility = Visibility.Hidden;
        }
    }
}
