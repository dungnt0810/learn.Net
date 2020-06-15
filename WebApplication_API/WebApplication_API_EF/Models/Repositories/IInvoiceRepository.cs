using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_API_EF.Models.EFCore;

namespace WebApplication_API_EF.Models.Repositories
{
    public interface IInvoiceRepository :IGenericRepository<Invoice>
    {
        public List<Invoice> Search(double min, double max);
    }

    
}
