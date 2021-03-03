using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Add
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudInCoreWebApi.Models
{
    public class Trainee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TraineeID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailID { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string CellPhoneNo { get; set; }

    }
}
