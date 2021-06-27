namespace proyecto3
{
	partial class ColaForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label6 = new System.Windows.Forms.Label();
			this.dtp1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbRuta = new System.Windows.Forms.ComboBox();
			this.txtIdentificacion = new System.Windows.Forms.TextBox();
			this.txtNumeroBus = new System.Windows.Forms.TextBox();
			this.txtRuta = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tslAdd = new System.Windows.Forms.ToolStripLabel();
			this.tslDelete = new System.Windows.Forms.ToolStripLabel();
			this.tslReporte = new System.Windows.Forms.ToolStripLabel();
			this.tslExit = new System.Windows.Forms.ToolStripLabel();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(72, 288);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 56;
			this.label6.Text = "Fecha ruta";
			// 
			// dtp1
			// 
			this.dtp1.Location = new System.Drawing.Point(12, 319);
			this.dtp1.Name = "dtp1";
			this.dtp1.Size = new System.Drawing.Size(200, 20);
			this.dtp1.TabIndex = 55;
			this.dtp1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(315, 49);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(307, 252);
			this.dataGridView1.TabIndex = 54;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(69, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 50;
			this.label3.Text = "Identificacion";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(66, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 49;
			this.label2.Text = "Número del bus";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 48;
			this.label1.Text = "Codigo de la ruta";
			// 
			// cmbRuta
			// 
			this.cmbRuta.FormattingEnabled = true;
			this.cmbRuta.Items.AddRange(new object[] {
            "Usaquén",
            "Suba",
            "Teusaquillo",
            "Fontibón",
            "Kennedy"});
			this.cmbRuta.Location = new System.Drawing.Point(75, 244);
			this.cmbRuta.Name = "cmbRuta";
			this.cmbRuta.Size = new System.Drawing.Size(100, 21);
			this.cmbRuta.TabIndex = 43;
			this.cmbRuta.Text = "Ruta";
			// 
			// txtIdentificacion
			// 
			this.txtIdentificacion.Location = new System.Drawing.Point(69, 152);
			this.txtIdentificacion.Name = "txtIdentificacion";
			this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
			this.txtIdentificacion.TabIndex = 42;
			this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
			// 
			// txtNumeroBus
			// 
			this.txtNumeroBus.Location = new System.Drawing.Point(69, 105);
			this.txtNumeroBus.Name = "txtNumeroBus";
			this.txtNumeroBus.Size = new System.Drawing.Size(100, 20);
			this.txtNumeroBus.TabIndex = 41;
			this.txtNumeroBus.TextChanged += new System.EventHandler(this.txtNumeroBus_TextChanged);
			// 
			// txtRuta
			// 
			this.txtRuta.Location = new System.Drawing.Point(69, 62);
			this.txtRuta.Name = "txtRuta";
			this.txtRuta.Size = new System.Drawing.Size(100, 20);
			this.txtRuta.TabIndex = 40;
			this.txtRuta.TextChanged += new System.EventHandler(this.txtRuta_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(72, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 13);
			this.label7.TabIndex = 58;
			this.label7.Text = "Nombre del cliente";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// txtNombreCliente
			// 
			this.txtNombreCliente.Location = new System.Drawing.Point(72, 208);
			this.txtNombreCliente.Name = "txtNombreCliente";
			this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
			this.txtNombreCliente.TabIndex = 57;
			this.txtNombreCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAdd,
            this.tslDelete,
            this.tslReporte,
            this.tslExit,
            this.toolStripLabel1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 61;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tslAdd
			// 
			this.tslAdd.Name = "tslAdd";
			this.tslAdd.Size = new System.Drawing.Size(53, 22);
			this.tslAdd.Text = "Registrar";
			this.tslAdd.Click += new System.EventHandler(this.tslAdd_Click);
			// 
			// tslDelete
			// 
			this.tslDelete.Name = "tslDelete";
			this.tslDelete.Size = new System.Drawing.Size(50, 22);
			this.tslDelete.Text = "Eliminar";
			this.tslDelete.Click += new System.EventHandler(this.tslDelete_Click);
			// 
			// tslReporte
			// 
			this.tslReporte.Name = "tslReporte";
			this.tslReporte.Size = new System.Drawing.Size(48, 22);
			this.tslReporte.Text = "Reporte";
			this.tslReporte.Click += new System.EventHandler(this.tslReporte_Click);
			// 
			// tslExit
			// 
			this.tslExit.Name = "tslExit";
			this.tslExit.Size = new System.Drawing.Size(29, 22);
			this.tslExit.Text = "Salir";
			this.tslExit.Click += new System.EventHandler(this.tslExit_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
			this.toolStripLabel1.Text = "Volver al menú";
			this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
			// 
			// ColaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtNombreCliente);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dtp1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbRuta);
			this.Controls.Add(this.txtIdentificacion);
			this.Controls.Add(this.txtNumeroBus);
			this.Controls.Add(this.txtRuta);
			this.Name = "ColaForm";
			this.Text = "ColaTransmetro";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtp1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbRuta;
		private System.Windows.Forms.TextBox txtIdentificacion;
		private System.Windows.Forms.TextBox txtNumeroBus;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNombreCliente;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel tslAdd;
		private System.Windows.Forms.ToolStripLabel tslDelete;
		private System.Windows.Forms.ToolStripLabel tslReporte;
		private System.Windows.Forms.ToolStripLabel tslExit;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
	}
}