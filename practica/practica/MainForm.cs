/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC47
 * Fecha: 27/10/2026
 * Hora: 07:52 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica
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
		
		void BtnSumarClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txtNum1.Text);
			double n2 = double.Parse(txtNum2.Text);
			double resultado = n1 + n2;
			lblResultado.Text = resultado.ToString();
		}
		
		void BtnRestarClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txtNum1.Text);
			double n2 = double.Parse(txtNum2.Text);
			double resultado = n1 - n2;
			lblResultado.Text = resultado.ToString();
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txtNum1.Text);
			double n2 = double.Parse(txtNum2.Text);
			double resultado = n1 / n2;
			lblResultado.Text = resultado.ToString();
		}
		
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txtNum1.Text);
			double n2 = double.Parse(txtNum2.Text);
			double resultado = n1 / n2;
			lblResultado.Text = resultado.ToString();
		}
	}
}
