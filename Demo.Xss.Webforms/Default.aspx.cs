using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo.Xss.Webforms
{
    public partial class _Default : Page
    {
        public string Name { get; set; }
        public string Description { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
    }
}