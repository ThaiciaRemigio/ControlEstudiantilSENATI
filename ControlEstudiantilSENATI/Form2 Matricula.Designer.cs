namespace ControlEstudiantilSENATI
{
    partial class Form2_Matricula
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
            this.BTNCERRAR = new System.Windows.Forms.Button();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.txtMatriculas = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMatricula = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtotros = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.BTNMOSTRAR = new System.Windows.Forms.Button();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtNumeroOperacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtEstudiantes = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(342, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO PARA MATRICULA";
            // 
            // BTNCERRAR
            // 
            this.BTNCERRAR.BackColor = System.Drawing.Color.Navy;
            this.BTNCERRAR.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCERRAR.ForeColor = System.Drawing.Color.White;
            this.BTNCERRAR.Location = new System.Drawing.Point(817, 691);
            this.BTNCERRAR.Name = "BTNCERRAR";
            this.BTNCERRAR.Size = new System.Drawing.Size(153, 49);
            this.BTNCERRAR.TabIndex = 16;
            this.BTNCERRAR.Text = "CERRAR";
            this.BTNCERRAR.UseVisualStyleBackColor = false;
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNBUSCAR.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBUSCAR.Location = new System.Drawing.Point(749, 447);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(119, 35);
            this.BTNBUSCAR.TabIndex = 15;
            this.BTNBUSCAR.Text = "BUSCAR";
            this.BTNBUSCAR.UseVisualStyleBackColor = false;
            // 
            // txtMatriculas
            // 
            this.txtMatriculas.Location = new System.Drawing.Point(335, 454);
            this.txtMatriculas.Name = "txtMatriculas";
            this.txtMatriculas.Size = new System.Drawing.Size(392, 20);
            this.txtMatriculas.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(170, 456);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "Ingresar datos a buscar :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 34);
            this.panel1.TabIndex = 12;
            // 
            // dgvMatricula
            // 
            this.dgvMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatricula.Location = new System.Drawing.Point(12, 488);
            this.dgvMatricula.Name = "dgvMatricula";
            this.dgvMatricula.Size = new System.Drawing.Size(958, 197);
            this.dgvMatricula.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.BTNELIMINAR);
            this.groupBox2.Controls.Add(this.BTNMODIFICAR);
            this.groupBox2.Controls.Add(this.BTNGUARDAR);
            this.groupBox2.Controls.Add(this.BTNNUEVO);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 85);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones :";
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNELIMINAR.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.Location = new System.Drawing.Point(737, 22);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(194, 47);
            this.BTNELIMINAR.TabIndex = 3;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNMODIFICAR.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMODIFICAR.Location = new System.Drawing.Point(517, 22);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(198, 47);
            this.BTNMODIFICAR.TabIndex = 2;
            this.BTNMODIFICAR.Text = "MODIFICAR";
            this.BTNMODIFICAR.UseVisualStyleBackColor = false;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNGUARDAR.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.Location = new System.Drawing.Point(287, 22);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(199, 47);
            this.BTNGUARDAR.TabIndex = 1;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTNNUEVO.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVO.Location = new System.Drawing.Point(58, 22);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(194, 47);
            this.BTNNUEVO.TabIndex = 0;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtotros);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.BTNMOSTRAR);
            this.groupBox1.Controls.Add(this.txtCiclo);
            this.groupBox1.Controls.Add(this.txtTurno);
            this.groupBox1.Controls.Add(this.txtNumeroOperacion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtModalidad);
            this.groupBox1.Controls.Add(this.txtSemestre);
            this.groupBox1.Controls.Add(this.txtCarrera);
            this.groupBox1.Controls.Add(this.txtEstudiantes);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 309);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frm_Matricula";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(532, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 23);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // txtotros
            // 
            this.txtotros.Location = new System.Drawing.Point(152, 236);
            this.txtotros.Name = "txtotros";
            this.txtotros.Size = new System.Drawing.Size(608, 23);
            this.txtotros.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Otros : ";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(533, 194);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(217, 23);
            this.txtObservaciones.TabIndex = 30;
            // 
            // BTNMOSTRAR
            // 
            this.BTNMOSTRAR.BackColor = System.Drawing.SystemColors.Control;
            this.BTNMOSTRAR.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMOSTRAR.Location = new System.Drawing.Point(771, 28);
            this.BTNMOSTRAR.Name = "BTNMOSTRAR";
            this.BTNMOSTRAR.Size = new System.Drawing.Size(172, 45);
            this.BTNMOSTRAR.TabIndex = 28;
            this.BTNMOSTRAR.Text = "MOSTRAR";
            this.BTNMOSTRAR.UseVisualStyleBackColor = false;
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(532, 155);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(217, 23);
            this.txtCiclo.TabIndex = 19;
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(532, 112);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(217, 23);
            this.txtTurno.TabIndex = 18;
            // 
            // txtNumeroOperacion
            // 
            this.txtNumeroOperacion.Location = new System.Drawing.Point(533, 74);
            this.txtNumeroOperacion.Name = "txtNumeroOperacion";
            this.txtNumeroOperacion.Size = new System.Drawing.Size(217, 23);
            this.txtNumeroOperacion.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ciclo : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Turno : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Numero Operación : ";
            // 
            // txtModalidad
            // 
            this.txtModalidad.Location = new System.Drawing.Point(152, 191);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.Size = new System.Drawing.Size(217, 23);
            this.txtModalidad.TabIndex = 12;
            // 
            // txtSemestre
            // 
            this.txtSemestre.Location = new System.Drawing.Point(152, 151);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(217, 23);
            this.txtSemestre.TabIndex = 11;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(152, 112);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(217, 23);
            this.txtCarrera.TabIndex = 10;
            // 
            // txtEstudiantes
            // 
            this.txtEstudiantes.Location = new System.Drawing.Point(152, 71);
            this.txtEstudiantes.Name = "txtEstudiantes";
            this.txtEstudiantes.Size = new System.Drawing.Size(217, 23);
            this.txtEstudiantes.TabIndex = 9;
            this.txtEstudiantes.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // txtMatricula
            // 
            this.txtMatricula.ForeColor = System.Drawing.Color.Silver;
            this.txtMatricula.Location = new System.Drawing.Point(152, 32);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(217, 23);
            this.txtMatricula.TabIndex = 8;
            this.txtMatricula.Text = "                     (Automatico)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fecha Matricula : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Observaciones : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Modalidad : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Semestre : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Carrera : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estudiante : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Matricula : ";
            // 
            // Form2_Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 761);
            this.Controls.Add(this.BTNCERRAR);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.txtMatriculas);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMatricula);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2_Matricula";
            this.Text = "Form2_Matricula";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNCERRAR;
        private System.Windows.Forms.Button BTNBUSCAR;
        private System.Windows.Forms.TextBox txtMatriculas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMatricula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNMODIFICAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNMOSTRAR;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtNumeroOperacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtEstudiantes;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtotros;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}