using CRM.DAL.IRepositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.Repositories
{
    public class TelefonManagement:ICrudRepository<int, Telefon>
    {
        CRM1Entities _db = new CRM1Entities();
        public bool Add(Telefon obj)
        {
            try
            {
                _db.Telefons.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Telefon obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public ICollection<Telefon> GetAll()
        {
            return _db.Telefons.ToList();
        }

        public Telefon Get(int key)
        {
            return _db.Telefons.Find(key);
        }

        public bool Update(Telefon obj)
        {
            throw new NotImplementedException();
        }
    }
}
