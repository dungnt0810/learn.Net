using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_API_EF.Models.EFCore;

namespace WebApplication_API_EF.Models.Repositories
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DbSession6Context dbContext) : base(dbContext)
        {

        }

        public List<Invoice> Search(double min, double max)
        {
            return GetAll().Where(i => i.Total >= min && i.Total <= max).ToList();
        }
    }
}
