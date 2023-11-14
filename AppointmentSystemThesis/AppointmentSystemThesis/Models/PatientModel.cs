namespace AppointmentSystemThesis.Models
{
   public class PatientModel
    {
        public int Id { get; set; } // Assuming you want an ID for each patient
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserType { get; set; } // Student, non-teaching staff, faculty member
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmergencyContact { get; set; } // Name of who to notify in case of an emergency
        public string BloodGroup { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string MedicalHistory { get; set; }
        public string Medications { get; set; }
    }
}
