using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Praktick19
{
    /// <summary>
    /// Логика взаимодействия для ChangeRequest.xaml
    /// </summary>
    public partial class ChangeRequest : Window
    {
        aeroflotEntities db = aeroflotEntities.GetContext();
        public ChangeRequest()
        {
            InitializeComponent();
        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        { if (aircrafttype1.Text.Length > 0 && aircrafttype2.Text.Length > 0)
            {
                db.Database.ExecuteSqlCommand($"UPDATE Aeroflot SET [aircraft type]='{aircrafttype2.Text}' WHERE [aircraft type]='{aircrafttype1.Text}'");
                MessageBox.Show("Запрос выполнен");
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля для выполнения замены");
            }
        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            if (Tb1.Text.Length >0 && Tb2.Text.Length>0)
            {
                db.Database.ExecuteSqlCommand($"UPDATE Aeroflot SET destination='{Tb2.Text}' WHERE destination='{Tb1.Text}'");
                MessageBox.Show("Запрос выполнен");
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля для выполнения замены");
            }
        }
    }
}
