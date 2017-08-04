using CRM.DAL.IRepositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.Repositories
{
    public class FaaliyetAlaniManagement : IGet<FaaliyetAlani, int>
    {
        CRM1Entities _db = new CRM1Entities();
        public FaaliyetAlani Get(int key)
        {
            return _db.FaaliyetAlanis.Find(key);
        }

        public ICollection<FaaliyetAlani> GetAll()
        {
            return _db.FaaliyetAlanis.ToList();
        }
    }
}
