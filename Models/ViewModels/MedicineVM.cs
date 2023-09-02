using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Models.ViewModels
{
    public class MedicineVM
    {
        public Medicine Medicine { get; set; }
        public IEnumerable<SelectListItem> TypeDropDown { get; set; }
    }
}
