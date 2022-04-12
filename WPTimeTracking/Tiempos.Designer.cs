namespace WPTimeTracking
{
    partial class Tiempos
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaactualizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiemposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wPTTimeTrackingDataSet = new WPTimeTracking.WPTTimeTrackingDataSet();
            this.tiemposTableAdapter = new WPTimeTracking.WPTTimeTrackingDataSetTableAdapters.tiemposTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPTTimeTrackingDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 71);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiempos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(370, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 71);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar Tiempo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idtareaDataGridViewTextBoxColumn,
            this.fechaactualizacionDataGridViewTextBoxColumn,
            this.fechainicioDataGridViewTextBoxColumn,
            this.fechafinDataGridViewTextBoxColumn,
            this.minutosDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tiemposBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(962, 150);
            this.dataGridView1.TabIndex = 6;
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
            // idtareaDataGridViewTextBoxColumn
            // 
            this.idtareaDataGridViewTextBoxColumn.DataPropertyName = "id_tarea";
            this.idtareaDataGridViewTextBoxColumn.HeaderText = "id_tarea";
            this.idtareaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtareaDataGridViewTextBoxColumn.Name = "idtareaDataGridViewTextBoxColumn";
            this.idtareaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtareaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaactualizacionDataGridViewTextBoxColumn
            // 
            this.fechaactualizacionDataGridViewTextBoxColumn.DataPropertyName = "fecha_actualizacion";
            this.fechaactualizacionDataGridViewTextBoxColumn.HeaderText = "fecha_actualizacion";
            this.fechaactualizacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaactualizacionDataGridViewTextBoxColumn.Name = "fechaactualizacionDataGridViewTextBoxColumn";
            this.fechaactualizacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaactualizacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechainicioDataGridViewTextBoxColumn
            // 
            this.fechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.HeaderText = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechainicioDataGridViewTextBoxColumn.Name = "fechainicioDataGridViewTextBoxColumn";
            this.fechainicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechainicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechafinDataGridViewTextBoxColumn
            // 
            this.fechafinDataGridViewTextBoxColumn.DataPropertyName = "fecha_fin";
            this.fechafinDataGridViewTextBoxColumn.HeaderText = "fecha_fin";
            this.fechafinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechafinDataGridViewTextBoxColumn.Name = "fechafinDataGridViewTextBoxColumn";
            this.fechafinDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechafinDataGridViewTextBoxColumn.Width = 125;
            // 
            // minutosDataGridViewTextBoxColumn
            // 
            this.minutosDataGridViewTextBoxColumn.DataPropertyName = "minutos";
            this.minutosDataGridViewTextBoxColumn.HeaderText = "minutos";
            this.minutosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minutosDataGridViewTextBoxColumn.Name = "minutosDataGridViewTextBoxColumn";
            this.minutosDataGridViewTextBoxColumn.ReadOnly = true;
            this.minutosDataGridViewTextBoxColumn.Width = 125;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacionesDataGridViewTextBoxColumn.Width = 125;
            // 
            // tiemposBindingSource
            // 
            this.tiemposBindingSource.DataMember = "tiempos";
            this.tiemposBindingSource.DataSource = this.wPTTimeTrackingDataSet;
            // 
            // wPTTimeTrackingDataSet
            // 
            this.wPTTimeTrackingDataSet.DataSetName = "WPTTimeTrackingDataSet";
            this.wPTTimeTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiemposTableAdapter
            // 
            this.tiemposTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(265, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 59);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.Image = global::WPTimeTracking.Properties.Resources.png_clipart_menu_icon_icons_logo;
            this.button5.Location = new System.Drawing.Point(27, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 55);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Tiempos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 614);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Tiempos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiempos";
            this.Load += new System.EventHandler(this.Tiempos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPTTimeTrackingDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WPTTimeTrackingDataSet wPTTimeTrackingDataSet;
        private System.Windows.Forms.BindingSource tiemposBindingSource;
        private WPTTimeTrackingDataSetTableAdapters.tiemposTableAdapter tiemposTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaactualizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
    }
}