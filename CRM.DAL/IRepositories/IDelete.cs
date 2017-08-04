using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.IRepositories
{
    interface IDelete<Tkey, Tvalue> where Tvalue : class
    {
        bool Delete(Tvalue obj);
        bool Delete(Tkey key);
    }
}
