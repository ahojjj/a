
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;
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

namespace noty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public funkce fun;
        public Save saves;
        public bool koro = true;
        public Disk dd = new Disk();
        public Window more = new Moreitm();
        public Window save;
        public Label ahoj;

        public MainWindow()
        {
            saves = new Save(this);
            fun = new funkce(1000, this);
            save = new Save(this);
            InitializeComponent();
            l12.Content = "1";
            lno.Content = "C";
            Closing += new CancelEventHandler(CancelHandler);
        }
        public void CancelHandler(object sender, CancelEventArgs args)
        {
            Environment.Exit(0);
        }

        #region butony
        private void Button1(object sender, RoutedEventArgs e)//ok
        {
            fun.button("1n", lno.Content.ToString(), int.Parse(l12.Content.ToString()));
        }
        private void Button1b(object sender, RoutedEventArgs e)//ok
        {
            fun.button("1m", lno.Content.ToString(), int.Parse(l12.Content.ToString()));
        }
        private void Button2(object sender, RoutedEventArgs e)//ok
        {
            fun.button("2n", lno.Content.ToString(), int.Parse(l12.Content.ToString()));
        }
        private void Button2b(object sender, RoutedEventArgs e)//ok
        {
            fun.button("2m", lno.Content.ToString(), int.Parse(l12.Content.ToString()));
        }
        private void Button4(object sender, RoutedEventArgs e)//ok
        {
            fun.button("4n", lno.Content.ToString(), int.Parse(l12.Content.ToString()));
        }
        private void Button4b(object sender, RoutedEventArgs e)//ok
        {
        //    SystemSounds.Hand.Play();
        //    return;
            fun.button("4m", lno.Content.ToString(), int.Parse(l12.Content.ToString()));
        }
        #endregion
        public string add
        {
            set
            {
                ahoj = new Label();
                ahoj.Name = "l" + SPN.Children.Count.ToString();
                ahoj.FontSize = 25;
                ahoj.Content = value;
                SPN.Children.Add(ahoj);
            }
        }
        public void remove(int kolikaty)
        {
            if (SPN.Children.Count + 1 <= kolikaty)
            {
                return;
            }
            if (SPN.Children.Count != 0)
            {
                SPN.Children.Remove(SPN.Children[kolikaty-1]);
            }
        }
        public void remove(bool posledni = true)//ok
        {
            if (posledni)
            {
                remove(SPN.Children.Count);
            }
            else
            {
                SPN.Children.Clear();
            }
        }
        private void BC(object sender, RoutedEventArgs e)//ok
        {
            if (fun.visledek.Count != 0)
            {
                if (fun.visledek.Count == 1)
                {
                    fun.visledek.Clear();
                }
                else
                {
                    fun.remove();
                    remove();
                }
            }
        }
        private void Button_start(object sender, RoutedEventArgs e)//ok
        {
            fun.zahraj();
        }
        private void Button_exit(object sender, RoutedEventArgs e)//ok
        {
            Environment.Exit(0);
        }
        public void Button_reset(object sender, RoutedEventArgs e)//ok
        {
            remove(false);
            if (fun.visledek.Count >= 1)
            {
                for (int i = 0; i < fun.visledek.Count; i++)
                {
                    add = fun.visledek[i];
                }
            }
        }
        public void Button_reset()//ok
        {
            remove(false);
            if (fun.visledek.Count >= 1)
            {
                for (int i = 0; i < fun.visledek.Count; i++)
                {
                    add = fun.visledek[i];
                }
            }
        }
        private void Button_save(object sender, RoutedEventArgs e)//ok
        {
            fun.save();
        }
        private void CheckBox_truek(object sender, RoutedEventArgs e)//ok
        {
            if (k.IsChecked == true)
            {
                b.IsChecked = false;
            }
            if (k.IsChecked == true)
            {
                fun.puton(true, lno.Content.ToString(), int.Parse(l12.Content.ToString()));
            }
            else
            {
                fun.puton(false, lno.Content.ToString(), int.Parse(l12.Content.ToString()));
            }
        }
        private void CheckBox_trueb(object sender, RoutedEventArgs e)//ok
        {
            if (b.IsChecked == true)
            {
                k.IsChecked = false;
            }
            if (b.IsChecked==true)
            {
                fun.puton(true, lno.Content.ToString(), int.Parse(l12.Content.ToString()));
            }
            else
            {
                fun.puton(false, lno.Content.ToString(), int.Parse(l12.Content.ToString()));
            }
        }
        private void johoho(object sender, KeyEventArgs e)//ok
        {
            switch (e.Key)
            {
                case Key.C:
                case Key.D:
                case Key.E:
                case Key.F:
                case Key.G:
                case Key.A:
                case Key.H:
                    lno.Content = e.Key.ToString();
                    break;
                case Key.D1:
                    l12.Content = "1";
                    break;
                case Key.D2:
                    l12.Content = "2";
                    break;
                default:
                    break;
            }
        }

        private void Button_more(object sender, RoutedEventArgs e)
        {
            more.Show();
        }
    }
}
