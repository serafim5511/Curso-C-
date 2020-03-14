using System;
using TrabalhandoExceçao.Entitites;
using TrabalhandoExceçao.Entitites.Exceptions;

namespace TrabalhandoExceçao
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime Checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime Checkout = DateTime.Parse(Console.ReadLine());

                Reservation enviar = new Reservation(number , Checkin , Checkout);
                Console.WriteLine("Reservation: " + enviar);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                 Checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");

                 enviar = new Reservation(number, Checkin, Checkout);
                Console.WriteLine("Reservation: " + enviar);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
