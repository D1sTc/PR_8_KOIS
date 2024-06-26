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

namespace PR_8._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            Authorization aut = new Authorization();
            aut.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LicenseAgreement_Click(object sender, RoutedEventArgs e)
        {
            LicenseAgreement license = new LicenseAgreement();
            license.Show();
        }
    }
}
