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
using System.Windows.Shapes;

namespace AutoService.Lists
{
    /// <summary>
    /// Логика взаимодействия для ConvergCollapse.xaml
    /// </summary>
    public partial class ConvergCollapse : Window
    {
        public ConvergCollapse()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }

        
    }
}
