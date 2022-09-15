using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Files.Application.Board;
using Files.Application.File;
using Files.Application.Petition;
using File.Contract;
using File.Domain.Board;
using File.Domain.File;
using File.Domain.Petition;
using File.EfCore;
using File.EfCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace File.Configuration
{
    public class FileBootstrapper
    {
        public static void Cofigure(IServiceCollection service, string connectionString)
        {
            service.AddTransient<IBoardApplication, BoardApplication>();
            service.AddTransient<IBoardRepository, BoardRepository>();

            service.AddTransient<IFileApplication, FileApplication>();
            service.AddTransient<IFileRepository, FileRepository>();

            service.AddTransient<IPetitionApplication, PetitionApplication>();
            service.AddTransient<IPetitionRepository, PetitionRepository>();

            service.AddDbContext<FileContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
