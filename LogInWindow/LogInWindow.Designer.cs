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
			this.nameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.shopLabel = new System.Windows.Forms.Label();
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
			// 
			// signin
			// 
			this.signin.Location = new System.Drawing.Point(419, 235);
			this.signin.Name = "signin";
			this.signin.Size = new System.Drawing.Size(112, 21);
			this.signin.TabIndex = 1;
			this.signin.Text = "Sign in";
			this.signin.UseVisualStyleBackColor = true;
			// 
			// loginField
			// 
			this.loginField.Location = new System.Drawing.Point(294, 151);
			this.loginField.Name = "loginField";
			this.loginField.Size = new System.Drawing.Size(237, 20);
			this.loginField.TabIndex = 2;
			// 
			// passwordField
			// 
			this.passwordField.Location = new System.Drawing.Point(294, 187);
			this.passwordField.Name = "passwordField";
			this.passwordField.Size = new System.Drawing.Size(237, 20);
			this.passwordField.TabIndex = 3;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(233, 154);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(35, 13);
			this.nameLabel.TabIndex = 4;
			this.nameLabel.Text = "Name";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(233, 190);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(53, 13);
			this.passwordLabel.TabIndex = 5;
			this.passwordLabel.Text = "Password";
			// 
			// shopLabel
			// 
			this.shopLabel.AutoSize = true;
			this.shopLabel.Location = new System.Drawing.Point(346, 99);
			this.shopLabel.Name = "shopLabel";
			this.shopLabel.Size = new System.Drawing.Size(119, 13);
			this.shopLabel.TabIndex = 6;
			this.shopLabel.Text = "ComputerShop Program";
			// 
			// LogInWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.shopLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.passwordField);
			this.Controls.Add(this.loginField);
			this.Controls.Add(this.signin);
			this.Controls.Add(this.login);
			this.Name = "LogInWindow";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button login;
		private System.Windows.Forms.Button signin;
		private System.Windows.Forms.TextBox loginField;
		private System.Windows.Forms.TextBox passwordField;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label shopLabel;
	}
}

