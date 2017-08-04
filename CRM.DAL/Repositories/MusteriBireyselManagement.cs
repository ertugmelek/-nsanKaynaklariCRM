using CRM.DAL.IRepositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRM.DAL.Repositories
{
    public class MusteriBireyselManagement : ICrudRepository<int, MusteriBireysel>
    {
        CRM1Entities _db = new CRM1Entities();
        public bool Add(MusteriBireysel obj)
        {
            try
            {
                _db.MusteriBireysels.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Delete(MusteriBireysel obj)
        {
            try
            {

            _db.MusteriBireysels.Remove(obj);
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

            try
            {
                //silme kodu gelecek
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public ICollection<MusteriBireysel> GetAll()
        {
            return _db.MusteriBireysels.ToList();
        }

        public MusteriBireysel Get(int key)
        {
            return _db.MusteriBireysels.Find(key);
        }

        public bool Update(MusteriBireysel obj)
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

                throw;
            }
        }
    }
}
