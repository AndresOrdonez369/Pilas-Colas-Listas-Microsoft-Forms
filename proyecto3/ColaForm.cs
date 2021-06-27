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
	public partial class ColaForm : Form
	{
		 Queue<ColaTransmetro> colaData = new Queue<ColaTransmetro>();
		public ColaForm()
		{
			InitializeComponent();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void tslAdd_Click(object sender, EventArgs e)
		{
			if (!ValidarCodigoRuta()) return;
			if(!ValidarNumeroBus()) return;

			ColaTransmetro mycola = new ColaTransmetro();
			mycola.CodigoRuta = int.Parse(txtRuta.Text);
			mycola.NumeroBus = int.Parse(txtNumeroBus.Text);
			mycola.Identificacion = int.Parse(txtIdentificacion.Text);
			mycola.Nombre = txtNombreCliente.Text;
			mycola.Fecha = dtp1.Value.ToString();
			mycola.NombreRuta = cmbRuta.Items[cmbRuta.SelectedIndex].ToString();
			colaData.Enqueue(mycola);
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = colaData.ToArray();
			LimpiarControles();
			txtRuta.Focus();
		}
		private bool ValidarCodigoRuta()
		{
			if (string.IsNullOrEmpty(txtRuta.Text))
			{
				errorProvider1.SetError(txtRuta, "Debe ingresar un valor");
				return false;
			}
			else
			{
				errorProvider1.SetError(txtRuta, "");
				return true;
			}

		}
		private bool ValidarNumeroBus()
		{
			if (string.IsNullOrEmpty(txtNumeroBus.Text))
			{
				errorProvider1.SetError(txtNumeroBus, "Debe ingresar un valor");
				return false;
			}
			else
			{
				errorProvider1.SetError(txtNumeroBus, "");
				return true;
			}

		}

		private void LimpiarControles()
		{
			txtIdentificacion.Clear();
			txtNombreCliente.Clear();
			txtNumeroBus.Clear();
			txtRuta.Clear();
		}

		private void txtRuta_TextChanged(object sender, EventArgs e)
		{
			{
				bool error = false;
				foreach (char caracter in txtRuta.Text)
				{
					if (char.IsLetter(caracter))
					{
						error = true;
						break;
					}
				}
				if (error)
				{
					errorProvider1.SetError(txtRuta, "No se admiten letras");
				}
				else
					errorProvider1.Clear();
			}
		}

		private void tslDelete_Click(object sender, EventArgs e)
		{
			if (colaData.Count != 0)
			{
				ColaTransmetro mycola = new ColaTransmetro();
				if (MessageBox.Show("Desea eliminar el registro de la Cola", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{

					mycola = colaData.Dequeue();
					dataGridView1.DataSource = colaData.ToArray();
					MessageBox.Show("Se elimino el registro en Cola");
				}
			}
			else
			{
				MessageBox.Show("No hay registros en la cola");
			}
			LimpiarControles();
			txtRuta.Focus();
		}

		private void tslReporte_Click(object sender, EventArgs e)
		{
			MessageBox.Show("El número de registros ingresado es: "+ colaData.Count().ToString());
	
		}

		private void txtNumeroBus_TextChanged(object sender, EventArgs e)
		{
			{
				bool error = false;
				foreach (char caracter in txtNumeroBus.Text)
				{
					if (char.IsLetter(caracter))
					{
						error = true;
						break;
					}
				}
				if (error)
				{
					errorProvider1.SetError(txtNumeroBus, "No se admiten letras");
				}
				else
					errorProvider1.Clear();
			}
		}

		private void txtIdentificacion_TextChanged(object sender, EventArgs e)
		{
			{
				bool error = false;
				foreach (char caracter in txtIdentificacion.Text)
				{
					if (char.IsLetter(caracter))
					{
						error = true;
						break;
					}
				}
				if (error)
				{
					errorProvider1.SetError(txtIdentificacion, "No se admiten letras");
				}
				else
					errorProvider1.Clear();
			}
		}

		private void tslExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{
			MainMenu myMenu = new MainMenu();
			myMenu.Show();
			this.Hide();
		}
	}
}
