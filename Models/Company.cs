using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

    }
}
