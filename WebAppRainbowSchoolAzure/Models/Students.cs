using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppRainbowSchoolAzure.Models
{
    [Table("Students")]
    public class Students
    {
         
        [Key]
        public int StudentId { get; set; }
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public string ?Course { get; set; }
        public string ?Gender { get; set; }


    }
}

