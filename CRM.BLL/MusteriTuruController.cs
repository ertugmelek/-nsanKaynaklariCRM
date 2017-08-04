using CRM.DAL.Repositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL
{
    public class MusteriTuruController
    {
        MusteriTuruManagement mtm;
       public MusteriTuruController()
        {
            mtm = new MusteriTuruManagement();
        }

        public List<MusteriTuru> MusteriTurListele()
        {
            return (List < MusteriTuru >)mtm.GetAll();
        }


    }
}
