using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.IRepositories
{
    interface ICrudRepository<Tkey, Tvalue> : IAdd<Tvalue>, IDelete<Tkey, Tvalue>, IGet<Tvalue, Tkey>, IUpdate<Tvalue> where Tvalue : class
    {
    }
}
