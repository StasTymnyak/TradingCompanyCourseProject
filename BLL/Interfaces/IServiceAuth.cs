﻿using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IServiceAuth
    {
        void RegUser();
        List<int> LogIn(string enteredEmail, string enteredPass);
    }
}
