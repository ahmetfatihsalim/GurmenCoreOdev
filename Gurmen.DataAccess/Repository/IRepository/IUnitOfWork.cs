﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurmen.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IPersonRepository PersonRepository { get; }
        Task Save();
    }
}
