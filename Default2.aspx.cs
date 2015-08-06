using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Default2 : System.Web.UI.Page
{
    SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=mydata;Integrated Security=True");
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {

            insertdata();
        }

    }
    public void insertdata()
    {

        

        cmd = new SqlCommand("insert into mytbl(name , address) values('" + Request.QueryString["name"].ToString() + "' , '" + Request.QueryString["address"].ToString()+ "')", sqlcon);
        sqlcon.Open();
        cmd.ExecuteNonQuery();
        sqlcon.Close();
        Response.Write("data saved....");

    }

}