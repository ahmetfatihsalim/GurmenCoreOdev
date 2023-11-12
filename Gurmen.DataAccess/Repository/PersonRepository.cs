using Gurmen.DataAccess.Data;
using Gurmen.DataAccess.Repository.IRepository;
using Gurmen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurmen.DataAccess.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        private ApplicationDbContext _db;

        public PersonRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
    }
}
