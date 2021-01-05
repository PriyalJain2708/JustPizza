using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApiPizza.Controllers
{
    public class LoginController : ApiController
    {
		// GET: Login

		//https://localhost:44349/api/Login/getlogin?Uname=Mahima&Pswd=1234
		
		
		[System.Web.Http.HttpGet]
		public string GetLogin(String Uname, String Pswd)
			
		{
			string result = "";
			SqlDataAdapter adapter = new SqlDataAdapter();
			DataSet ds = new DataSet();

			string strcon = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
			//create new sqlconnection and connection to database by using connection string from web.config file  
			SqlConnection con = new SqlConnection(strcon);
			con.Open();

			string query = "Select * from UserDetails where UserName='"+ Uname+ "' and Paswd='" + Pswd+"'";
			adapter = new SqlDataAdapter(query, con);
			adapter.Fill(ds);

			if (ds.Tables[0].Rows.Count > 0)
			{
				result = "Pass";

			}
			else
			{

				result = "Fail";
			}

			//SqlCommand command = new SqlCommand("Select * from UserDetails where UserName="+Uname + "and Paswd="+ Pswd,con);
			//int result = command.ExecuteNonQuery();
			return result;

			//return Request.CreateResponse(HttpStatusCode.OK);
		}
	}
}