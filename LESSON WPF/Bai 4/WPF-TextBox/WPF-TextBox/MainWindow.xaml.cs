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

namespace WPF_TextBox
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

        private void BtnValue_Click(object sender, RoutedEventArgs e)
        {
            txblValue.Text = txbValue.Text;
        }

        int DoubleValue(int value)
        {
            return value * 2;
        }

        private void TxbValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value = 0;
            if(int.TryParse(txbValue.Text,out value))
            {
                txblValue.Text = DoubleValue(value).ToString();
            }
            else
            {
                txblValue.Text = "Vui long nhap gia tri chinh xac!";
            }
        }
    }
}
