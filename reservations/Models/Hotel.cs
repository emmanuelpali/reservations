using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservations.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;

            _reservationBook = new ReservationBook();
        }

        /// <summary>
        /// Get the reservation of a speific user.
        /// </summary>
        /// <param name="username"> The name of the user</param>
        /// <returns></returns>
        public IEnumerable<Reservation> GetReservations()
        {
            return _reservationBook.GetReservations();
        }
        /// <summary>
        /// Make a reservation
        /// </summary>
        /// <param name="reservation"> The incoming reservation.</param>
        /// <exception cref="ReservationConflictException"
        public void MakeReservation(Reservation reservation) 
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
