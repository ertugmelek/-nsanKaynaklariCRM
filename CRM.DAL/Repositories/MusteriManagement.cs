using CRM.DAL.IRepositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.Repositories
{
    public class MusteriManagement : ICrudRepository<int, Musteri>, IAddMusteriID<Musteri>
    {
        CRM1Entities _db = new CRM1Entities();
        public bool Add(Musteri obj)
        {
            try
            {
                _db.Musteris.Add(obj);
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

        public bool Delete(Musteri obj)
        {
            throw new NotImplementedException();
        }

        public Musteri Get(int key)
        {
            return _db.Musteris.Find(key);
        }

        public ICollection<Musteri> GetAll()
        {
            return _db.Musteris.ToList();
        }

        public bool Update(Musteri obj)
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





        public int Add2(Musteri obj)
        {
            try
            {
                _db.Musteris.Add(obj);
                _db.SaveChanges();
                return obj.MusteriID;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
