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

namespace WpfAppErsterTest
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        public void InitializeComboBox()
        {
            List<string> names = new List<string> { "Hans", "Peter", "Sepp", "Dieter" };
            comboBox.ItemsSource = names;
        }

        public void ShowSelectedComboBoxItemInLabel(object sender, RoutedEventArgs e)
        {
            label.Content = comboBox.SelectedItem;
                      //Amine ist da
                      // hhh
        }
    }
}
