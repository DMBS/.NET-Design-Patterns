﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
