﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Hotel(string name)
        {
            Name = name;
        }
    }
}
