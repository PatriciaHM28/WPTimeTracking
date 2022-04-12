namespace WPTimeTracking
{
    partial class Tareas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtecnicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wPTTimeTrackingDataSet = new WPTimeTracking.WPTTimeTrackingDataSet();
            this.tareasTableAdapter = new WPTimeTracking.WPTTimeTrackingDataSetTableAdapters.tareasTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPTTimeTrackingDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tareas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.eliminar);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.nuevo);
            this.panel1.Location = new System.Drawing.Point(314, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 59);
            this.panel1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(218, 10);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 40);
            this.eliminar.TabIndex = 2;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(114, 10);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 40);
            this.editar.TabIndex = 1;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(12, 10);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 40);
            this.nuevo.TabIndex = 0;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.fechacreacionDataGridViewTextBoxColumn,
            this.idestadoDataGridViewTextBoxColumn,
            this.idtecnicoDataGridViewTextBoxColumn,
            this.idproyectoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tareasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechacreacionDataGridViewTextBoxColumn
            // 
            this.fechacreacionDataGridViewTextBoxColumn.DataPropertyName = "fecha_creacion";
            this.fechacreacionDataGridViewTextBoxColumn.HeaderText = "fecha_creacion";
            this.fechacreacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechacreacionDataGridViewTextBoxColumn.Name = "fechacreacionDataGridViewTextBoxColumn";
            this.fechacreacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // idestadoDataGridViewTextBoxColumn
            // 
            this.idestadoDataGridViewTextBoxColumn.DataPropertyName = "id_estado";
            this.idestadoDataGridViewTextBoxColumn.HeaderText = "id_estado";
            this.idestadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idestadoDataGridViewTextBoxColumn.Name = "idestadoDataGridViewTextBoxColumn";
            this.idestadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idtecnicoDataGridViewTextBoxColumn
            // 
            this.idtecnicoDataGridViewTextBoxColumn.DataPropertyName = "id_tecnico";
            this.idtecnicoDataGridViewTextBoxColumn.HeaderText = "id_tecnico";
            this.idtecnicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtecnicoDataGridViewTextBoxColumn.Name = "idtecnicoDataGridViewTextBoxColumn";
            this.idtecnicoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idproyectoDataGridViewTextBoxColumn
            // 
            this.idproyectoDataGridViewTextBoxColumn.DataPropertyName = "id_proyecto";
            this.idproyectoDataGridViewTextBoxColumn.HeaderText = "id_proyecto";
            this.idproyectoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproyectoDataGridViewTextBoxColumn.Name = "idproyectoDataGridViewTextBoxColumn";
            this.idproyectoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tareasBindingSource
            // 
            this.tareasBindingSource.DataMember = "tareas";
            this.tareasBindingSource.DataSource = this.wPTTimeTrackingDataSet;
            // 
            // wPTTimeTrackingDataSet
            // 
            this.wPTTimeTrackingDataSet.DataSetName = "WPTTimeTrackingDataSet";
            this.wPTTimeTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tareasTableAdapter
            // 
            this.tareasTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(314, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 59);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(334, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(258, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "";
            this.textBox1.Location = new System.Drawing.Point(25, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Image = global::WPTimeTracking.Properties.Resources.png_clipart_menu_icon_icons_logo;
            this.button3.Location = new System.Drawing.Point(24, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 55);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1109, 563);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Tareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.Tareas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPTTimeTrackingDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WPTTimeTrackingDataSet wPTTimeTrackingDataSet;
        private System.Windows.Forms.BindingSource tareasBindingSource;
        private WPTTimeTrackingDataSetTableAdapters.tareasTableAdapter tareasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtecnicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}