namespace WPTimeTracking
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_contrasena = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rjBotones1 = new WPTimeTracking.Resources.RJBotones();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AccessibleName = "labelUsuario";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "labelContrasena";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.label2.Location = new System.Drawing.Point(86, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_contrasena
            // 
            this.tb_contrasena.AcceptsTab = true;
            this.tb_contrasena.AccessibleName = "tb_contrasena";
            this.tb_contrasena.BackColor = System.Drawing.Color.White;
            this.tb_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contrasena.ForeColor = System.Drawing.Color.Black;
            this.tb_contrasena.Location = new System.Drawing.Point(89, 481);
            this.tb_contrasena.MaximumSize = new System.Drawing.Size(312, 30);
            this.tb_contrasena.MaxLength = 15;
            this.tb_contrasena.MinimumSize = new System.Drawing.Size(312, 30);
            this.tb_contrasena.Name = "tb_contrasena";
            this.tb_contrasena.Size = new System.Drawing.Size(312, 34);
            this.tb_contrasena.TabIndex = 2;
            this.tb_contrasena.Text = "1234";
            this.tb_contrasena.TextChanged += new System.EventHandler(this.tb_contrasena_TextChanged);
            // 
            // tb_usuario
            // 
            this.tb_usuario.AcceptsTab = true;
            this.tb_usuario.AccessibleName = "tb_usuario";
            this.tb_usuario.BackColor = System.Drawing.Color.White;
            this.tb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usuario.ForeColor = System.Drawing.Color.Black;
            this.tb_usuario.Location = new System.Drawing.Point(89, 351);
            this.tb_usuario.MaximumSize = new System.Drawing.Size(312, 30);
            this.tb_usuario.MinimumSize = new System.Drawing.Size(312, 30);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(312, 34);
            this.tb_usuario.TabIndex = 1;
            this.tb_usuario.Text = "master";
            this.tb_usuario.TextChanged += new System.EventHandler(this.tb_usuario_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WPTimeTracking.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(142, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(188, 188);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AccessibleName = "labelTitulo";
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(223)))));
            this.label3.Location = new System.Drawing.Point(81, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "WPTimeTracking";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rjBotones1
            // 
            this.rjBotones1.AccessibleDescription = "";
            this.rjBotones1.AccessibleName = "";
            this.rjBotones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(223)))));
            this.rjBotones1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(223)))));
            this.rjBotones1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(223)))));
            this.rjBotones1.BorderRadius = 20;
            this.rjBotones1.BorderSize = 0;
            this.rjBotones1.FlatAppearance.BorderSize = 0;
            this.rjBotones1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjBotones1.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjBotones1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.rjBotones1.Location = new System.Drawing.Point(142, 607);
            this.rjBotones1.Name = "rjBotones1";
            this.rjBotones1.Size = new System.Drawing.Size(234, 59);
            this.rjBotones1.TabIndex = 7;
            this.rjBotones1.Text = "Login";
            this.rjBotones1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.rjBotones1.UseVisualStyleBackColor = false;
            this.rjBotones1.Click += new System.EventHandler(this.rjBotones1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(480, 699);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.rjBotones1);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.tb_contrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_contrasena;
        private System.Windows.Forms.TextBox tb_usuario;
        private Resources.RJBotones rjBotones1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
    }
}