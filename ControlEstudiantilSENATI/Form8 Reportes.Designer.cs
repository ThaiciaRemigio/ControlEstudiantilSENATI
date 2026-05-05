namespace ControlEstudiantilSENATI
{
    partial class Form8_Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8_Reportes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Frm_Busqueda = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTNGENERAR = new System.Windows.Forms.Button();
            this.BTNLIMPIAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNPDF = new System.Windows.Forms.Button();
            this.BTNIMPRIMIR = new System.Windows.Forms.Button();
            this.BTNCERRAR = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Frm_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(290, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO PARA USUARIOS\r\n\r\n";
            // 
            // Frm_Busqueda
            // 
            this.Frm_Busqueda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Frm_Busqueda.Controls.Add(this.BTNLIMPIAR);
            this.Frm_Busqueda.Controls.Add(this.BTNGENERAR);
            this.Frm_Busqueda.Controls.Add(this.textBox1);
            this.Frm_Busqueda.Controls.Add(this.dateTimePicker2);
            this.Frm_Busqueda.Controls.Add(this.dateTimePicker1);
            this.Frm_Busqueda.Controls.Add(this.label4);
            this.Frm_Busqueda.Controls.Add(this.label3);
            this.Frm_Busqueda.Controls.Add(this.label2);
            this.Frm_Busqueda.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_Busqueda.Location = new System.Drawing.Point(12, 78);
            this.Frm_Busqueda.Name = "Frm_Busqueda";
            this.Frm_Busqueda.Size = new System.Drawing.Size(929, 138);
            this.Frm_Busqueda.TabIndex = 1;
            this.Frm_Busqueda.TabStop = false;
            this.Frm_Busqueda.Text = "Frm_Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estudiante :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha Fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Inicio :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(414, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(725, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 23);
            this.textBox1.TabIndex = 5;
            // 
            // BTNGENERAR
            // 
            this.BTNGENERAR.BackColor = System.Drawing.Color.Navy;
            this.BTNGENERAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNGENERAR.Location = new System.Drawing.Point(241, 74);
            this.BTNGENERAR.Name = "BTNGENERAR";
            this.BTNGENERAR.Size = new System.Drawing.Size(183, 42);
            this.BTNGENERAR.TabIndex = 6;
            this.BTNGENERAR.Text = "GENERAR";
            this.BTNGENERAR.UseVisualStyleBackColor = false;
            this.BTNGENERAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNLIMPIAR
            // 
            this.BTNLIMPIAR.BackColor = System.Drawing.Color.Navy;
            this.BTNLIMPIAR.ForeColor = System.Drawing.Color.White;
            this.BTNLIMPIAR.Location = new System.Drawing.Point(462, 74);
            this.BTNLIMPIAR.Name = "BTNLIMPIAR";
            this.BTNLIMPIAR.Size = new System.Drawing.Size(183, 42);
            this.BTNLIMPIAR.TabIndex = 7;
            this.BTNLIMPIAR.Text = "LIMPIAR";
            this.BTNLIMPIAR.UseVisualStyleBackColor = false;
            this.BTNLIMPIAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(929, 242);
            this.dataGridView1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "RESULTADO DE REPORTE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BTNPDF
            // 
            this.BTNPDF.BackColor = System.Drawing.Color.Navy;
            this.BTNPDF.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNPDF.Location = new System.Drawing.Point(416, 520);
            this.BTNPDF.Name = "BTNPDF";
            this.BTNPDF.Size = new System.Drawing.Size(154, 37);
            this.BTNPDF.TabIndex = 5;
            this.BTNPDF.Text = "EXPORTAR PDF";
            this.BTNPDF.UseVisualStyleBackColor = false;
            // 
            // BTNIMPRIMIR
            // 
            this.BTNIMPRIMIR.BackColor = System.Drawing.Color.Navy;
            this.BTNIMPRIMIR.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIMPRIMIR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNIMPRIMIR.Location = new System.Drawing.Point(591, 520);
            this.BTNIMPRIMIR.Name = "BTNIMPRIMIR";
            this.BTNIMPRIMIR.Size = new System.Drawing.Size(154, 37);
            this.BTNIMPRIMIR.TabIndex = 6;
            this.BTNIMPRIMIR.Text = "IMPRIMIR";
            this.BTNIMPRIMIR.UseVisualStyleBackColor = false;
            // 
            // BTNCERRAR
            // 
            this.BTNCERRAR.BackColor = System.Drawing.Color.Navy;
            this.BTNCERRAR.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCERRAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCERRAR.Location = new System.Drawing.Point(770, 520);
            this.BTNCERRAR.Name = "BTNCERRAR";
            this.BTNCERRAR.Size = new System.Drawing.Size(154, 37);
            this.BTNCERRAR.TabIndex = 7;
            this.BTNCERRAR.Text = "CERRAR";
            this.BTNCERRAR.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form8_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(950, 578);
            this.Controls.Add(this.BTNCERRAR);
            this.Controls.Add(this.BTNIMPRIMIR);
            this.Controls.Add(this.BTNPDF);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Frm_Busqueda);
            this.Controls.Add(this.panel1);
            this.Name = "Form8_Reportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Frm_Busqueda.ResumeLayout(false);
            this.Frm_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Frm_Busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BTNLIMPIAR;
        private System.Windows.Forms.Button BTNGENERAR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNPDF;
        private System.Windows.Forms.Button BTNIMPRIMIR;
        private System.Windows.Forms.Button BTNCERRAR;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}