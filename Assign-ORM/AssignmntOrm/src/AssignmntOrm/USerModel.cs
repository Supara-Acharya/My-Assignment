using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmntOrm
{
    
    public class UserModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        public string DOB { get; set; }
        [Required]
        [MaxLength(60)]
        public string URL { get; set; }

        public List<ProductModels> ProductModels { get; set; }
    }
}
