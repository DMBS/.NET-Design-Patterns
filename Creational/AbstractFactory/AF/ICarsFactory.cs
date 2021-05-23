﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    public interface ICarsFactory
    {
        ISedan CreateSedan();
        ICoupe CreateCoupe();
        IUniversal CreateUniversal();
    }
}