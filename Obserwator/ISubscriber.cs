﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    public interface ISubscriber
    {
        void Update(string context);
    }
}
