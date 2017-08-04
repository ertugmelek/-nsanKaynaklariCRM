using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.IRepositories
{
    interface IAddMusteriID<T> where T : class
    {
        int Add2(T obj);
    }
}
