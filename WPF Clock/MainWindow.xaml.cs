using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WPF_Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Timers.Timer timer2;
        private DateTime CurentTime
        {
            get { return DateTime.Now; }
        }
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var secondAnim = new NumberTweener((int)path2.Height, (int)path2.Width);
            var minuteAnim = new NumberTweener((int)path3.Height, (int)path3.Width);
            path2.DataContext = secondAnim;
            Dispatcher.BeginInvoke(new Action(() => minuteAnim.GetFrame(CurentTime.Second / 10)));
            path3.DataContext = minuteAnim;
            timer2 = new System.Timers.Timer(1);
            timer2.AutoReset = true;
            timer2.Elapsed += (s, args) =>
            {
                if (CurentTime.Second % 10 == 0)
                {
                    Dispatcher.BeginInvoke(new Action(() => minuteAnim.GetFrame(CurentTime.Second / 10)), DispatcherPriority.Send);
                }
                int _nextSec = CurentTime.Second % 10;
                Dispatcher.BeginInvoke(new Action(() => secondAnim.GetFrame(_nextSec)), DispatcherPriority.Send);
            };
            timer2.Start();


            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1, 0);
            timer.Start();
            timer.Tick += Timer_Tick;
            Timer_Tick(null,null);
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
            time.Text = string.Concat(CurentTime.Hour.ToString()," : ",CurentTime.Minute.ToString(), " : ");
        }
    }
}
