using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //DateTime dt = Convert.ToDateTime(args.Value);
            DateTime dt = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);         
            if ((DateTime.Now.Year - dt.Year) > 16)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void RangeValidator1_PreRender(object sender, EventArgs e)
        {
            int day = DateTime.Now.Date.Day;
            int month = DateTime.Now.Date.Month;
            int year = DateTime.Now.Date.Year - 16;
            DateTime min = new DateTime(1, 1, 1);
            DateTime dt = new DateTime(year, month, day);
            RangeValidator1.MaximumValue = dt.Date.ToShortDateString();
            RangeValidator1.MinimumValue = min.Date.ToShortDateString();
        }
    }
}