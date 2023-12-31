﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        //[MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        public List<Destination>? Destinations { get; set; }
    }
}
