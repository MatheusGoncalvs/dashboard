﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public DateTime InicioCarreira { get; set; }
        public string NomeCompleto { get; set; }
    }
}
