﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Fillter
{
    interface ICriteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }
}
