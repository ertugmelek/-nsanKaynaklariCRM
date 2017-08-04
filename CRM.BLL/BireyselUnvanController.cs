using CRM.DAL.Repositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL
{
    public class BireyselUnvanController
    {
        BireyselUnvanManagement bum;
        public BireyselUnvanController()
        {
            bum = new BireyselUnvanManagement();
        }
        public List<BireyselUnvan> UnvanGetir()
        {
            return (List<BireyselUnvan>)bum.GetAll();
        }
    }
}
