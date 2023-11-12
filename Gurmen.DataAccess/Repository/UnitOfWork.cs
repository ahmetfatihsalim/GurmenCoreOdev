using Gurmen.DataAccess.Data;
using Gurmen.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurmen.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IPersonRepository PersonRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            PersonRepository = new PersonRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
