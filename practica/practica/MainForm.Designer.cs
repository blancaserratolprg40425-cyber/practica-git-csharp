/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC47
 * Fecha: 27/10/2026
 * Hora: 07:52 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace practica
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnSumar = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(37, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ingrese los numeros:";
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(24, 35);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(61, 20);
			this.txtNum1.TabIndex = 1;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(100, 35);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(57, 20);
			this.txtNum2.TabIndex = 2;
			// 
			// btnRestar
			// 
			this.btnRestar.Location = new System.Drawing.Point(93, 73);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(75, 23);
			this.btnRestar.TabIndex = 3;
			this.btnRestar.Text = "restar";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnSumar
			// 
			this.btnSumar.Location = new System.Drawing.Point(12, 73);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(75, 23);
			this.btnSumar.TabIndex = 4;
			this.btnSumar.Text = "sumar";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(12, 111);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(75, 23);
			this.btnDividir.TabIndex = 5;
			this.btnDividir.Text = "dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Location = new System.Drawing.Point(93, 111);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
			this.btnMultiplicar.TabIndex = 6;
			this.btnMultiplicar.Text = "multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(37, 146);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(186, 178);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "practica";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.Label label1;
	}
}
