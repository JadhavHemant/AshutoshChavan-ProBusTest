    using System.ComponentModel.DataAnnotations;

    namespace ProbusTest.Models
    {
        public class Employee
        {        
            public int Id { get; set; }
            [Required]
            public string Salution { get; set; }
            [Required]
            public string EmployeeName { get; set; }
            [Required]

            public string CompanyName { get; set; }
            [Required]

            public string Location { get; set; }
            [Required]

            public string Department { get; set; }
            [Required]

            public string Designation { get; set; }
            [Required]

            public string Gender { get; set; }
            [Required]

            public DateTime JoiningDate { get; set; }
            [Required]

            public string CompanyMobileNo { get; set; }
            [Required]

            public string MailId { get; set; }

        }
    }
