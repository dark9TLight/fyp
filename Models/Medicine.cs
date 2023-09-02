using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Models
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Medicine")]
        [Required]
        public string MedicineName { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage ="Amount must be greater than -1")]
        public int Amount { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        /*To avoid below error, you must empty the medicine table in order to avoid id conflict */
        /*The ALTER TABLE statement conflicted with the FOREIGN KEY constraint*/
        /*between table medicines and categories*/

        //if you are wondering why the hell does your database does not have foreign key eventhough you did the migration so many times...
        //soft reminder to do update database after add migration to see the changes
    }
}

