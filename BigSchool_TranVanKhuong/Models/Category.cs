﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BigSchool_TranVanKhuong.Models
{
    public class Category
    {

        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
    }
}