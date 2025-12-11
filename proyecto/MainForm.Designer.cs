/*
 * Created by SharpDevelop.
 * User: CC2_PC37
 * Date: 08/12/2025
 * Time: 06:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(264, 12);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(76, 72);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(104, 84);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(109, 73);
			this.btnLogin.TabIndex = 21;
			this.btnLogin.Text = "Acceder";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(104, 51);
			this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(142, 20);
			this.txtContraseña.TabIndex = 20;
			this.txtContraseña.UseSystemPasswordChar = true;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(104, 20);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(142, 20);
			this.txtUsuario.TabIndex = 19;
			// 
			// lblContraseña
			// 
			this.lblContraseña.Location = new System.Drawing.Point(13, 50);
			this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(75, 19);
			this.lblContraseña.TabIndex = 18;
			this.lblContraseña.Text = "Contraseña";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Location = new System.Drawing.Point(13, 19);
			this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(75, 19);
			this.lblUsuario.TabIndex = 17;
			this.lblUsuario.Text = "Usuario";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 182);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lblContraseña);
			this.Controls.Add(this.lblUsuario);
			this.Name = "MainForm";
			this.Text = "proyecto";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
