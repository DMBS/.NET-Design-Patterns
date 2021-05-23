﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingStrategy
{
    public class BakedStrategy : CookingStrategy
    {
        public override void Cook(string food)
        {
            if (food != null)
            {
                Console.WriteLine("Start to cooking baked {0}", food);
            }
        }
    }
}
