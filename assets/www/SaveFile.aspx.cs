using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

public partial class SaveFile : System.Web.UI.Page
{
    private string TXT_PATH = HttpContext.Current.Server.MapPath("data.txt");
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.AppendHeader("Access-Control-Allow-Origin", "*");
        string Data = Request["SendData"];
        zapisz(Data);
    }
    private void zapisz(string Data)
    {
        try
        {
            StreamWriter sw = new StreamWriter(TXT_PATH, true, Encoding.Default);
            sw.WriteLine(Data+",");
            sw.Close();
            Response.Write("ok");
        }
        catch (Exception ex)
        {
            Response.Write("błąd" + ex.Message);
        }
    }
}