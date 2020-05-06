using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for repicecepice.xaml
    /// </summary>
    public partial class repicecepice : Window
    {
        public funkce fun;
        public repicecepice(funkce funkce)
        {
            fun = funkce;
            InitializeComponent();
            Closing += new CancelEventHandler(CancelHandler);
        }
        public void CancelHandler(object sender, CancelEventArgs args)
        {
            if (fun.boolean == null)
            {

            }
            else fun.GetSetVoid(fun.boolean.HasValue);
        }
        private void ne(object sender, RoutedEventArgs e)
        {
            fun.boolean = true;
            Close();
        }
        private void ok(object sender, RoutedEventArgs e)
        {
            fun.boolean = false;
            Close();
        }
    }
}
