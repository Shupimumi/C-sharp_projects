using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShopPLL
{
	public partial class PLL : Form
	{
		public Button login;
		public Button signin;
		public Button enter;
		public PLL()
		{
			login = new Button();
			signin = new Button();
			enter = new Button();
			signin.Size = new Size(60,30);
			signin.Location = new Point(160,120);
			signin.Text = "Sign in";
			login.Size = new Size(60,30);
			login.Location = new Point(100, 120);
			login.Text = "Log in";
			this.Controls.Add(signin);
			this.Controls.Add(login);
			login.Click += new EventHandler(login_Click);
			signin.Click += new EventHandler(signin_Click);
		}
		private void login_Click(object sender, EventArgs e)
		{
			MessageBox.Show("There will be Log in");
		}
		private void signin_Click(object sender, EventArgs e)
		{
			MessageBox.Show("There will be Sign in");
		}
		private void PLL_Load(object sender, EventArgs e)
		{

		}
	}
	}

