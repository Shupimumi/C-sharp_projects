namespace LogInWindow
{
	partial class LogInWindow
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.login = new System.Windows.Forms.Button();
			this.signin = new System.Windows.Forms.Button();
			this.loginField = new System.Windows.Forms.TextBox();
			this.passwordField = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(294, 235);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(112, 21);
			this.login.TabIndex = 0;
			this.login.Text = "Log in";
			this.login.UseVisualStyleBackColor = true;
			this.login.Click += new System.EventHandler(this.Button1_Click);
			// 
			// signin
			// 
			this.signin.Location = new System.Drawing.Point(419, 235);
			this.signin.Name = "signin";
			this.signin.Size = new System.Drawing.Size(112, 21);
			this.signin.TabIndex = 1;
			this.signin.Text = "Sign in";
			this.signin.UseVisualStyleBackColor = true;
			this.signin.Click += new System.EventHandler(this.Button2_Click);
			// 
			// loginField
			// 
			this.loginField.Location = new System.Drawing.Point(294, 151);
			this.loginField.Name = "loginField";
			this.loginField.Size = new System.Drawing.Size(237, 20);
			this.loginField.TabIndex = 2;
			this.loginField.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// passwordField
			// 
			this.passwordField.Location = new System.Drawing.Point(294, 187);
			this.passwordField.Name = "passwordField";
			this.passwordField.Size = new System.Drawing.Size(237, 20);
			this.passwordField.TabIndex = 3;
			this.passwordField.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(233, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Name";
			this.label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(233, 190);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password";
			this.label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(346, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "ComputerShop Program";
			this.label3.Click += new System.EventHandler(this.Label3_Click);
			// 
			// LogInWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwordField);
			this.Controls.Add(this.loginField);
			this.Controls.Add(this.signin);
			this.Controls.Add(this.login);
			this.Name = "LogInWindow";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.LogInWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button login;
		private System.Windows.Forms.Button signin;
		private System.Windows.Forms.TextBox loginField;
		private System.Windows.Forms.TextBox passwordField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

