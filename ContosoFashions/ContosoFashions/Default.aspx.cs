using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace ContosoFashions
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        System.Diagnostics.Trace.WriteLine("System.Diagnostics.Trace.WriteLine() in the Page_Load method");
        Trace.Write("Trace.Write() in the Page_Load method");
        System.Diagnostics.Trace.TraceError("System.Diagnostics.Trace.TraceError() in the Page_Load method");
        System.Diagnostics.Trace.TraceWarning("System.Diagnostics.Trace.TraceWarning() in the Page_Load method");
        System.Diagnostics.Trace.TraceInformation("System.Diagnostics.Trace.TraceInformation() in the Page_Load method");
        }
    }
}