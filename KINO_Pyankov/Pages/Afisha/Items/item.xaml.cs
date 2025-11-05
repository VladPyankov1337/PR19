using KINO_Pyankov.Classes;
using KINO_Pyankov.Modell;
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

namespace KINO_Pyankov.Pages.Afisha.Items
{
    /// <summary>
    /// Логика взаимодействия для item.xaml
    /// </summary>
    public partial class item : UserControl
    {
        List<KinoteatrContext> AllKinoteatrs = KinoteatrContext.Select();
        Main main;
        AfishaContext Item;
        public item(AfishaContext Item, Main main)
        {
            InitializeComponent();
            var kinoteatr = AllKinoteatrs.Find(x => x.Id == Item.IdKinoteatr);
            kinoteatrs.Text = kinoteatr != null ? kinoteatr.Name : "Неизвестный кинотеатр";

            name.Text = Item.Name;
            date.Text = Item.Time.ToString("yyyy-MM-dd");
            time.Text = Item.Time.ToString("HH:mm");
            price.Text = Item.Price.ToString();
            this.Item = Item;
            this.main = main;
        }

        private void EditRecord(object sender, RoutedEventArgs e) =>
            MainWindow.init.OpenPage(new Pages.Afisha.Add(this.Item));

        private void DeleteRecord(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить эту афишу?", "Подтверждение удаления",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Item.Delete();
                main.parent.Children.Remove(this);
            }
        }
    }
}