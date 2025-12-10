/*
 * Creado por SharpDevelop.
 * Usuario: Gabriel
 * Fecha: 10/12/2025
 * Hora: 03:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyecto
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.cbbSalado = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPagado = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNeto = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lvTabla = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbbDulce = new System.Windows.Forms.ComboBox();
			this.rbtSalado = new System.Windows.Forms.RadioButton();
			this.rbtDulce = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// cbbSalado
			// 
			this.cbbSalado.FormattingEnabled = true;
			this.cbbSalado.Items.AddRange(new object[] {
									"Galletas",
									"Pan tostado",
									"Surtido de quesos",
									"Pretzels Salados",
									"Tablas de Quesos"});
			this.cbbSalado.Location = new System.Drawing.Point(181, 33);
			this.cbbSalado.Margin = new System.Windows.Forms.Padding(2);
			this.cbbSalado.Name = "cbbSalado";
			this.cbbSalado.Size = new System.Drawing.Size(126, 21);
			this.cbbSalado.TabIndex = 58;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(318, 6);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 154);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 57;
			this.pictureBox1.TabStop = false;
			// 
			// btnImprimir
			// 
			this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.Location = new System.Drawing.Point(193, 423);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(76, 32);
			this.btnImprimir.TabIndex = 56;
			this.btnImprimir.Text = "IMPRIMIR";
			this.btnImprimir.UseVisualStyleBackColor = true;
			// 
			// btnBorrar
			// 
			this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrar.Location = new System.Drawing.Point(101, 423);
			this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(76, 32);
			this.btnBorrar.TabIndex = 55;
			this.btnBorrar.Text = "BORRAR";
			this.btnBorrar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(11, 423);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(76, 32);
			this.btnGuardar.TabIndex = 54;
			this.btnGuardar.Text = "GUARDAR";
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// txtCambio
			// 
			this.txtCambio.Location = new System.Drawing.Point(115, 392);
			this.txtCambio.Margin = new System.Windows.Forms.Padding(2);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(76, 20);
			this.txtCambio.TabIndex = 53;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(11, 391);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 20);
			this.label9.TabIndex = 52;
			this.label9.Text = "CAMBIO:";
			// 
			// txtPagado
			// 
			this.txtPagado.Location = new System.Drawing.Point(318, 371);
			this.txtPagado.Margin = new System.Windows.Forms.Padding(2);
			this.txtPagado.Name = "txtPagado";
			this.txtPagado.Size = new System.Drawing.Size(76, 20);
			this.txtPagado.TabIndex = 51;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(198, 371);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(124, 20);
			this.label8.TabIndex = 50;
			this.label8.Text = "IMPORTE PAGADO:";
			// 
			// txtNeto
			// 
			this.txtNeto.Location = new System.Drawing.Point(115, 369);
			this.txtNeto.Margin = new System.Windows.Forms.Padding(2);
			this.txtNeto.Name = "txtNeto";
			this.txtNeto.Size = new System.Drawing.Size(76, 20);
			this.txtNeto.TabIndex = 49;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(9, 369);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(118, 20);
			this.label7.TabIndex = 48;
			this.label7.Text = "IMPORTE NETO:";
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(318, 348);
			this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(76, 20);
			this.txtDescuento.TabIndex = 47;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(203, 350);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 19);
			this.label6.TabIndex = 46;
			this.label6.Text = "DESCUENTO:";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(115, 346);
			this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(76, 20);
			this.txtSubtotal.TabIndex = 45;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 350);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 19);
			this.label5.TabIndex = 44;
			this.label5.Text = "SUBTOTAL:";
			// 
			// lvTabla
			// 
			this.lvTabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4});
			this.lvTabla.Location = new System.Drawing.Point(11, 184);
			this.lvTabla.Margin = new System.Windows.Forms.Padding(2);
			this.lvTabla.Name = "lvTabla";
			this.lvTabla.Size = new System.Drawing.Size(443, 148);
			this.lvTabla.TabIndex = 43;
			this.lvTabla.UseCompatibleStateImageBehavior = false;
			this.lvTabla.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "PRODUCTO";
			this.columnHeader1.Width = 93;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "PRECIO";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 93;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "CANTIDAD";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 139;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "TOTAL";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 126;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(12, 146);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(146, 24);
			this.btnEliminar.TabIndex = 42;
			this.btnEliminar.Text = "ELIMINAR PRODUCTO";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(12, 117);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(146, 24);
			this.btnAgregar.TabIndex = 41;
			this.btnAgregar.Text = "AGREGAR PRODUCTO";
			this.btnAgregar.UseVisualStyleBackColor = true;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(219, 120);
			this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(76, 20);
			this.txtTotal.TabIndex = 40;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(161, 123);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 19);
			this.label4.TabIndex = 39;
			this.label4.Text = "TOTAL:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(230, 94);
			this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(76, 20);
			this.txtCantidad.TabIndex = 38;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(159, 96);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 19);
			this.label3.TabIndex = 37;
			this.label3.Text = "CANTIDAD:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(69, 94);
			this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(76, 20);
			this.txtPrecio.TabIndex = 36;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 96);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 19);
			this.label2.TabIndex = 35;
			this.label2.Text = "PRECIO:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 59);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 19);
			this.label1.TabIndex = 34;
			this.label1.Text = "SELECCIONAR PRODUCTO:";
			// 
			// cbbDulce
			// 
			this.cbbDulce.FormattingEnabled = true;
			this.cbbDulce.Items.AddRange(new object[] {
									"Cheesecake",
									"Apple Pie",
									"Pastel de chocolate",
									"Red Velvet",
									"Tiramisú"});
			this.cbbDulce.Location = new System.Drawing.Point(181, 57);
			this.cbbDulce.Margin = new System.Windows.Forms.Padding(2);
			this.cbbDulce.Name = "cbbDulce";
			this.cbbDulce.Size = new System.Drawing.Size(126, 21);
			this.cbbDulce.TabIndex = 33;
			// 
			// rbtSalado
			// 
			this.rbtSalado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtSalado.Location = new System.Drawing.Point(80, 6);
			this.rbtSalado.Margin = new System.Windows.Forms.Padding(2);
			this.rbtSalado.Name = "rbtSalado";
			this.rbtSalado.Size = new System.Drawing.Size(123, 46);
			this.rbtSalado.TabIndex = 32;
			this.rbtSalado.TabStop = true;
			this.rbtSalado.Text = "Salado";
			this.rbtSalado.UseVisualStyleBackColor = true;
			// 
			// rbtDulce
			// 
			this.rbtDulce.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtDulce.Location = new System.Drawing.Point(12, 6);
			this.rbtDulce.Margin = new System.Windows.Forms.Padding(2);
			this.rbtDulce.Name = "rbtDulce";
			this.rbtDulce.Size = new System.Drawing.Size(123, 46);
			this.rbtDulce.TabIndex = 31;
			this.rbtDulce.TabStop = true;
			this.rbtDulce.Text = "Dulce";
			this.rbtDulce.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 477);
			this.Controls.Add(this.cbbSalado);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtPagado);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtNeto);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lvTabla);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbbDulce);
			this.Controls.Add(this.rbtSalado);
			this.Controls.Add(this.rbtDulce);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton rbtDulce;
		private System.Windows.Forms.RadioButton rbtSalado;
		private System.Windows.Forms.ComboBox cbbDulce;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvTabla;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNeto;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPagado;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cbbSalado;
	}
}
