using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservations.Models
{
    public class RoomID
    {
        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{FloorNumber} {RoomNumber}";
        }

        public int FloorNumber { get; }
        public int RoomNumber { get; }

        public override bool Equals(object? obj)
        {
            return obj is RoomID roomID && 
                FloorNumber == roomID.FloorNumber &&
                RoomNumber == roomID.RoomNumber;
        }

        public override int GetHashCode() 
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        public static bool operator ==(RoomID id1, RoomID id2)
        {
            if (id1 is null && id2 is null)
            {
                return true;
            }
            return !(id1 is null) && id1.Equals(id2);
        }

        public static bool operator !=(RoomID id1, RoomID id2)
        {
            return !(id1 == id2);
        }
    }
}
