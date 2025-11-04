using KINO_Pyankov.Classes;
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
using System.Xml.Linq;

namespace KINO_Pyankov.Pages.Kinoteatr.Items
{
    /// <summary>
    /// Логика взаимодействия для item.xaml
    /// </summary>
    public partial class item : UserControl
    {
        KinoteatrContext Kinoteatr;
        Main main;
        public item(KinoteatrContext Kinoteatr, Main main)
        {
            InitializeComponent();
            name.Text = Kinoteatr.Name;
            countZal.Text = Kinoteatr.CountZal.ToString();
            count.Text = Kinoteatr.Count.ToString();
            this.Kinoteatr = Kinoteatr;
            this.main = main;
        }

        private void EditRecord(object sender, System.Windows.RoutedEventArgs e) =>
            MainWindow.init.OpenPage(new Pages.Kinoteatr.Add(this.Kinoteatr));


        private void DeleteRecord(object sender, System.Windows.RoutedEventArgs e)
        {
            Kinoteatr.Delete();
            main.parent.Children.Remove(this);
        }
    }
}
