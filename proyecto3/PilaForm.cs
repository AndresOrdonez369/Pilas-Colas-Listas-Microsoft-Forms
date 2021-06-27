using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{

	public partial class PilaForm : Form

	{
		public int[] coleccion;
		Stack <PilaGas> pilaData = new Stack<PilaGas>();
		
		public PilaForm()
		{
			InitializeComponent();
		}

		private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void PilaGas_Load(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void toolStripLabel2_Click(object sender, EventArgs e)
		{
			if (pilaData.Count != 0)
			{
				PilaGas mypila = new PilaGas();
				if (MessageBox.Show("Desea eliminar el registro de la pila", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					
					mypila = pilaData.Pop();	
					dataGridView1.DataSource = pilaData.ToArray();
					MessageBox.Show("Se elimino el registro en Pila");
				}
			}
			else {
				MessageBox.Show("No hay registros en la píla");
			}
			LimpiarControles();
			txtReferencia.Focus();
		}

		private void toolStripLabel3_Click(object sender, EventArgs e)
		{
			int total = dataGridView1.Rows.Cast<DataGridViewRow>()
				.Sum(t => Convert.ToInt32(t.Cells[7].Value));
			MessageBox.Show("El total de valor recaudado es : " + total);
		}

		private void txtNombre_TextChanged(object sender, EventArgs e)
		{

			bool error = false;
			foreach (char caracter in txtNombre.Text)
			{
				if (char.IsDigit(caracter))
				{
					error = true;
					break;
				}
			}
			if (error)
			{
				errorProvider1.SetError(txtNombre, "No se admiten numeros");
			}
			else
				errorProvider1.Clear();
		}
		private void LimpiarControles()
		{
			txtReferencia.Clear();
			txtNombre.Clear();
			txtDir.Clear();
			txtConsumo.Clear();
			
		}

		private void tslAdd_Click(object sender, EventArgs e)
		{
			if (!ValidarReferencia()) return;
			if (!ValidarNombre()) return;
			if (!ValidarDireccion()) return;
			PilaGas mypila = new PilaGas();
			mypila.referencia = int.Parse(txtReferencia.Text);
			mypila.nombre = txtNombre.Text;
			mypila.direccion = txtDir.Text;
			mypila.estrato = int.Parse(cmbEstrato.Items[cmbEstrato.SelectedIndex].ToString());
			mypila.categoria = cmbCategoria.Items[cmbCategoria.SelectedIndex].ToString();
			mypila.mes = cmbMes.Items[cmbMes.SelectedIndex].ToString();
			mypila.consumo = int.Parse(txtConsumo.Text);
			mypila.fecha = dateTimePicker1.Value.ToString();
			txtPagoConsumo.Text = mypila.CalcularPago(mypila.consumo).ToString();
			Console.WriteLine(mypila.pago);
			pilaData.Push(mypila);
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = pilaData.ToArray();
			LimpiarControles();
			txtReferencia.Focus();
		}

		
		private bool ValidarDireccion()
		{
			if (string.IsNullOrEmpty(txtDir.Text))
			{
				errorProvider1.SetError(txtDir, "Debe ingresar un valor");
				return false;
			}
			else
			{
				errorProvider1.SetError(txtDir, "");
				return true;
			}

		}
		private bool ValidarReferencia()
		{
			if (string.IsNullOrEmpty(txtReferencia.Text))
			{
				errorProvider1.SetError(txtReferencia, "Debe ingresar un valor");
				return false;
			}
			else
			{
				errorProvider1.SetError(txtReferencia, "");
				return true;
			}

		}
		private bool ValidarNombre()
		{
			if (string.IsNullOrEmpty(txtNombre.Text))
			{
				errorProvider1.SetError(txtNombre, "Debe ingresar un valor");
				return false;
			}
			else {
				errorProvider1.SetError(txtNombre, "");
				return true;
			}
			
		}

		private void txtReferencia_TextChanged(object sender, EventArgs e)
		{ bool error = false;
			foreach (char caracter in txtReferencia.Text)
			{
				if (char.IsLetter(caracter))
				{
					error = true;
					break;
				}
			}
				if (error)
				{
					errorProvider1.SetError(txtReferencia, "No se admiten letras");
				}
				else
					errorProvider1.Clear();
			}

		private void textSalarioDia_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtConsumo_TextChanged(object sender, EventArgs e)
		{
		}

		private void tslExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void txtDir_TextChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{
			MainMenu myMenu = new MainMenu();
			myMenu.Show();
			this.Hide();
		}
	}
}

