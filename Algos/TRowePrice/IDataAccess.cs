﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.TRowePrice
{
    public interface IDataAccess
    {
        public List<Trade> LoadTrades();
    }
}
