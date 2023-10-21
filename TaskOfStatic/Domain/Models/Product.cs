﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product:BaseEntitiy
    {
        public string Name {  get; set; }
        public double Price { get; set; }

        public DateTime CreatedDate { get; set; }

        public Category Category { get; set; }
    }
}
