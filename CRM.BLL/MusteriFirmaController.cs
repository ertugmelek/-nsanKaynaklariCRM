using CRM.DAL.Repositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL
{
   public class MusteriFirmaController
    {
        MusteriFirmaManagement mfm;

        public MusteriFirmaController()
        {
            mfm = new MusteriFirmaManagement();
        }


        public List<MusteriFirma> VeriCek()
        {
            return (List<MusteriFirma>)mfm.GetAll();
        }




    }
}
