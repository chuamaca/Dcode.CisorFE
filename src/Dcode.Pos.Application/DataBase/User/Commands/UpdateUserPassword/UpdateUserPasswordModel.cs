﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dcode.Pos.Application.DataBase.User.Commands.UpdateUserPassword
{
    public class UpdateUserPasswordModel
    {
        public int UserId { get; set; }
        public string Password { get; set; }
    }
}
