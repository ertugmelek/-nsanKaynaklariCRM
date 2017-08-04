using CRM.DAL.IRepositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.Repositories
{
    public class AdresManagement : ICrudRepository<int, Adre>
    {
        CRM1Entities _db = new CRM1Entities();
        public bool Add(Adre obj)
        {
            try
            {
                _db.Adres.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Adre obj)
        {
            try
            {
                _db.Adres.Remove(obj);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public Adre Get(int key)
        {
            return _db.Adres.Find(key);
        }

        public ICollection<Adre> GetAll()
        {
            return _db.Adres.ToList();
        }

        public bool Update(Adre obj)
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
              
            }
        }
    }
}
