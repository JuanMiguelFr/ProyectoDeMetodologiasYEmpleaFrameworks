/*
 * Creado por SharpDevelop.
 * Usuario: Gabriel
 * Fecha: 10/12/2025
 * Hora: 03:41 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		Form2 f2 = new Form2();
		Form3 f3 = new Form3();
		Form4 f4 = new Form4();
		Form5 f5 = new Form5();
		int banderaPerimetro = 0;
		int banderaConverciones = 0;
		int banderaArea = 0;
		int banderaAplicacion = 0;
		int banderaVolumen = 0;
		
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnConverciones.Visible=false;
		    this.pnArea.Visible=false;
		    this.pnPerimetro.Visible=false;
		    this.pnAplicacion.Visible=false;
		    this.pnVolumen.Visible=false;
		    this.f3.Visible=false;
		    this.f2.Visible=false;
		    this.IsMdiContainer = true;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void EmpleadoToolStripMenuItemClick(object sender, EventArgs e)
		{
          f3.MdiParent = this;
          f3.Show();
          this.f4.Visible=false;
          this.f3.Visible=true;
          this.f2.Visible=false;
          this.pnConverciones.Visible=false;
		  this.pnArea.Visible=false;
		  this.pnPerimetro.Visible=false;
		  this.pnAplicacion.Visible=false;
		  this.pnVolumen.Visible=false;
		}
		
		void PasteleriaToolStripMenuItemClick(object sender, EventArgs e)
		{
		  f2.MdiParent = this;
		  f2.Show();
		  this.f2.Visible=true;
		  this.f3.Visible=false;
		  this.f4.Visible=false;
		  this.pnConverciones.Visible=false;
		  this.pnArea.Visible=false;
		  this.pnPerimetro.Visible=false;
		  this.pnAplicacion.Visible=false;
		  this.pnVolumen.Visible=false;
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
		DialogResult result = MessageBox.Show("Seguro que deseas sali?", "Confirmacion",MessageBoxButtons.YesNo);
		if (result == DialogResult.Yes) Application.Exit();	
		}
		
		void ConvercionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.pnConverciones.Visible=true;
			this.pnArea.Visible=false;
			this.pnPerimetro.Visible=false;
			this.pnAplicacion.Visible=false;
			this.pnVolumen.Visible=false;
			this.f4.Visible=false;
			this.f3.Visible=false;
		    this.f2.Visible=false;
		}
		
		void AreaToolStripMenuItemClick(object sender, EventArgs e)
		{
		    this.pnArea.Visible=true;
			this.pnConverciones.Visible=false;
			this.pnPerimetro.Visible=false;
		    this.pnAplicacion.Visible=false;
		    this.pcbImagen.Visible=false;
		    this.pnVolumen.Visible=false;
            this.f3.Visible=false;
		    this.f2.Visible=false;		    
		}
		
		void ApicacionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.pnAplicacion.Visible=true;
			this.pnArea.Visible=false;
			this.pnPerimetro.Visible=false;
			this.pnConverciones.Visible=false;
			this.pnVolumen.Visible=false;
			this.f4.Visible=false;
			this.f3.Visible=false;
		    this.f2.Visible=false;
		}
		
		void PerimetroToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.pnPerimetro.Visible=true;
			this.pnArea.Visible=false;
			this.pnConverciones.Visible=false;
			this.pnAplicacion.Visible=false;
			this.pnVolumen.Visible=false;
			this.f4.Visible=false;
			this.f3.Visible=false;
		    this.f2.Visible=false;
		}
		void VolumenToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.pnConverciones.Visible=false;
		    this.pnArea.Visible=false;
		    this.pnPerimetro.Visible=false;
		    this.pnAplicacion.Visible=false;
		    this.pnVolumen.Visible=true;
		    this.f4.Visible=false;
		    this.f3.Visible=false;
		    this.f2.Visible=false;
		}
		void BoletaToolStripMenuItemClick(object sender, EventArgs e)
		{
			f4.MdiParent = this;
            f4.Show();
			this.f4.Visible=true;
			this.pnConverciones.Visible=false;
		    this.pnArea.Visible=false;
		    this.pnPerimetro.Visible=false;
		    this.pnAplicacion.Visible=false;
		    this.pnVolumen.Visible=false;
		    this.f3.Visible=false;
		    this.f2.Visible=false;
		}
		
		void LongitudToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaConverciones = 1;
		}
		
		void MasaToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaConverciones = 2;
		}
		
		void TemperaturaToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaConverciones = 3;
		}
		
		void TiempoToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaConverciones = 4;
		}
		
		void BtnConvertirClick(object sender, EventArgs e)
		{
			if(banderaConverciones==1){
				double KAM=1.60934;
				double v= Double.Parse(txtDigito1.Text);
				this.lblR.Text=this.lblR.Text+ (KAM * v)+" ";
			}
			if(banderaConverciones==2){
				double KAL=2.205;
				double v= Double.Parse(txtDigito1.Text);
				this.lblR.Text=this.lblR.Text+ (KAL * v)+" ";
			}
			if(banderaConverciones==3){
				double CAF=1.8;
				double v= Double.Parse(txtDigito1.Text);
				this.lblR.Text=this.lblR.Text+ (CAF * v)+ 32 +" ";
			}
		}
		
		void CuadradoToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaArea = 1;
		}
		
		void RectanguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaArea = 2;
		}
		
		void TrianguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaArea = 3;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
						if(banderaArea==1){
				double b, a, c;
				a= Double.Parse(txtAltura.Text);
				b= Double.Parse(txtBase.Text);
				c= a*b;
				this.txtResultado.Text=c+" ";
				this.pcbImagen.Visible=true;
				this.pcbImagen.Image= Image.FromFile(@"C:\Users\asus\OneDrive\Documents\SharpDevelop Projects\login.examen\login.examen\img\square.png");
			}
			if(banderaArea==2){
				double b, a, c;
				a= Double.Parse(txtAltura.Text);
				b= Double.Parse(txtBase.Text);
				c= a*b;
				this.txtResultado.Text=c+" ";
				this.pcbImagen.Visible=true;
				this.pcbImagen.Image= Image.FromFile(@"C:\Users\asus\OneDrive\Documents\SharpDevelop Projects\login.examen\login.examen\img\Rectangle.png");
			}
			if(banderaArea==3){
				double b, a, c;
				a= Double.Parse(txtAltura.Text);
				b= Double.Parse(txtBase.Text);
				c= a*b/2;
				this.txtResultado.Text=c+" ";
				this.pcbImagen.Visible=true;
				this.pcbImagen.Image= Image.FromFile(@"C:\Users\asus\OneDrive\Documents\SharpDevelop Projects\login.examen\login.examen\img\Triangle.png");
			}
		}
		
		void CircunferenciaToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaPerimetro = 1;
			lblLado1.Visible=false;
			lblLado2.Visible=false;
			lblLado3.Visible=false;
			lblLado4.Visible=false;
			txtLado1.Visible=false;
			txtLado2.Visible=false;
			txtLado3.Visible=false;
			txtLado4.Visible=false;
			lblDiametro.Visible=true;
			txtDiametro.Visible=true;
		}
		
		void TrapecioToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaPerimetro = 2;
			lblLado1.Visible=true;
			lblLado2.Visible=true;
			lblLado3.Visible=true;
			lblLado4.Visible=true;
			txtLado1.Visible=true;
			txtLado2.Visible=true;
			txtLado3.Visible=true;
			txtLado4.Visible=true;
			lblDiametro.Visible=false;
			txtDiametro.Visible=false;
		}
		
		void BtnPerimetroClick(object sender, EventArgs e)
		{
			if(banderaPerimetro == 1){
				double d, r;
				double pi = 3.1416;
				d = Double.Parse(txtDiametro.Text);
			    r = d*pi;
			    this.txtDiametroR.Text=r +" ";
		}
			if(banderaPerimetro == 2){
				double l1, l2, l3, l4, re;
				l1 = Double.Parse(txtLado1.Text);
				l2 = Double.Parse(txtLado2.Text);
				l3 = Double.Parse(txtLado3.Text);
				l4 = Double.Parse(txtLado4.Text);
			    re = l1+l2+l3+l4;
			    this.txtDiametroR.Text=re +" ";
		}
		}
		
		void FactoriaToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaAplicacion = 1;
		}
		
		void FibonnacionToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaAplicacion = 2;
		}
		
		void BtnAplicacionClick(object sender, EventArgs e)
		{
			if(banderaAplicacion == 1){
				int n2, b1=1;
				n2 = int.Parse(txtAplicacion.Text);
				for (int i = 1; i <= n2; i++) {
				b1= b1 * i;
				}
				this.txtAplicacionR.Text=b1 +" ";
			}
			if(banderaAplicacion == 2){
			    int n,x=0,y=1,z=2;
			    n=int.Parse(txtAplicacion.Text);;
                for(int i=1; i<=n; i++){
                x=y+z;
                this.txtAplicacionR.Text=x +" ";
                y=z;
                z=x;}
			}
		}
		void EsferaToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaVolumen = 1;
			lblEsfera.Visible=true;
			txtEsfera.Visible=true;
			ptbEsfera.Visible=true;
			lblCubo.Visible=false;
			txtCubo.Visible=false;
			ptbCubo.Visible=false;
			lblPiramide.Visible=false;
			lblAlturaPiramide.Visible=false;
			lblAreaBase.Visible=false;
			txtAlturaPiramide.Visible=false;
			txtAreaPiramide.Visible=false;
			ptbPiramide.Visible=false;
			txtResultadoVolumen.Clear();
		}
		
		void CuboToolStripMenuItemClick(object sender, EventArgs e)
		{
			banderaVolumen = 2;
			lblCubo.Visible=true;
			txtCubo.Visible=true;
			ptbCubo.Visible=true;
			lblEsfera.Visible=false;
			txtEsfera.Visible=false;
			ptbEsfera.Visible=false;
			lblPiramide.Visible=false;
			lblAlturaPiramide.Visible=false;
			lblAreaBase.Visible=false;
			txtAlturaPiramide.Visible=false;
			txtAreaPiramide.Visible=false;
			ptbPiramide.Visible=false;
			txtResultadoVolumen.Clear();
		}
		
		void PiramideToolStripMenuItem1Click(object sender, EventArgs e)
		{
			banderaVolumen = 3;
			lblPiramide.Visible=true;
			lblAlturaPiramide.Visible=true;
			lblAreaBase.Visible=true;
			txtAlturaPiramide.Visible=true;
			txtAreaPiramide.Visible=true;
			ptbPiramide.Visible=true;
			lblEsfera.Visible=false;
			txtEsfera.Visible=false;
			ptbEsfera.Visible=false;
			lblCubo.Visible=false;
			txtCubo.Visible=false;
			ptbCubo.Visible=false;
			txtResultadoVolumen.Clear();
		}
		void BtnCalcularVolumenClick(object sender, EventArgs e)
		{
			if(banderaVolumen==1){
				double Pi=3.1416;
				double v= Double.Parse(txtEsfera.Text);
				this.txtResultadoVolumen.Text=this.txtResultadoVolumen.Text+ (Pi * v * v * v)+" ";
			}
			if(banderaVolumen==2){
				double v= Double.Parse(txtCubo.Text);
				this.txtResultadoVolumen.Text=this.txtResultadoVolumen.Text+ (v * v * v)+" ";
			}	
			if(banderaVolumen==3){
				double Al=Double.Parse(txtAlturaPiramide.Text);
				double a= Double.Parse(txtAreaPiramide.Text);
				this.txtResultadoVolumen.Text=this.txtResultadoVolumen.Text+ (Al * a /3)+" ";
			}			
		}
		
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			f5.MdiParent = this;
         	f5.Show();
         	this.f5.Visible=true;
         	this.pnConverciones.Visible=false;
		    this.pnArea.Visible=false;
		    this.pnPerimetro.Visible=false;
		    this.pnAplicacion.Visible=false;
		    this.pnVolumen.Visible=false;
		    this.f4.Visible=false;
		    this.f3.Visible=false;
		    this.f2.Visible=false;
		}
	}
}
