
namespace Among_us
{
    partial class form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInstruccion = new System.Windows.Forms.Button();
            this.btnColorFondo = new System.Windows.Forms.Button();
            this.BtnAutor = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(183)))));
            this.groupBox1.Controls.Add(this.btnInstruccion);
            this.groupBox1.Controls.Add(this.btnColorFondo);
            this.groupBox1.Controls.Add(this.BtnAutor);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnDibujar);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Among Us";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnInstruccion
            // 
            this.btnInstruccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInstruccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstruccion.ForeColor = System.Drawing.Color.White;
            this.btnInstruccion.Location = new System.Drawing.Point(22, 205);
            this.btnInstruccion.Name = "btnInstruccion";
            this.btnInstruccion.Size = new System.Drawing.Size(87, 28);
            this.btnInstruccion.TabIndex = 7;
            this.btnInstruccion.Text = "Instrucciones";
            this.btnInstruccion.UseVisualStyleBackColor = false;
            this.btnInstruccion.Click += new System.EventHandler(this.btnInstruccion_Click);
            // 
            // btnColorFondo
            // 
            this.btnColorFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnColorFondo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorFondo.ForeColor = System.Drawing.Color.White;
            this.btnColorFondo.Location = new System.Drawing.Point(18, 147);
            this.btnColorFondo.Name = "btnColorFondo";
            this.btnColorFondo.Size = new System.Drawing.Size(98, 28);
            this.btnColorFondo.TabIndex = 6;
            this.btnColorFondo.Text = "Colorear Fondo";
            this.btnColorFondo.UseVisualStyleBackColor = false;
            this.btnColorFondo.Click += new System.EventHandler(this.btnColorFondo_Click);
            // 
            // BtnAutor
            // 
            this.BtnAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAutor.ForeColor = System.Drawing.Color.White;
            this.BtnAutor.Location = new System.Drawing.Point(27, 276);
            this.BtnAutor.Name = "BtnAutor";
            this.BtnAutor.Size = new System.Drawing.Size(75, 28);
            this.BtnAutor.TabIndex = 5;
            this.BtnAutor.Text = "Autor";
            this.BtnAutor.UseVisualStyleBackColor = false;
            this.BtnAutor.Click += new System.EventHandler(this.BtnAutor_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(29, 106);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(128, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 284);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Enabled = false;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(29, 72);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 28);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDibujar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDibujar.Enabled = false;
            this.btnDibujar.ForeColor = System.Drawing.Color.White;
            this.btnDibujar.Location = new System.Drawing.Point(18, 32);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(98, 28);
            this.btnDibujar.TabIndex = 0;
            this.btnDibujar.Text = "Dibujar Figura";
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(631, 347);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button BtnAutor;
        private System.Windows.Forms.Button btnColorFondo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnInstruccion;
    }
}

