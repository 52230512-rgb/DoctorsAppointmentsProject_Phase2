namespace DoctorsAppointmentsProject_Phase2.Models
{
    public class Appointments
    {
            public int Id { get; set; }

            public string PatientName { get; set; }

            public string DoctorName { get; set; }

            public DateTime AppointmentDate { get; set; }

            public string AppointmentTime { get; set; }

            public string Notes { get; set; }
        }
    }

