/*
 * Created by SharpDevelop.
 * User: CC2_PC37
 * Date: 08/12/2025
 * Time: 06:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int intentos = 4;
		void BtnLoginClick(object sender, EventArgs e)
		{
			string usuario = txtUsuario.Text;
			string contraseña = txtContraseña.Text;
			string usuarioCorrecto = "root";
			string contraseñaCorrecta = "root";
			if ( usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
			{
				MessageBox.Show ("Acceso Consedido ;)");
				Form1 form1 =new Form1();
				form1.Show();
				this.Hide();;;
			}
			else
			{
				intentos--;
				if (usuario != usuarioCorrecto && contraseña != contraseñaCorrecta)
				{
					MessageBox.Show("Usuario y contraseña incorrectos. Te quedan"+intentos);
                }
				else if (usuario != usuarioCorrecto)
				{
					MessageBox.Show("Usuario incorrecto. Te quedan"+intentos);
                }
				else if (contraseña != contraseñaCorrecta)
				{
					MessageBox.Show("Contraseña incorrecta. Te quedan"+intentos);
				}
				if (intentos == 0)
				{
					 MessageBox.Show("Cuenta bloqueada. Demasiados intentos fallidos.");
                     btnLogin.Enabled = false;
                      this.Close();
				}       
			}
		}
		
	}
}
