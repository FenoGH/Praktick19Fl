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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Praktick19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        aeroflotEntities db = aeroflotEntities.GetContext();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.Aeroflots.Load();
            AeroDG.ItemsSource = db.Aeroflots.Local.ToBindingList();
            data1.AeroDG.ItemsSource = AeroDG.ItemsSource;


        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            AddList f = new AddList();
            f.ShowDialog();
            AeroDG.Focus();
        }

        private void ChangeListBT_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = AeroDG.SelectedIndex;
            if (indexRow != -1)
            {
                Aeroflot row = (Aeroflot)AeroDG.Items[indexRow];
                Transmission.Id = row.ID;

                ChangeList f = new ChangeList();
                f.ShowDialog();
                AeroDG.Items.Refresh();
                AeroDG.Focus();
            }
        }

        private void DelFromDb_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Вы действительно хотите удалить запись ?", "Удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Aeroflot row = (Aeroflot)AeroDG.SelectedItems[0];
                    db.Aeroflots.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберете запись");
                }
            }
        }

        private void Linq(object sender, RoutedEventArgs e)
        {
            
            Sample f = new Sample();
            f.ShowDialog();
            AeroDG.ItemsSource = data1.AeroDG.ItemsSource;
            AeroDG.Items.Refresh();
        }
        private void ChangeR(object sender, RoutedEventArgs e)
        {
            ChangeRequest f = new ChangeRequest();
            f.ShowDialog();
            db.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            AeroDG.Items.Refresh();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: стундент группы ИСП-31 Борькин И.В.\nЗадание:\nСведения о рейсах Аэрофлота. База данных должна содержать следующую информацию: номер рейса, пункт назначения, время вылета, время прибытия, количество свободных мест, тип самолета и его вместимость");
        }
        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void DestrFilt(object sender, RoutedEventArgs e)
        {
            db.Aeroflots.Load();
            AeroDG.ItemsSource = db.Aeroflots.Local.ToBindingList();
        }

        private void DelR(object sender, RoutedEventArgs e)
        {
            DellRequest f = new DellRequest();
            f.ShowDialog();
            db.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            AeroDG.Items.Refresh();
        }
    }
}
