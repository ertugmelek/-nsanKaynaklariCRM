using CRM.DAL.IRepositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.Repositories
{
    public class EmailManagement : ICrudRepository<int, Email>
    {
        CRM1Entities _db = new CRM1Entities();
        public bool Add(Email obj)
        {
            try
            {

            _db.Emails.Add(obj);
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

        public bool Delete(Email obj)
        {
            try
            {
                _db.Emails.Remove(obj);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Email Get(int key)
        {
           return _db.Emails.Find(key);
        }

        public ICollection<Email> GetAll()
        {
            return _db.Emails.ToList();
        }

        public bool Update(Email obj)
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
