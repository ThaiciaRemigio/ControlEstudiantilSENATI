namespace ControlEstudiantilSENATI
{
    partial class Form_PinDeSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PinDeSeguridad));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPIN = new System.Windows.Forms.TextBox();
            this.linkOlvidaste = new System.Windows.Forms.LinkLabel();
            this.BTNCONTINUAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(188, 141);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar PIN de seguridad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Por favor, ingresa tu PIN de 4 digitos para continuar.";
            // 
            // textPIN
            // 
            this.textPIN.Location = new System.Drawing.Point(75, 252);
            this.textPIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPIN.MaxLength = 4;
            this.textPIN.Multiline = true;
            this.textPIN.Name = "textPIN";
            this.textPIN.PasswordChar = '*';
            this.textPIN.Size = new System.Drawing.Size(260, 36);
            this.textPIN.TabIndex = 4;
            this.textPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPIN.TextChanged += new System.EventHandler(this.textPIN_TextChanged);
            this.textPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPIN_KeyPress);
            // 
            // linkOlvidaste
            // 
            this.linkOlvidaste.AutoSize = true;
            this.linkOlvidaste.Location = new System.Drawing.Point(81, 301);
            this.linkOlvidaste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkOlvidaste.Name = "linkOlvidaste";
            this.linkOlvidaste.Size = new System.Drawing.Size(96, 13);
            this.linkOlvidaste.TabIndex = 5;
            this.linkOlvidaste.TabStop = true;
            this.linkOlvidaste.Text = "¿Olvidaste tu PIN?";
            this.linkOlvidaste.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOlvidaste_LinkClicked);
            // 
            // BTNCONTINUAR
            // 
            this.BTNCONTINUAR.BackColor = System.Drawing.Color.DarkBlue;
            this.BTNCONTINUAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCONTINUAR.ForeColor = System.Drawing.Color.White;
            this.BTNCONTINUAR.Location = new System.Drawing.Point(102, 333);
            this.BTNCONTINUAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNCONTINUAR.Name = "BTNCONTINUAR";
            this.BTNCONTINUAR.Size = new System.Drawing.Size(200, 47);
            this.BTNCONTINUAR.TabIndex = 7;
            this.BTNCONTINUAR.Text = "Continuar";
            this.BTNCONTINUAR.UseVisualStyleBackColor = false;
            this.BTNCONTINUAR.Click += new System.EventHandler(this.BTNCONTINUAR_Click);
            // 
            // Form_PinDeSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 492);
            this.Controls.Add(this.BTNCONTINUAR);
            this.Controls.Add(this.linkOlvidaste);
            this.Controls.Add(this.textPIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_PinDeSeguridad";
            this.Text = "Form_PinDeSeguridad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPIN;
        private System.Windows.Forms.LinkLabel linkOlvidaste;
        private System.Windows.Forms.Button BTNCONTINUAR;
    }
}