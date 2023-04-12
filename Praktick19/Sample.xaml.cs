using Praktick19;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для Sample.xaml
    /// </summary>
    public partial class Sample : Window
    {
        aeroflotEntities db = aeroflotEntities.GetContext();

        public Sample()
        {
            InitializeComponent();
        }


        

        private void Bt1_Click(object sender, RoutedEventArgs e)
        { 
            if (Tb1.Text.Length > 0)
            {
                var desti = from p in db.Aeroflots
                            where p.destination.StartsWith(Tb1.Text)
                            select p;
                data1.AeroDG.ItemsSource = desti.ToList();
                this.Close();
            }
        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            if (Tb2.Text.Length > 0)
            {
                int.TryParse(Tb2.Text, out int places);
                var allplaces = from p in db.Aeroflots
                                where p.total_seats == places
                                select p;
                data1.AeroDG.ItemsSource = allplaces.ToList();
                this.Close();
            }
        }

        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            
                if (Tb3.Text.Length > 0)
                {
                    int.TryParse(Tb3.Text, out int freep);
                    var freeplaces = from p in db.Aeroflots
                                     where p.number_of_free__places == freep
                                     select p;
                    data1.AeroDG.ItemsSource = freeplaces.ToList();
                this.Close();
            }
            
        }

        private void Bt4_Click(object sender, RoutedEventArgs e)
        {
            if (Tb4.Text.Length > 0)
            {
                int.TryParse(Tb4.Text, out int racen);
                var racenum = from p in db.Aeroflots
                              where p.flight_number >= racen
                              select p;
                data1.AeroDG.ItemsSource = racenum.ToList();
                this.Close();
            }
        }

        private void Bt5_Click(object sender, RoutedEventArgs e)
        {
            if (Tb5.Text.Length>0)
            {
                var type = from p in db.Aeroflots
                           where p.aircraft_type.StartsWith(Tb5.Text)
                           select p;
                data1.AeroDG.ItemsSource = type.ToList();
                this.Close();
            }
        }
    }
}
