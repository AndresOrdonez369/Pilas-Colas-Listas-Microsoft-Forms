namespace proyecto3
{
	partial class PilaForm
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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.txtReferencia = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtDir = new System.Windows.Forms.TextBox();
			this.cmbEstrato = new System.Windows.Forms.ComboBox();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.cmbMes = new System.Windows.Forms.ComboBox();
			this.txtConsumo = new System.Windows.Forms.TextBox();
			this.txtPagoConsumo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tslAdd = new System.Windows.Forms.ToolStripLabel();
			this.tslDelete = new System.Windows.Forms.ToolStripLabel();
			this.tslReporte = new System.Windows.Forms.ToolStripLabel();
			this.tslExit = new System.Windows.Forms.ToolStripLabel();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.contextMenuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem1.Text = "toolStripMenuItem1";
			// 
			// txtReferencia
			// 
			this.txtReferencia.Location = new System.Drawing.Point(102, 62);
			this.txtReferencia.Name = "txtReferencia";
			this.txtReferencia.Size = new System.Drawing.Size(100, 20);
			this.txtReferencia.TabIndex = 1;
			this.txtReferencia.TextChanged += new System.EventHandler(this.txtReferencia_TextChanged);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(102, 105);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
			// 
			// txtDir
			// 
			this.txtDir.Location = new System.Drawing.Point(102, 152);
			this.txtDir.Name = "txtDir";
			this.txtDir.Size = new System.Drawing.Size(100, 20);
			this.txtDir.TabIndex = 3;
			this.txtDir.TextChanged += new System.EventHandler(this.txtDir_TextChanged);
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
			this.cmbEstrato.Location = new System.Drawing.Point(102, 189);
			this.cmbEstrato.Name = "cmbEstrato";
			this.cmbEstrato.Size = new System.Drawing.Size(100, 21);
			this.cmbEstrato.TabIndex = 25;
			this.cmbEstrato.Text = "Estrato";
			this.cmbEstrato.SelectedIndexChanged += new System.EventHandler(this.cmbCargo_SelectedIndexChanged);
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Urbano"});
			this.cmbCategoria.Location = new System.Drawing.Point(102, 229);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(100, 21);
			this.cmbCategoria.TabIndex = 26;
			this.cmbCategoria.Text = "Categoria";
			// 
			// cmbMes
			// 
			this.cmbMes.FormattingEnabled = true;
			this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
			this.cmbMes.Location = new System.Drawing.Point(102, 271);
			this.cmbMes.Name = "cmbMes";
			this.cmbMes.Size = new System.Drawing.Size(100, 21);
			this.cmbMes.TabIndex = 27;
			this.cmbMes.Text = "Mes facturado";
			this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// txtConsumo
			// 
			this.txtConsumo.Location = new System.Drawing.Point(102, 321);
			this.txtConsumo.Name = "txtConsumo";
			this.txtConsumo.Size = new System.Drawing.Size(100, 20);
			this.txtConsumo.TabIndex = 28;
			this.txtConsumo.TextChanged += new System.EventHandler(this.txtConsumo_TextChanged);
			// 
			// txtPagoConsumo
			// 
			this.txtPagoConsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPagoConsumo.Enabled = false;
			this.txtPagoConsumo.Location = new System.Drawing.Point(387, 43);
			this.txtPagoConsumo.Name = "txtPagoConsumo";
			this.txtPagoConsumo.Size = new System.Drawing.Size(53, 20);
			this.txtPagoConsumo.TabIndex = 29;
			this.txtPagoConsumo.TextChanged += new System.EventHandler(this.textSalarioDia_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(102, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 30;
			this.label1.Text = "Referencia de pago";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(99, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 31;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(102, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 32;
			this.label3.Text = "Dirección";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(102, 305);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 13);
			this.label4.TabIndex = 33;
			this.label4.Text = "Consumo del mes (Kg)";
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
			this.toolStrip1.Size = new System.Drawing.Size(578, 25);
			this.toolStrip1.TabIndex = 35;
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
			this.tslDelete.Click += new System.EventHandler(this.toolStripLabel2_Click);
			// 
			// tslReporte
			// 
			this.tslReporte.Name = "tslReporte";
			this.tslReporte.Size = new System.Drawing.Size(48, 22);
			this.tslReporte.Text = "Reporte";
			this.tslReporte.Click += new System.EventHandler(this.toolStripLabel3_Click);
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(379, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 36;
			this.label5.Text = "Total a pagar:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(259, 89);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(307, 252);
			this.dataGridView1.TabIndex = 37;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(53, 366);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 38;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(99, 350);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 13);
			this.label6.TabIndex = 39;
			this.label6.Text = "Fecha de pago";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
			this.toolStripLabel1.Text = "Volver al menú";
			this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
			// 
			// PilaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 398);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPagoConsumo);
			this.Controls.Add(this.txtConsumo);
			this.Controls.Add(this.cmbMes);
			this.Controls.Add(this.cmbCategoria);
			this.Controls.Add(this.cmbEstrato);
			this.Controls.Add(this.txtDir);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtReferencia);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "PilaForm";
			this.Text = "PilaGas";
			this.Load += new System.EventHandler(this.PilaGas_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.TextBox txtReferencia;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtDir;
		private System.Windows.Forms.ComboBox cmbEstrato;
		private System.Windows.Forms.ComboBox cmbCategoria;
		private System.Windows.Forms.ComboBox cmbMes;
		private System.Windows.Forms.TextBox txtConsumo;
		private System.Windows.Forms.TextBox txtPagoConsumo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel tslAdd;
		private System.Windows.Forms.ToolStripLabel tslDelete;
		private System.Windows.Forms.ToolStripLabel tslReporte;
		private System.Windows.Forms.ToolStripLabel tslExit;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
	}
}