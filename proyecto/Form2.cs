/*
 * Creado por SharpDevelop.
 * Usuario: asus
 * Fecha: 07/12/2025
 * Hora: 12:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace proyecto
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{   int contador = 0;
		double precio = 0;
		double subtotal = 0;
		double total = 0;
		int cantidad;
		double pagar,cambio, pago;
		string connectionString = "Server=localhost;Database=login;User ID=root;Password=root;";
		string productos;
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.cbbDulce.Visible = false;
			this.cbbSalado.Visible = false;
			
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
			cantidad = Convert.ToInt32(txtCantidad.Text);
			this.txtTotal.Text = cantidad * precio+ "";
			this.total = Double.Parse(txtTotal.Text);
			ListViewItem fila = new ListViewItem(productos);
				fila.SubItems.Add(cantidad.ToString());
				fila.SubItems.Add(precio.ToString());
				fila.SubItems.Add(total.ToString());
				lvTabla.Items.Add(fila);
				
				subtotal += total;
				this.txtSubtotal.Text = subtotal + "";
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			contador--;
			this.lvTabla.Items.RemoveAt(contador);
			//this.lvTabla.Items.Remove(contador);
			subtotal -= total;
			this.txtSubtotal.Text = subtotal + "";
			
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
		
		void TxtNetoTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtNetoEnter(object sender, EventArgs e)
		{
			
		}
		
		void TxtDescuentoTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtDescuentoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
			double des, imp;
			des = Double.Parse(txtDescuento.Text);
			imp = subtotal - des;
			this.txtNeto.Text= imp+ "";
			}
		}
		
		void TxtPagadoTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtPagadoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
			pagar = Double.Parse(txtNeto.Text);
			pago = Double.Parse(txtPagado.Text);
			cambio= pago- pagar;
			this.txtCambio.Text= cambio+ "";
			}
		}
		
		void BtnBorrarClick(object sender, EventArgs e)
		{
			lvTabla.Clear();
			cbbSalado.Text = "";
			cbbDulce.Text = "";
			txtTotal.Clear();
			txtCambio.Clear();
			txtCantidad.Clear();
			txtDescuento.Clear();
			txtNeto.Clear();
			txtPrecio.Clear();
			txtSubtotal.Clear();
			txtPagado.Clear();
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			using (MySqlConnection conexion = new MySqlConnection(connectionString)){
			string query = "INSERT INTO venta (cantidad, producto, total) VALUES (@cantidad, @producto, @total)";
			MySqlCommand cmd = new MySqlCommand(query, conexion);
			cmd.Parameters.AddWithValue("@cantidad",int.Parse(txtCantidad.Text));
			cmd.Parameters.AddWithValue("@producto",productos);
			cmd.Parameters.AddWithValue("@total",Double.Parse(txtSubtotal.Text));
			conexion.Open();
			cmd.ExecuteNonQuery();
			}
		}
		
		void BtnImprimirClick(object sender, EventArgs e)
		{
			MessageBox.Show ("Peoducto =" + productos +
			                 "Cantidad =" + cantidad +
			                 "Precio =" + precio +
			                 "Total =" + subtotal +
			                 "Importe =" + pago +
			                 "Cambio =" + cambio);
		}
	}
}
