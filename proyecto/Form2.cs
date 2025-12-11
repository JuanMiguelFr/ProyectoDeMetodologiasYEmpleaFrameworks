/*
 * Creado por SharpDevelop.
 * Usuario: Gabriel
 * Fecha: 10/12/2025
 * Hora: 03:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{int contador = 0;
		double precio = 0;
		int subtotal = 0;
		string productos;
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Form2Load(object sender, EventArgs e)
		{
			txtPrecio.Text=(0).ToString("c");
		}
		
		void TxtCambioTextChanged(object sender, EventArgs e)
		{
			
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			contador++;
			int cantidad = Convert.ToInt32(txtCantidad.Text);
			this.txtTotal.Text = cantidad * precio+ "";
			string total = txtTotal.Text;
			ListViewItem fila = new ListViewItem(productos);
				fila.SubItems.Add(cantidad.ToString());
				fila.SubItems.Add(precio.ToString());
				fila.SubItems.Add(total.ToString());
				lvTabla.Items.Add(fila);
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			contador--;
			//lvTabla.Items.Remove(contador);
		}
		
		void RbtDulceCheckedChanged(object sender, EventArgs e)
		{
		   this.cbbDulce.Visible = true;
		   this.cbbSalado.Visible = false;	
		}
		
		void RbtSaladoCheckedChanged(object sender, EventArgs e)
		{
			this.cbbDulce.Visible = false;
			this.cbbSalado.Visible = true;
		}
		
		void CbbSaladoSelectedIndexChanged(object sender, EventArgs e)
		{
			productos= cbbSalado.Text;
			if (productos.Equals("Galletas")) precio=100;
			if (productos.Equals("Pan tostado")) precio=50;
			if (productos.Equals("Surtido de quesos")) precio=350;
			if (productos.Equals("Pretzels Salados")) precio=100;
			if (productos.Equals("Tablas de Quesos")) precio=500;
			txtPrecio.Text=precio.ToString("c");
		}
		
		void CbbDulceSelectedIndexChanged(object sender, EventArgs e)
		{
		    productos= cbbDulce.Text;
			if (productos.Equals("Cheesecake")) precio=150;
			if (productos.Equals("Apple Pie")) precio=250;
			if (productos.Equals("Pastel de chocolate")) precio=350;
			if (productos.Equals("Red Velvet")) precio=350;
			if (productos.Equals("Tiramisú")) precio=400;
			txtPrecio.Text=precio.ToString("c");
		}
	}
}
