namespace WPTimeTracking
{
    partial class TareaEditar
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
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.ListBox();
            this.tareasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wPTTimeTrackingDataSet = new WPTimeTracking.WPTTimeTrackingDataSet();
            this.tb_observaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_descrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tareasTableAdapter = new WPTimeTracking.WPTTimeTrackingDataSetTableAdapters.tareasTableAdapter();
            this.testadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lb_tecnico = new System.Windows.Forms.ListBox();
            this.tecnicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lb_proyecto = new System.Windows.Forms.ListBox();
            this.proyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.t_estadosTableAdapter = new WPTimeTracking.WPTTimeTrackingDataSetTableAdapters.t_estadosTableAdapter();
            this.tecnicosTableAdapter = new WPTimeTracking.WPTTimeTrackingDataSetTableAdapters.tecnicosTableAdapter();
            this.proyectosTableAdapter = new WPTimeTracking.WPTTimeTrackingDataSetTableAdapters.proyectosTableAdapter();
            this.lb_estado = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPTTimeTrackingDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(233, 362);
            this.tb_titulo.MaximumSize = new System.Drawing.Size(250, 30);
            this.tb_titulo.MinimumSize = new System.Drawing.Size(250, 30);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(250, 22);
            this.tb_titulo.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 36);
            this.label4.TabIndex = 29;
            this.label4.Text = "Titulo";
            // 
            // lb_id
            // 
            this.lb_id.DataSource = this.tareasBindingSource;
            this.lb_id.DisplayMember = "titulo";
            this.lb_id.FormattingEnabled = true;
            this.lb_id.ItemHeight = 16;
            this.lb_id.Location = new System.Drawing.Point(411, 265);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(235, 36);
            this.lb_id.TabIndex = 28;
            this.lb_id.SelectedIndexChanged += new System.EventHandler(this.lb_id_SelectedIndexChanged);
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
            // tb_observaciones
            // 
            this.tb_observaciones.Location = new System.Drawing.Point(121, 562);
            this.tb_observaciones.MaximumSize = new System.Drawing.Size(377, 200);
            this.tb_observaciones.MinimumSize = new System.Drawing.Size(377, 200);
            this.tb_observaciones.Multiline = true;
            this.tb_observaciones.Name = "tb_observaciones";
            this.tb_observaciones.Size = new System.Drawing.Size(377, 200);
            this.tb_observaciones.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 36);
            this.label5.TabIndex = 26;
            this.label5.Text = "Observaciones";
            // 
            // tb_descrip
            // 
            this.tb_descrip.Location = new System.Drawing.Point(615, 562);
            this.tb_descrip.MaximumSize = new System.Drawing.Size(377, 200);
            this.tb_descrip.MinimumSize = new System.Drawing.Size(377, 200);
            this.tb_descrip.Multiline = true;
            this.tb_descrip.Name = "tb_descrip";
            this.tb_descrip.Size = new System.Drawing.Size(377, 200);
            this.tb_descrip.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(722, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "Selecciona Tarea";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(430, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 59);
            this.panel1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 71);
            this.label1.TabIndex = 21;
            this.label1.Text = "Editar Tareas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tareasTableAdapter
            // 
            this.tareasTableAdapter.ClearBeforeFill = true;
            // 
            // testadosBindingSource
            // 
            this.testadosBindingSource.DataMember = "t_estados";
            this.testadosBindingSource.DataSource = this.wPTTimeTrackingDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 36);
            this.label6.TabIndex = 31;
            this.label6.Text = "Estado";
            // 
            // lb_tecnico
            // 
            this.lb_tecnico.DataSource = this.tecnicosBindingSource;
            this.lb_tecnico.DisplayMember = "id";
            this.lb_tecnico.FormattingEnabled = true;
            this.lb_tecnico.ItemHeight = 16;
            this.lb_tecnico.Location = new System.Drawing.Point(755, 431);
            this.lb_tecnico.Name = "lb_tecnico";
            this.lb_tecnico.Size = new System.Drawing.Size(237, 36);
            this.lb_tecnico.TabIndex = 34;
            this.lb_tecnico.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // tecnicosBindingSource
            // 
            this.tecnicosBindingSource.DataMember = "tecnicos";
            this.tecnicosBindingSource.DataSource = this.wPTTimeTrackingDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(616, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 36);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tecnico";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb_proyecto
            // 
            this.lb_proyecto.DataSource = this.proyectosBindingSource;
            this.lb_proyecto.DisplayMember = "id";
            this.lb_proyecto.FormattingEnabled = true;
            this.lb_proyecto.ItemHeight = 16;
            this.lb_proyecto.Location = new System.Drawing.Point(755, 350);
            this.lb_proyecto.Name = "lb_proyecto";
            this.lb_proyecto.Size = new System.Drawing.Size(237, 36);
            this.lb_proyecto.TabIndex = 36;
            // 
            // proyectosBindingSource
            // 
            this.proyectosBindingSource.DataMember = "proyectos";
            this.proyectosBindingSource.DataSource = this.wPTTimeTrackingDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(616, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 36);
            this.label8.TabIndex = 35;
            this.label8.Text = "Proyecto";
            // 
            // t_estadosTableAdapter
            // 
            this.t_estadosTableAdapter.ClearBeforeFill = true;
            // 
            // tecnicosTableAdapter
            // 
            this.tecnicosTableAdapter.ClearBeforeFill = true;
            // 
            // proyectosTableAdapter
            // 
            this.proyectosTableAdapter.ClearBeforeFill = true;
            // 
            // lb_estado
            // 
            this.lb_estado.DataSource = this.testadosBindingSource;
            this.lb_estado.DisplayMember = "id";
            this.lb_estado.FormattingEnabled = true;
            this.lb_estado.ItemHeight = 16;
            this.lb_estado.Location = new System.Drawing.Point(233, 431);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(250, 36);
            this.lb_estado.TabIndex = 32;
            this.lb_estado.SelectedIndexChanged += new System.EventHandler(this.lb_estado_SelectedIndexChanged);
            // 
            // TareaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1142, 795);
            this.Controls.Add(this.lb_proyecto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_tecnico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_estado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_titulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_observaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_descrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TareaEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Tarea";
            this.Load += new System.EventHandler(this.TareaEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPTTimeTrackingDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_id;
        private System.Windows.Forms.TextBox tb_observaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_descrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private WPTTimeTrackingDataSet wPTTimeTrackingDataSet;
        private System.Windows.Forms.BindingSource tareasBindingSource;
        private WPTTimeTrackingDataSetTableAdapters.tareasTableAdapter tareasTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lb_tecnico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lb_proyecto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource testadosBindingSource;
        private WPTTimeTrackingDataSetTableAdapters.t_estadosTableAdapter t_estadosTableAdapter;
        private System.Windows.Forms.BindingSource tecnicosBindingSource;
        private WPTTimeTrackingDataSetTableAdapters.tecnicosTableAdapter tecnicosTableAdapter;
        private System.Windows.Forms.BindingSource proyectosBindingSource;
        private WPTTimeTrackingDataSetTableAdapters.proyectosTableAdapter proyectosTableAdapter;
        private System.Windows.Forms.ListBox lb_estado;
    }
}