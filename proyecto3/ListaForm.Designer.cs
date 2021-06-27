namespace proyecto3
{
	partial class ListaForm
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbPrograma = new System.Windows.Forms.ComboBox();
			this.cmbEstrato = new System.Windows.Forms.ComboBox();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtIdentificacion = new System.Windows.Forms.TextBox();
			this.tslAdd = new System.Windows.Forms.ToolStripLabel();
			this.tslDelete = new System.Windows.Forms.ToolStripLabel();
			this.tslConsult = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.cmbUniversidad = new System.Windows.Forms.ComboBox();
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
			this.label6.Location = new System.Drawing.Point(103, 306);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 13);
			this.label6.TabIndex = 56;
			this.label6.Text = "Fecha de registro";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(61, 330);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 55;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(298, 39);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(307, 252);
			this.dataGridView1.TabIndex = 54;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(106, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 50;
			this.label3.Text = "Edad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(103, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 49;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(106, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 48;
			this.label1.Text = "Identificación";
			// 
			// cmbPrograma
			// 
			this.cmbPrograma.FormattingEnabled = true;
			this.cmbPrograma.Items.AddRange(new object[] {
            "Ingenieria electrónica",
            "Ingenieria de sistemas",
            "Filosofia",
            "Economia",
            "Derecho",
            "Ingenieria civil"});
			this.cmbPrograma.Location = new System.Drawing.Point(106, 227);
			this.cmbPrograma.Name = "cmbPrograma";
			this.cmbPrograma.Size = new System.Drawing.Size(100, 21);
			this.cmbPrograma.TabIndex = 45;
			this.cmbPrograma.Text = "Programa";
			// 
			// cmbEstrato
			// 
			this.cmbEstrato.FormattingEnabled = true;
			this.cmbEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
			this.cmbEstrato.Location = new System.Drawing.Point(106, 177);
			this.cmbEstrato.Name = "cmbEstrato";
			this.cmbEstrato.Size = new System.Drawing.Size(100, 21);
			this.cmbEstrato.TabIndex = 43;
			this.cmbEstrato.Text = "Estrato";
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(106, 140);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(100, 20);
			this.txtEdad.TabIndex = 42;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(106, 93);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 41;
			this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
			// 
			// txtIdentificacion
			// 
			this.txtIdentificacion.Location = new System.Drawing.Point(106, 47);
			this.txtIdentificacion.Name = "txtIdentificacion";
			this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
			this.txtIdentificacion.TabIndex = 40;
			this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
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
			// tslConsult
			// 
			this.tslConsult.Name = "tslConsult";
			this.tslConsult.Size = new System.Drawing.Size(58, 22);
			this.tslConsult.Text = "Consultar";
			this.tslConsult.Click += new System.EventHandler(this.toolStripLabel1_Click);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(29, 22);
			this.toolStripLabel2.Text = "Salir";
			this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAdd,
            this.tslConsult,
            this.tslDelete,
            this.toolStripLabel2,
            this.toolStripLabel1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(700, 25);
			this.toolStrip1.TabIndex = 52;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// cmbUniversidad
			// 
			this.cmbUniversidad.FormattingEnabled = true;
			this.cmbUniversidad.Items.AddRange(new object[] {
            "Universidad Nacional de Colombia (UNAL)",
            "Universidad Nacional Abierta y a Distancia (UNAD)",
            "Universidad del Tolima (UT)",
            "Universidad Militar Nueva Granada (UMNG)",
            "Universidad del Quindío (UQ)",
            "Universidad Pedagógica y Tecnológica de Colombia (UPTC)",
            "Unidad Central del Valle de Cauca (UCEVA)",
            "Universidad Tecnológica del Chocó (UTCH)"});
			this.cmbUniversidad.Location = new System.Drawing.Point(106, 270);
			this.cmbUniversidad.Name = "cmbUniversidad";
			this.cmbUniversidad.Size = new System.Drawing.Size(100, 21);
			this.cmbUniversidad.TabIndex = 57;
			this.cmbUniversidad.Text = "Universidad";
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
			this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click_1);
			// 
			// ListaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 394);
			this.Controls.Add(this.cmbUniversidad);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbPrograma);
			this.Controls.Add(this.cmbEstrato);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtIdentificacion);
			this.Name = "ListaForm";
			this.Text = "ListaEstudiante";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbPrograma;
		private System.Windows.Forms.ComboBox cmbEstrato;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtIdentificacion;
		private System.Windows.Forms.ToolStripLabel tslAdd;
		private System.Windows.Forms.ToolStripLabel tslDelete;
		private System.Windows.Forms.ToolStripLabel tslConsult;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ComboBox cmbUniversidad;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
	}
}