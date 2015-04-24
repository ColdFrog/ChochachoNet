/*
 * Created by SharpDevelop.
 * User: cdaniels
 * Date: 3/18/2015
 * Time: 11:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Chochachonet
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public class Default : Page
	{	
		public string userList = "";
		private void Page_Load(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["SqlConnectionString"]))
			{
				conn.Open();
				SqlCommand getUsers = new SqlCommand("SELECT * FROM chochachos", conn);
				SqlDataReader sdr = getUsers.ExecuteReader();
				
				while(sdr.Read())
				{
					userList += sdr["username"].ToString();
				}
				conn.Close();
			}
			if(IsPostBack)
			{
				
			}
		}
	}
}