using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.IRepositories
{
    interface IBireyselUnvanRepository
    {

        List<BireyselUnvan> GetUnvan(int id);
    }
}
