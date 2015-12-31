using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Threading;

namespace WPF_Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Start();
            timer.Tick += Timer_Tick;
            time.Text = DateTime.Now.ToLongTimeString();
        }
        private void pathListBox_Loaded(object sender, RoutedEventArgs e)
        {

            List<int> Items = new List<int>();
            for (int i = 0; i < 60; i++)
            {
                Items.Add(i);
            }
            pathListBox.ItemsSource = Items;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
