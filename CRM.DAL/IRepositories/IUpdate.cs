using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.IRepositories
{
    interface IUpdate<T> where T : class
    {
        bool Update(T obj);
    }
}
