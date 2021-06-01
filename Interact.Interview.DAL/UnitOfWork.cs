using Interact.Interview.Core;
using Interact.Interview.Core.IRepositories;
using Interact.Interview.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interact.Interview.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            productRepo = new ProductRepository(context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public IProductRepo productRepo { get; }
    }
}
