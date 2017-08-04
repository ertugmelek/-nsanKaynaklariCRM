using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.IRepositories
{
    interface IAdd<T> where T : class
    {
        bool Add(T obj);
    }
}
