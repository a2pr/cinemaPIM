﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaPIM.Classes;

namespace CinemaPIM.Repos
{
    class LoginRepo :InterfaceRepo
    {
        public void connectDb()
        {
            Database db = new Database();
        }
    }
}
