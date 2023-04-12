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

namespace Praktick19
{
    /// <summary>
    /// Логика взаимодействия для DellRequest.xaml
    /// </summary>
    public partial class DellRequest : Window
    {
        aeroflotEntities db = aeroflotEntities.GetContext();
        public DellRequest()
        {
            InitializeComponent();
        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
                MessageBoxResult result;
                result = MessageBox.Show("Вы действительно хотите удалить запись ?", "Удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                    if (aircrafttype1.Text.Length > 0)
                    {
                        db.Database.ExecuteSqlCommand($"DELETE FROM Aeroflot WHERE [aircraft type]='{aircrafttype1.Text}'");
                        MessageBox.Show("Записи успешно удалены");
                        this.Close();
                    }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Выберете запись");
                    }
                }
            
        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Вы действительно хотите удалить запись ?", "Удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    if (Tb1.Text.Length>0)
                    {
                        db.Database.ExecuteSqlCommand($"DELETE FROM Aeroflot WHERE destination='{Tb1.Text}'");
                        MessageBox.Show("Записи успешно удалены");
                        this.Close();
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберете запись");
                }
            }
        }
    }
}
