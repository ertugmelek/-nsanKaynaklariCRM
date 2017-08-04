using CRM.DAL.IRepositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.Repositories
{
    public class BireyselUnvanManagement : IBireyselUnvanRepository, IGet<BireyselUnvan, int>,IAdd<BireyselUnvan>
    {
        CRM1Entities _db = new CRM1Entities();

        public bool Add(BireyselUnvan obj)
        {
            try
            {
                _db.BireyselUnvans.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public BireyselUnvan Get(int key)
        {
            return _db.BireyselUnvans.Find(key);
        }

        public ICollection<BireyselUnvan> GetAll()
        {
            return _db.BireyselUnvans.ToList();
        }

        public List<BireyselUnvan> GetUnvan(int id)
        {
            return _db.BireyselUnvans.Where(x => x.UnvanID == id).ToList();
        }
    }
}
