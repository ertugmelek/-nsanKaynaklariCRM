using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRM.Extension
{
   public class Helper
    {
        public static void MesajGoster(Page targetPage, string message)
        {
            Literal ltr = new Literal();
            ltr.Text = "<script type=\"text/javascript\"alert('" + message + "')</script>";
            targetPage.Header.Controls.Add(ltr);



        }
    }
}
