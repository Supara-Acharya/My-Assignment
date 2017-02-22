using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmntOrm
{
    
    public class UpdateModels
    {
        [Key]
        public int UpdaeId { get; set; }
        [Required]
        public string Name { get; set; }
        
        [MaxLength(200)]
        public string Description { get; set; }

        public int ProductId { get; set; }
        public ProductModels ProductModels { get; set; }
    }
}
