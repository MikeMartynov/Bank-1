﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Controller
    {
        static Controller controller;
        public static Controller GetInstance()
        {
            if (controller == null)
                controller = new Controller();
            return controller;
        }
    }
}
