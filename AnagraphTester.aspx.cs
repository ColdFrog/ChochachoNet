/*
 * Created by SharpDevelop.
 * User: cdaniels
 * Date: 5/14/2015
 * Time: 9:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Chochachonet
{
	/// <summary>
	/// Description of AnagraphTester
	/// </summary>
	public class AnagraphTester : Page
	{
		protected TextBox word1;
		protected TextBox word2;
		protected Label WordCompareBox;
		protected HtmlGenericControl ResultBox;
		protected HtmlGenericControl ErrorBox;
		
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(IsPostBack)
			{
			}
		}
	
		public void CompareWords(object sender, EventArgs args)
		{
			bool compareSuccess = false;
			bool isEqual = false;
			try
			{
				isEqual = Anagraph.compareWords(word1.Text, word2.Text);
				compareSuccess = true;
			}
			catch (Exception exc) {
				ErrorBox.Visible = true;
			}
			
			if (compareSuccess)
			{
				ErrorBox.Visible = false;
				
				string compareDisplay = "<span style='color:red;'>&#8800;</span>";
				if (isEqual)
				{
					compareDisplay = "<span style='color:green;'>=</span>";
				}
				ResultBox.Visible = true;
				StringBuilder fullText = new StringBuilder();
				fullText.Append("<div style='width:800px;'>");
				fullText.Append("<div style='width:380px; float:left; text-align:right;'>" + word1.Text.ToUpper() + "</div>");
				fullText.Append("<div style='width:40px; float:left;'>" + compareDisplay + "</div>");
				fullText.Append("<div style='width:380px; float:right; text-align:left;'>" + word2.Text.ToUpper() + "</div>");
				fullText.Append("</div>\n");
				fullText.Append(WordCompareBox.Text);
				WordCompareBox.Text = fullText.ToString();
				word1.Text = "";
				word2.Text = "";
			}
		}
		
		public void clearEntries(object sender, EventArgs args)
		{
			ErrorBox.Visible = false;
			ResultBox.Visible = false;
			WordCompareBox.Text = "";
		}
	}
}
