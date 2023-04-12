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
    /// Логика взаимодействия для AddList.xaml
    /// </summary>
    public partial class AddList : Window
    {
        
        aeroflotEntities db = aeroflotEntities.GetContext();
        Aeroflot p1 = new Aeroflot();
        public AddList()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            string time1 = dtime1.Text + ":" + dtime2.Text;
            string time2 = atime1.Text + ":" + atime2.Text;

            StringBuilder errors = new StringBuilder();
            int.TryParse(RacenumTB.Text, out int racenum);
            short.TryParse(FreePlacesTB.Text, out short freeplaces);
            int.TryParse(AllPlaceTB.Text, out int allplace);
            if(racenum < 0 || racenum==0) errors.AppendLine("Корректно задайте номер рейса");
            if (DislocateTB.Text.Length == 0) errors.AppendLine("Корректно задайте место полета");
            if (freeplaces < 0 || FreePlacesTB.Text.Length < 1) errors.AppendLine("Корректно задайте колличество свободных мест");
            if (allplace < 0 || allplace == 0 || AllPlaceTB.Text.Length<1) errors.AppendLine("Конкретно задайте общее колличество мест");
            if (freeplaces > allplace) errors.AppendLine("Число свободных мест не может привышать общее колличество мест");
            if (dtime1.Text.Length < 1 || dtime2.Text.Length < 1) errors.AppendLine("Корректно задайте время отбытия");
            if (atime1.Text.Length <1 || atime2.Text.Length < 1) errors.AppendLine("Корректно задайте время прилета");
            if (aircrafttype.Text.Length<1) errors.AppendLine("Корректно задайте тип самолета");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                p1.flight_number = racenum;
                p1.destination = DislocateTB.Text;
                p1.departure_time = TimeSpan.Parse(time1);
                p1.Arrival_time = TimeSpan.Parse(time2);
                p1.number_of_free__places = freeplaces;
                p1.aircraft_type = aircrafttype.Text;
                p1.total_seats = allplace;

            }
            try
            {
                db.Aeroflots.Add(p1);
                db.SaveChanges();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
