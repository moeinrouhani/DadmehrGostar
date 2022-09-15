using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.InfraStructure;
using File.Domain.ProceedingSession;

namespace File.EfCore.Repository
{
    public class ProceedingSessionRepository : RepositoryBase<long, ProceedingSession>, IProceedingSessionRepository
    {
        private readonly FileContext _context;
        public ProceedingSessionRepository(FileContext context) : base(context)
        {
            _context = context;
        }
    }
}
