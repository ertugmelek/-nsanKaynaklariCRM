using CRM.DAL.IRepositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.Repositories
{
    public class MusteriFirmaManagement : ICrudRepository<int, MusteriFirma>
    {
        CRM1Entities _db = new CRM1Entities();
        public bool Add(MusteriFirma obj)
        {
            try
            {
                _db.MusteriFirmas.Add(obj);
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

        public bool Delete(MusteriFirma obj)
        {
            try
            {
                _db.MusteriFirmas.Remove(obj);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public MusteriFirma Get(int key)
        {
            try
            {
               return _db.MusteriFirmas.Find(key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ICollection<MusteriFirma> GetAll()
        {
            try
            {

            return _db.MusteriFirmas.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(MusteriFirma obj)
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
