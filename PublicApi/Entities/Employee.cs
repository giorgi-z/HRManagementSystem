using System;
using System.Collections.Generic;
using System.Text;

namespace PublicApi.Entities
{
    public class Employee : BaseEntity
    {
        public string PersonalNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public DateTime? EndDate { get; set; } 
        public string ContactPhone { get; set; }
        public EmployeeGender EmployeeGender { get; set; }
        public int GenderId { get; set; }
        public EmployeeStatus EmployeeStatus { get; set; }
        public int StatusId { get; set; }
    }
}
