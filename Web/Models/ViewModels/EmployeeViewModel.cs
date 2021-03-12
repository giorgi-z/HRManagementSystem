using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [DisplayName("Personal Number")]
        public string PersonalNumber { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Birth Date")]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Position { get; set; }
        [DisplayName("Contact Phone")]

        public string ContactPhone { get; set; }
        [DisplayName("Gender")]

        public int GenderId { get; set; }
        [DisplayName("Status")]

        [Required]
        public int StatusId { get; set; }
        [DisplayName("End Date")]
        public DateTime? EndDate { get; set; }
    }
}
