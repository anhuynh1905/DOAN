﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN._Class
{
    public class Manager : Staff
    {
        public Manager(string _username, string _password, string _role, string _firstname, string _lastname, string _phonenumber) : base(_username, _password, _role, _firstname, _lastname, _phonenumber) { }
    }
}
 