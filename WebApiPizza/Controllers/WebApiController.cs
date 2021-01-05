using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Http;
using System;
using System.Data;

namespace WebApiPizza.Controllers
{
    public class WebApiController : ApiController
    {
		public HttpResponseMessage Get()
		{
			string strcon = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
			//create new sqlconnection and connection to database by using connection string from web.config file  
			SqlConnection con = new SqlConnection(strcon);
			con.Open();

			SqlCommand command = new SqlCommand("Select * from tbl_pizzadetails", con);
			int result = command.ExecuteNonQuery();
			var coll = new Dictionary<string, object>();
			using (SqlDataReader reader = command.ExecuteReader())
            {
				while (reader.Read())
                {
					coll.Add("img", reader["imageSrc"].ToString());
					coll.Add("name", reader["name"].ToString());
					coll.Add("address", reader["address"].ToString());
					coll.Add("city", reader["city"].ToString());
					coll.Add("state", reader["state"].ToString());
					coll.Add("zipCode", reader["zipCode"].ToString());
					coll.Add("category", reader["category"].ToString());
					coll.Add("rating", reader["rating"].ToString());
					coll.Add("reviewCount", reader["reviewCount"].ToString());
				}

			}
			return Request.CreateResponse(HttpStatusCode.OK, coll, "application/json");
		}
	}
};
