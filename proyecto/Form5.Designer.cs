/*
 * Creado por SharpDevelop.
 * Usuario: Gabriel
 * Fecha: 12/01/2026
 * Hora: 01:56 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyecto
{
	partial class Form5
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
			this.btnRegresar = new System.Windows.Forms.Button();
			this.lblJuan = new System.Windows.Forms.Label();
			this.lblJoxiel = new System.Windows.Forms.Label();
			this.lblMateo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(91, 267);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(93, 47);
			this.btnRegresar.TabIndex = 0;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// lblJuan
			// 
			this.lblJuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblJuan.Location = new System.Drawing.Point(22, 23);
			this.lblJuan.Name = "lblJuan";
			this.lblJuan.Size = new System.Drawing.Size(261, 23);
			this.lblJuan.TabIndex = 1;
			this.lblJuan.Text = "Juan Miguel Villagómez Estrada";
			// 
			// lblJoxiel
			// 
			this.lblJoxiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblJoxiel.Location = new System.Drawing.Point(22, 99);
			this.lblJoxiel.Name = "lblJoxiel";
			this.lblJoxiel.Size = new System.Drawing.Size(162, 23);
			this.lblJoxiel.TabIndex = 2;
			this.lblJoxiel.Text = "Joxiel Garcia Zavala";
			// 
			// lblMateo
			// 
			this.lblMateo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMateo.Location = new System.Drawing.Point(22, 163);
			this.lblMateo.Name = "lblMateo";
			this.lblMateo.Size = new System.Drawing.Size(223, 23);
			this.lblMateo.TabIndex = 3;
			this.lblMateo.Text = "Mateo Darinel Gonzales Soria";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(297, 56);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(194, 212);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 400);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblMateo);
			this.Controls.Add(this.lblJoxiel);
			this.Controls.Add(this.lblJuan);
			this.Controls.Add(this.btnRegresar);
			this.Name = "Form5";
			this.Text = "Form5";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblMateo;
		private System.Windows.Forms.Label lblJoxiel;
		private System.Windows.Forms.Label lblJuan;
		private System.Windows.Forms.Button btnRegresar;
	}
}
