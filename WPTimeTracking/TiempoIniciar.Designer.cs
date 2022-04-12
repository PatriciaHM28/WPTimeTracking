namespace WPTimeTracking
{
    partial class TiempoIniciar
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.wPTTimeTrackingDataSet = new WPTimeTracking.WPTTimeTrackingDataSet();
            this.tareasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tareasTableAdapter = new WPTimeTracking.WPTTimeTrackingDataSetTableAdapters.tareasTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_timer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wPTTimeTrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iniciar Tiempo";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tareasBindingSource;
            this.listBox1.DisplayMember = "titulo";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(294, 193);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 100);
            this.listBox1.TabIndex = 5;
            // 
            // wPTTimeTrackingDataSet
            // 
            this.wPTTimeTrackingDataSet.DataSetName = "WPTTimeTrackingDataSet";
            this.wPTTimeTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tareasBindingSource
            // 
            this.tareasBindingSource.DataMember = "tareas";
            this.tareasBindingSource.DataSource = this.wPTTimeTrackingDataSet;
            // 
            // tareasTableAdapter
            // 
            this.tareasTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.Image = global::WPTimeTracking.Properties.Resources.png_clipart_menu_icon_icons_logo;
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 55);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecciona la Tarea ";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_timer
            // 
            this.tb_timer.Enabled = false;
            this.tb_timer.Location = new System.Drawing.Point(57, 370);
            this.tb_timer.Name = "tb_timer";
            this.tb_timer.Size = new System.Drawing.Size(404, 22);
            this.tb_timer.TabIndex = 16;
            this.tb_timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TiempoIniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_timer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TiempoIniciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Tiempo";
            this.Load += new System.EventHandler(this.TiempoIniciar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wPTTimeTrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private WPTTimeTrackingDataSet wPTTimeTrackingDataSet;
        private System.Windows.Forms.BindingSource tareasBindingSource;
        private WPTTimeTrackingDataSetTableAdapters.tareasTableAdapter tareasTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_timer;
    }
}