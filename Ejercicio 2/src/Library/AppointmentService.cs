using System;
using System.Text;

namespace Library
{
    public class Persona
    {
        public string name { get ; }
        public string id { get ; }
        public string phoneNumber { get ;  }

        public Persona(String name, String id, String phoneNumber)
        {
            this.name = name;
            this.id = id;
            this.phoneNumber = phoneNumber;
        }
    }
    public class NewAppointment
    {
        public DateTime date { get ; }
        public string appoinmentPlace { get ;  }
        public string doctorName { get ;  }
        public Persona NewPerson { get ; }
        public NewAppointment(Persona NewPerson, DateTime date, String appoinmentPlace, String doctorName)
        {
            this.NewPerson = NewPerson;
            this.date = date;
            this.appoinmentPlace = appoinmentPlace;
            this.doctorName = doctorName;
        }
    }
    public class AppointmentValidate
    {
        public static string CreateAppointment(NewAppointment Appo1)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(Appo1.NewPerson.name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(Appo1.NewPerson.id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(Appo1.NewPerson.phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(Appo1.appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(Appo1.doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
