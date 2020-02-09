namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacio = new System.Windows.Forms.Button();
            this.btnDivisio = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.btnResidu = new System.Windows.Forms.Button();
            this.btnSeq = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(154, 12);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(116, 23);
            this.txtNombre1.TabIndex = 2;
            this.txtNombre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(154, 352);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(116, 23);
            this.txtNombre2.TabIndex = 3;
            this.txtNombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(348, 12);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(47, 46);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(348, 66);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(47, 46);
            this.btnResta.TabIndex = 5;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacio
            // 
            this.btnMultiplicacio.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacio.Location = new System.Drawing.Point(348, 120);
            this.btnMultiplicacio.Name = "btnMultiplicacio";
            this.btnMultiplicacio.Size = new System.Drawing.Size(47, 46);
            this.btnMultiplicacio.TabIndex = 6;
            this.btnMultiplicacio.Text = "*";
            this.btnMultiplicacio.UseVisualStyleBackColor = true;
            this.btnMultiplicacio.Click += new System.EventHandler(this.btnMultiplicacio_Click);
            // 
            // btnDivisio
            // 
            this.btnDivisio.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisio.Location = new System.Drawing.Point(348, 172);
            this.btnDivisio.Name = "btnDivisio";
            this.btnDivisio.Size = new System.Drawing.Size(47, 46);
            this.btnDivisio.TabIndex = 7;
            this.btnDivisio.Text = "/";
            this.btnDivisio.UseVisualStyleBackColor = true;
            this.btnDivisio.Click += new System.EventHandler(this.btnDivisio_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(154, 323);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.Size = new System.Drawing.Size(116, 23);
            this.txtResultat.TabIndex = 9;
            this.txtResultat.TabStop = false;
            this.txtResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnResidu
            // 
            this.btnResidu.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResidu.Location = new System.Drawing.Point(348, 224);
            this.btnResidu.Name = "btnResidu";
            this.btnResidu.Size = new System.Drawing.Size(47, 46);
            this.btnResidu.TabIndex = 10;
            this.btnResidu.Text = "%";
            this.btnResidu.UseVisualStyleBackColor = true;
            this.btnResidu.Click += new System.EventHandler(this.btnResidu_Click);
            // 
            // btnSeq
            // 
            this.btnSeq.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeq.Location = new System.Drawing.Point(30, 127);
            this.btnSeq.Name = "btnSeq";
            this.btnSeq.Size = new System.Drawing.Size(93, 46);
            this.btnSeq.TabIndex = 11;
            this.btnSeq.Text = "SEQ";
            this.btnSeq.UseVisualStyleBackColor = true;
            this.btnSeq.Click += new System.EventHandler(this.btnSeq_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(348, 276);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(47, 46);
            this.btnPotencia.TabIndex = 12;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnigual
            // 
            this.btnigual.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(348, 328);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(47, 47);
            this.btnigual.TabIndex = 13;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(154, 66);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(47, 46);
            this.btn7.TabIndex = 14;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(207, 66);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(47, 46);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(260, 66);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(47, 46);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(260, 118);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(47, 46);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(207, 118);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(47, 46);
            this.btn5.TabIndex = 18;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(154, 118);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(47, 46);
            this.btn4.TabIndex = 19;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(154, 170);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(47, 46);
            this.btn1.TabIndex = 20;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(207, 170);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(47, 46);
            this.btn2.TabIndex = 21;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(260, 170);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(47, 46);
            this.btn3.TabIndex = 22;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(154, 222);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(153, 46);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 386);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnSeq);
            this.Controls.Add(this.btnResidu);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.btnDivisio);
            this.Controls.Add(this.btnMultiplicacio);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtNombre1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacio;
        private System.Windows.Forms.Button btnDivisio;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Button btnResidu;
        private System.Windows.Forms.Button btnSeq;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
    }
}

