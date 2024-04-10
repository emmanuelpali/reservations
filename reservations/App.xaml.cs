using reservations.Exceptions;
using reservations.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace reservations
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Germaine Suites");
            try
            {
               hotel.MakeReservation(new Reservation(
               new RoomID(1, 2),
               "nephenry",
               new DateTime(2024, 1, 4),
               new DateTime(2024, 4, 5)));

                hotel.MakeReservation(new Reservation(
                     new RoomID(1, 2),
                     "someperson",
                     new DateTime(2024, 1, 4),
                     new DateTime(2024, 4, 5)));
            }
            catch (ReservationConflictException)
            {
             
            }

            IEnumerable<Reservation> reservations = hotel.GetReservayionsForUser("nephenry");

            base.OnStartup(e);
        }
    } 
}
