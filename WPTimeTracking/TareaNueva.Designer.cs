namespace WPTimeTracking
{
    partial class TareaNueva
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
            this.tb_observaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_descrip = new System.Windows.Forms.TextBox();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_proyecto = new System.Windows.Forms.ListBox();
            this.wPTTimeTrackingDataSet = new WPTimeTracking.WPTTimeTrackingDataSet();
            this.proyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosTableAdapter = new WPTimeTracking.WPTTimeTrackingDataSetTableAdapters.proyectosTableAdapter();
            this.lb_estado = new System.Windows.Forms.ListBox();
            this.testadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_estadosTableAdapter = new WPTimeTracking.WPTTimeTrackingDataSetTableAdapters.t_estadosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wPTTimeTrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 71);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarea Nueva";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(388, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 59);
            this.panel1.TabIndex = 4;
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
            // tb_observaciones
            // 
            this.tb_observaciones.Location = new System.Drawing.Point(282, 521);
            this.tb_observaciones.MaximumSize = new System.Drawing.Size(477, 200);
            this.tb_observaciones.MinimumSize = new System.Drawing.Size(477, 200);
            this.tb_observaciones.Multiline = true;
            this.tb_observaciones.Name = "tb_observaciones";
            this.tb_observaciones.Size = new System.Drawing.Size(477, 200);
            this.tb_observaciones.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 36);
            this.label5.TabIndex = 16;
            this.label5.Text = "Observaciones";
            // 
            // tb_descrip
            // 
            this.tb_descrip.Location = new System.Drawing.Point(697, 302);
            this.tb_descrip.MaximumSize = new System.Drawing.Size(250, 30);
            this.tb_descrip.MinimumSize = new System.Drawing.Size(250, 30);
            this.tb_descrip.Name = "tb_descrip";
            this.tb_descrip.Size = new System.Drawing.Size(250, 30);
            this.tb_descrip.TabIndex = 15;
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(198, 302);
            this.tb_titulo.MaximumSize = new System.Drawing.Size(250, 30);
            this.tb_titulo.MinimumSize = new System.Drawing.Size(250, 30);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(250, 30);
            this.tb_titulo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Título";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 45);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID_Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(495, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 45);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID_Proyecto";
            // 
            // lb_proyecto
            // 
            this.lb_proyecto.DataSource = this.proyectosBindingSource;
            this.lb_proyecto.DisplayMember = "id";
            this.lb_proyecto.FormattingEnabled = true;
            this.lb_proyecto.ItemHeight = 16;
            this.lb_proyecto.Location = new System.Drawing.Point(725, 397);
            this.lb_proyecto.Name = "lb_proyecto";
            this.lb_proyecto.Size = new System.Drawing.Size(231, 36);
            this.lb_proyecto.TabIndex = 20;
            // 
            // wPTTimeTrackingDataSet
            // 
            this.wPTTimeTrackingDataSet.DataSetName = "WPTTimeTrackingDataSet";
            this.wPTTimeTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectosBindingSource
            // 
            this.proyectosBindingSource.DataMember = "proyectos";
            this.proyectosBindingSource.DataSource = this.wPTTimeTrackingDataSet;
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
            this.lb_estado.Location = new System.Drawing.Point(231, 397);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(231, 36);
            this.lb_estado.TabIndex = 21;
            // 
            // testadosBindingSource
            // 
            this.testadosBindingSource.DataMember = "t_estados";
            this.testadosBindingSource.DataSource = this.wPTTimeTrackingDataSet;
            // 
            // t_estadosTableAdapter
            // 
            this.t_estadosTableAdapter.ClearBeforeFill = true;
            // 
            // TareaNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1046, 777);
            this.Controls.Add(this.lb_estado);
            this.Controls.Add(this.lb_proyecto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_observaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_descrip);
            this.Controls.Add(this.tb_titulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TareaNueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea Nueva";
            this.Load += new System.EventHandler(this.TareaNueva_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wPTTimeTrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_observaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_descrip;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lb_proyecto;
        private WPTTimeTrackingDataSet wPTTimeTrackingDataSet;
        private System.Windows.Forms.BindingSource proyectosBindingSource;
        private WPTTimeTrackingDataSetTableAdapters.proyectosTableAdapter proyectosTableAdapter;
        private System.Windows.Forms.ListBox lb_estado;
        private System.Windows.Forms.BindingSource testadosBindingSource;
        private WPTTimeTrackingDataSetTableAdapters.t_estadosTableAdapter t_estadosTableAdapter;
    }
}