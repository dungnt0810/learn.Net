using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_API_EF.Models.EFCore;

namespace WebApplication_API_EF.Models.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(DbSession6Context dbContext) : base(dbContext)
        {

        }
    }
}
