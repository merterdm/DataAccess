﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConApp.Entities
{
    public class Personel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        = string.Empty;
        public string LastName { get; set; }
        = string.Empty;
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
