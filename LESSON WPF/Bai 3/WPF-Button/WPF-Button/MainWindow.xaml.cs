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

namespace WPF_Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Button btn = new Button();
            //btn.Click += Button_Click;
            ////btn.Content = "Nguyễn Đức Huy";
            //grdButton.Children.Add(btn);

            //TextBlock txbl = new TextBlock();
            //txbl.Text = "Share to be better";
            //btn.Content = txbl;

            //TextBlock txb = new TextBlock();
            //txb.Width = 100;
            //txb.Height = 50;
            //btn.Content = txb;
        }

        //private void btn_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Click rồi nè");
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click rồi nè");
        }
    }
}
