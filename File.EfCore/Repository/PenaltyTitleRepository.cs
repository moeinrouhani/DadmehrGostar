using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.InfraStructure;
using File.Domain.File;
using File.Domain.PenaltyTitle;

namespace File.EfCore.Repository
{
    public class PenaltyTitleRepository : RepositoryBase<long, PenaltyTitle>, IPenaltyTitleRepository
    {
        private readonly FileContext _context;
        public PenaltyTitleRepository(FileContext context) : base(context)
        {
            _context = context;
        }
    }
}
