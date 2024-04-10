using reservations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservations.Exceptions
{
    public class ReservationConflictException : Exception
    {
        public Reservation ExistingReservation { get; }
        public Reservation Newreservation { get; }
        public ReservationConflictException(Reservation existingReservation, Reservation newreservation)
        {
            ExistingReservation = existingReservation;
            Newreservation = newreservation;
        }
        public ReservationConflictException(string message, Reservation existingReservation, Reservation newreservation) : base(message)
        {
            ExistingReservation = existingReservation;
            Newreservation = newreservation;
        }

        public ReservationConflictException(string message, Exception innerException, Reservation existingReservation, Reservation newreservation) : base(message, innerException)
        {
            ExistingReservation = existingReservation;
            Newreservation = newreservation;
        }
    }
}
