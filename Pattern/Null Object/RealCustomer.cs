﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Null_Object
{
    class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            m_name = name;
        }
        public override string GetName()
        {
            return m_name;
        }

        public override bool IsNil()
        {
            return false;
        }
    }
}
