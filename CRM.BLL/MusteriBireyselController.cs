using CRM.DAL.Repositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL
{
   public class MusteriBireyselController
    {
        MusteriBireyselManagement mbm;


       public MusteriBireyselController()
        {
            mbm = new MusteriBireyselManagement();
        }


        public List<MusteriBireysel> Listele()
        {
            return (List<MusteriBireysel>)mbm.GetAll();

        }







    }
}
