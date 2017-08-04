using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DAL.IRepositories
{
    interface IGet<Tvalue, Tkey> where Tvalue : class
    {
        ICollection<Tvalue> GetAll(); //hepsini getir.

        Tvalue Get(Tkey key); //ıd ye göre satır döner


    }
}
