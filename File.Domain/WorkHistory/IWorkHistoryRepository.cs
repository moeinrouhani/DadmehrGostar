﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;

namespace File.Domain.WorkHistory
{
    public interface IWorkHistoryRepository : IRepository<long, WorkHistory>
    {
    }
}
