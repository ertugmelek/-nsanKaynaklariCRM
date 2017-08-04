using CRM.DAL.IRepositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.Repositories
{
    public class MusteriTuruManagement : ICrudRepository<int, MusteriTuru>
    {
        CRM1Entities _db = new CRM1Entities();
        public bool Add(MusteriTuru obj)
        {
            try
            {
                _db.MusteriTurus.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public bool Delete(MusteriTuru obj)
        {
            try
            {
                _db.MusteriTurus.Remove(obj);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public MusteriTuru Get(int key)
        {
            try
            {
               return  _db.MusteriTurus.Find(key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ICollection<MusteriTuru> GetAll()
        {
            try
            {
                return _db.MusteriTurus.ToList();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(MusteriTuru obj)
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
