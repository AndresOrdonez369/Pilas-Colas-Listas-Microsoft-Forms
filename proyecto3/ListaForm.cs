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
	public partial class ListaForm : Form
	{
		List<ListaEstudiante> listadata = new List<ListaEstudiante>();
		public ListaForm()
		{
			InitializeComponent();
			tslConsult.Enabled = false;
			tslDelete.Enabled = false;
		}

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{
			if (!ValidarIdentificacion()) return;
			ListaEstudiante mylista = GetIdentificacion(txtIdentificacion.Text);
			if (mylista == null)
			{
				errorProvider1.SetError(txtIdentificacion, "El estudiante no está registrado en la lista");
				LimpiarControles();
				txtIdentificacion.Focus();
				tslDelete.Enabled = false;
				return;
			}
			else
			{
				errorProvider1.SetError(txtIdentificacion, "");
				txtIdentificacion.Text = mylista.Identificacion.ToString();
				txtEdad.Text = mylista.Edad.ToString();
				cmbEstrato.SelectedItem = mylista.Estrato.ToString();
				cmbUniversidad.SelectedItem = mylista.Universidad.ToString();
				txtNombre.Text = mylista.Nombre;
				tslDelete.Enabled = true;

			}
		}

		private ListaEstudiante GetIdentificacion(string identificacion)
		{
			return listadata.Find(estudiante => estudiante.Identificacion.ToString().Contains(identificacion));
		}

		private void tslAdd_Click(object sender, EventArgs e)
		{
			if (!ValidarNombre()) return;
			if (!ValidarIdentificacion()) return;
			if (!ValidarEdad()) return;

			ListaEstudiante mylista = new ListaEstudiante();
			mylista.Identificacion = int.Parse(txtIdentificacion.Text);
			mylista.Nombre = txtNombre.Text;
			mylista.Estrato = int.Parse(cmbEstrato.Items[cmbEstrato.SelectedIndex].ToString());
			mylista.Programa = cmbPrograma.Items[cmbPrograma.SelectedIndex].ToString();
			mylista.Universidad = cmbUniversidad.Items[cmbUniversidad.SelectedIndex].ToString();
			mylista.Fecha = dateTimePicker1.Value.ToString();
			listadata.Add(mylista);
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = listadata.ToArray();
			LimpiarControles();
			txtIdentificacion.Focus();
			tslConsult.Enabled = true;

		}
		private bool ValidarNombre()
		{
			if (string.IsNullOrEmpty(txtNombre.Text))
			{
				errorProvider1.SetError(txtNombre, "Debe ingresar un valor");
				return false;
			}
			else
			{
				errorProvider1.SetError(txtNombre, "");
				return true;
			}
		}
		private bool ValidarIdentificacion()
		{
			if (string.IsNullOrEmpty(txtIdentificacion.Text))
			{
				errorProvider1.SetError(txtIdentificacion, "Debe ingresar un valor");
				return false;
			}
			else
			{
				errorProvider1.SetError(txtIdentificacion, "");
				return true;
			}
		}
		private bool ValidarEdad()
		{
			if (string.IsNullOrEmpty(txtEdad.Text))
			{
				errorProvider1.SetError(txtEdad, "Debe ingresar un valor");
				return false;
			}
			else
			{
				errorProvider1.SetError(txtEdad, "");
				return true;
			}
		}

		private void LimpiarControles()
		{
			txtEdad.Clear();
			txtIdentificacion.Clear();
			txtNombre.Clear();
		}

		private void tslDelete_Click(object sender, EventArgs e)
		{
			if (txtIdentificacion == null)
			{
				errorProvider1.SetError(txtIdentificacion, "Debe fijar la identificación del estudiante a eliminar");
				LimpiarControles();
				txtIdentificacion.Focus();
				tslDelete.Enabled = false;
				return;
			}
			else
			{
				errorProvider1.SetError(txtIdentificacion, "");
				DialogResult Respuesta = MessageBox.Show("¿Está seguro de eliminar el registro?",
					"Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1); ;
				if (Respuesta == DialogResult.Yes) 
				{
					foreach (ListaEstudiante mylista in listadata)
					{
						if (mylista.Identificacion == int.Parse(txtIdentificacion.Text))
						{
							listadata.Remove(mylista);
							break;
						}
					}
					LimpiarControles();
					dataGridView1.DataSource = null;
					dataGridView1.DataSource = listadata;
				}

			}
		}

		private void toolStripLabel2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void toolStripLabel1_Click_1(object sender, EventArgs e)
		{
			MainMenu myMenu = new MainMenu();
			myMenu.Show();
			this.Hide();
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
				errorProvider1.SetError(txtNombre, "No se admiten números");
			}
			else
				errorProvider1.Clear();
		}
	}
}
