using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.InfraStructure;
using File.Domain.File;
using File.Domain.WorkHistory;

namespace File.EfCore.Repository
{
    public class WorkHistoryRepository : RepositoryBase<long, WorkHistory>, IWorkHistoryRepository
    {
        private readonly FileContext _context;
        public WorkHistoryRepository(FileContext context) : base(context)
        {
            _context = context;
        }
    }
}
