namespace WPTimeTracking
{
    partial class ProyectoNuevo
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.tb_descrip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_observaciones = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Proyecto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(373, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 59);
            this.panel1.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripción";
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(210, 323);
            this.tb_titulo.MaximumSize = new System.Drawing.Size(250, 30);
            this.tb_titulo.MinimumSize = new System.Drawing.Size(250, 30);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(250, 22);
            this.tb_titulo.TabIndex = 7;
            // 
            // tb_descrip
            // 
            this.tb_descrip.Location = new System.Drawing.Point(709, 323);
            this.tb_descrip.MaximumSize = new System.Drawing.Size(250, 30);
            this.tb_descrip.MinimumSize = new System.Drawing.Size(250, 30);
            this.tb_descrip.Name = "tb_descrip";
            this.tb_descrip.Size = new System.Drawing.Size(250, 22);
            this.tb_descrip.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observaciones";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_observaciones
            // 
            this.tb_observaciones.Location = new System.Drawing.Point(243, 543);
            this.tb_observaciones.MaximumSize = new System.Drawing.Size(477, 200);
            this.tb_observaciones.MinimumSize = new System.Drawing.Size(477, 200);
            this.tb_observaciones.Multiline = true;
            this.tb_observaciones.Name = "tb_observaciones";
            this.tb_observaciones.Size = new System.Drawing.Size(477, 200);
            this.tb_observaciones.TabIndex = 11;
            // 
            // ProyectoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 768);
            this.Controls.Add(this.tb_observaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_descrip);
            this.Controls.Add(this.tb_titulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ProyectoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.TextBox tb_descrip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_observaciones;
    }
}