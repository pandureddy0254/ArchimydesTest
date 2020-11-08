﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimydes.DataAccessLayer
{
    public class LoginResponse
    {
        public string Email { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
