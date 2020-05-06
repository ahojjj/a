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
using System.Windows.Shapes;

namespace noty
{
    /// <summary>
    /// Interaction logic for Save.xaml
    /// </summary>
    public partial class Save : Window
    {
        private MainWindow main;
        public List<string> namespase = new List<string>();
        public Disk dd = new Disk();
        public int i;

        public Save(MainWindow win)
        {
            main = win;
            InitializeComponent();
        }
        private void seall(object sender, RoutedEventArgs e)
        {
            proect.Focus();
            proect.SelectAll();
        }
        private void Button_sellect(object sender, RoutedEventArgs e)
        {
            namespase.Clear();
            namespase.Add(proect.Text);
            namespase.Add(pass.Password);
            i = dd.DirFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty", 'd').Length;
            if (i <= 0)
            {
                vitvor();
            }
            else
            {
                if (main.SPN.Children.Count <= 0)
                {
                    for (int o = 0; o < i; o++)
                    {
                        if (dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\namespase.name") == namespase[0])
                        {
                            if (dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\Password.pass") == namespase[1])
                            {
                                string[] adpr = dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ');
                                for (int qp = 0; qp < dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ').Length; qp++)
                                {
                                    main.add = dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ')[qp] + " ";
                                }
                                int p;
                                main.fun.visledek.Clear();
                                if (adpr.Length <= 0)
                                {

                                }
                                else
                                {
                                    for (p = 0; p < adpr.Length - 1; p++)
                                    {
                                        main.fun.visledek.Add(adpr[p] + " ");
                                    }
                                }
                                main.fun.file = @"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1);
                            }
                            else
                            {

                            }
                        }
                    }
                }
                else
                {
                    for (int o = 0; o < i; o++)
                    {
                        if (dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\namespase.name") == namespase[0])
                        {
                            if (dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\Password.pass") == namespase[1])
                            {
                                string[] adpr = dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ');
                                for (int i = 0; i < dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ').Length; i++)
                                {
                                    main.add = dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ')[i] + " ";
                                }
                                main.fun.visledek.Clear();
                                for (int p = 0; p < adpr.Length; p++)
                                {
                                    main.fun.visledek.Add(adpr[p] + " ");
                                }
                            }
                            else
                            {

                            }
                            return;
                        }
                    }
                    vitvor();
                }
            }
        } 
        public void Button_sellect()
        {
            namespase.Clear();
            namespase.Add(proect.Text);
            namespase.Add(pass.Password);
            i = dd.DirFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty", 'd').Length;
            if (i <= 0)
            {
                vitvor();
            }
            else
            {
                if (main.SPN.Children.Count <= 0)
                {
                    for (int o = 0; o < i; o++)
                    {
                        if (dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\namespase.name") == namespase[0])
                        {
                            if (dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\Password.pass") == namespase[1])
                            {
                                string[] adpr = dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ');
                                for (int qp = 0; qp < dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ').Length; qp++)
                                {
                                    main.add = dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ')[qp] + " ";
                                }
                                int p;
                                main.fun.visledek.Clear();
                                if (adpr.Length <= 0)
                                {

                                }
                                else
                                {
                                    for (p = 0; p < adpr.Length - 1; p++)
                                    {
                                        main.fun.visledek.Add(adpr[p] + " ");
                                    }
                                }
                                main.fun.file = @"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1);
                            }
                            else
                            {

                            }
                        }
                    }
                }
                else
                {
                    for (int o = 0; o < i; o++)
                    {
                        if (dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\namespase.name") == namespase[0])
                        {
                            if (dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\Password.pass") == namespase[1])
                            {
                                string[] adpr = dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ');
                                for (int i = 0; i < dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ').Length; i++)
                                {
                                    main.add = dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + (i - 1) + @"\noty.znot").Split(' ')[i] + " ";
                                }
                                main.fun.visledek.Clear();
                                for (int p = 0; p < adpr.Length; p++)
                                {
                                    main.fun.visledek.Add(adpr[p] + " ");
                                }
                            }
                            else
                            {

                            }
                            return;
                        }
                    }
                    vitvor();
                }
            }
        }
        public void vitvor() 
        {
            dd.CreatDirectory(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\" + i);
        }
        private void Button_cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
