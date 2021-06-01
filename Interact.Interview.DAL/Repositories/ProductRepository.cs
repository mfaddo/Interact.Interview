using Interact.Interview.Core.Domain;
using Interact.Interview.Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interact.Interview.DAL.Repositories
{
   public class ProductRepository : Repository<Product>, IProductRepo
    {
        public ProductRepository(DbContext context) : base(context)
        {

        }
        public DatabaseContext DatabaseContext => Context as DatabaseContext;
    }
}
