﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class BranchModel
    {
        public int Id { get; set; }
        [Required]
        public string address { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public string Email { get; set; }

        public List<ProductModel> Products { get; set; }
    }
}
