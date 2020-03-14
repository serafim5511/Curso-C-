using System;
using System.Collections.Generic;
using System.Text;
using TrabalhandoExceçao.Entitites.Exceptions;

namespace TrabalhandoExceçao.Entitites
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }

        public DateTime Checkout { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Reservation date must be afther checkin");
            }
            RoomNumber = roomumber;
            Checkin = checkin;
            Checkout = checkout;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            Checkin = checkin;
            Checkout = checkout;
        }
        public int duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }
        public void  updateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation date for update");
            }
            else if (checkout <= checkin)
            {
                throw new DomainException("Reservation date must be afther checkin");
            }
            Checkin = checkin;
            Checkout = checkout;
            
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in "
                + Checkin.ToString("dd/MM/yyyy")
                + "check-out"
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + duration()
                + " nights";
        }


    }
}
