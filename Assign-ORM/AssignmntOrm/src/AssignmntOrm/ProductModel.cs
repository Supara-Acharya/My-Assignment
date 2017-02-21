using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmntOrm
{
    public class ProductModels
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        [MaxLength(60)]
        public string HomepageUrl { get; set; }

        public List<UpdateModels> UpdateModels { get; set; }
        
    }
}

