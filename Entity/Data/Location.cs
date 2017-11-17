﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.UserModels;

namespace Entity.Data
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [NotMapped]
        public bool IsChecked { get; set; }
        public List<Tutor> Tutors { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
