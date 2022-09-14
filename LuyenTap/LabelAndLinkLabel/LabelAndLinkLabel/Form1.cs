using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LabelAndLinkLabel
{
	public partial class lnk1 : Form
	{
		public lnk1()
		{
			InitializeComponent();
		}

		private void frmLinkLabel_Load(Object sender, EventArgs e)
		{
			string strURL = "mailto:ctk43@gmail.com";
			this.lnklb1.Links.Add(0, strURL.Length, strURL);
			strURL = "http://www.cnttk43.net";
			this.lnklb2.Links.Add(0, strURL.Length, strURL);
		}

		private void lnklb1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string strURL = Convert.ToString(e.Link.LinkData);
			if (strURL.StartsWith("mailto:"))
				Process.Start(strURL + "?subject=hello");
		}

		private void lnklb2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string strURL = Convert.ToString(e.Link.LinkData);
			if (strURL.StartsWith("http://www."))
				Process.Start(strURL);
		}
	}
}
