using CRM.DAL.Repositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL
{
   public class FaaliyetAlaniController
    {
        FaaliyetAlaniManagement fam;

        public FaaliyetAlaniController()
        {
            fam = new FaaliyetAlaniManagement();
        }

        public List<FaaliyetAlani> FaaliyetAlanlariGetir()
        {
            return (List< FaaliyetAlani >)fam.GetAll();
        }
    }
}
