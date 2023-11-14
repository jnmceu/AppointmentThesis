using System;
using System.ComponentModel.DataAnnotations;

namespace AppointmentSystemThesis.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date and Time is required.")]
        public DateTime DateAndTime { get; set; }

        [Required(ErrorMessage = "Patient Number is required.")]
        public string PatientNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        // Add other properties as needed

        // Navigation properties if you have relationships
        // public int HealthProfileId { get; set; }
        // public HealthProfile HealthProfile { get; set; }
    }
}
