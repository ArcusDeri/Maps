using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

public partial class ReadData : System.Web.UI.Page
{
    private string TXT_PATH = HttpContext.Current.Server.MapPath("data.txt");
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.AppendHeader("Access-Control-Allow-Origin", "*");
        try
        {
            StreamReader sr = new StreamReader(TXT_PATH, Encoding.Default);
            string all = sr.ReadToEnd();
            string retTabs = "["+all.Substring(0, all.Length - 3)+"]";
            sr.Close();
            Response.Write(retTabs);
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
    }
}