using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona NewPerson = new Persona(("Steven Jhonson", "986782342", "5555-555-555"));
            NewAppointment Appo1 = new NewAppointment((NewPerson, DateTime.5/, "Wall Street", "Armand"));
            Console.WriteLine(appointmentResult);
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
        }
    }
}
