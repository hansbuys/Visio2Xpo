﻿using System;
using System.Collections.Generic;

namespace cvo.buyshans.Visio2Xpo.Data
{
    [Serializable]
    public class Schema
    {
        public String Name { get; set; }

        public IEnumerable<Table> Tables { get; set; }
    }
}