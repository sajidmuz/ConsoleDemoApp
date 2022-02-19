﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.Assignment
{
    internal class SingletonPatterrn
    {
        private static SingletonPatterrn instance;
        private SingletonPatterrn() { }

        public static SingletonPatterrn getInstance()
        {
            if(instance == null)
            {
                instance = new SingletonPatterrn();
            }
            return instance;
        }
    }
}
