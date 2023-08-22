namespace Practica2
{
    partial class Ejercicio2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dividendo = new System.Windows.Forms.TextBox();
            this.resultado1 = new System.Windows.Forms.Label();
            this.btndividir1 = new System.Windows.Forms.Button();
            this.divisor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rajdhani", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(195, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rajdhani", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "EJERCICIO  2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rajdhani Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese un valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rajdhani", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "/";
            // 
            // dividendo
            // 
            this.dividendo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dividendo.Font = new System.Drawing.Font("Rajdhani Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividendo.Location = new System.Drawing.Point(145, 202);
            this.dividendo.MaxLength = 2;
            this.dividendo.Name = "dividendo";
            this.dividendo.Size = new System.Drawing.Size(50, 27);
            this.dividendo.TabIndex = 7;
            this.dividendo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultado1
            // 
            this.resultado1.AutoSize = true;
            this.resultado1.Font = new System.Drawing.Font("Rajdhani SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado1.Location = new System.Drawing.Point(347, 199);
            this.resultado1.Name = "resultado1";
            this.resultado1.Size = new System.Drawing.Size(69, 30);
            this.resultado1.TabIndex = 10;
            this.resultado1.Text = "label1";
            // 
            // btndividir1
            // 
            this.btndividir1.FlatAppearance.BorderSize = 2;
            this.btndividir1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndividir1.Font = new System.Drawing.Font("Rajdhani", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndividir1.Location = new System.Drawing.Point(309, 199);
            this.btndividir1.Name = "btndividir1";
            this.btndividir1.Size = new System.Drawing.Size(32, 33);
            this.btndividir1.TabIndex = 11;
            this.btndividir1.Text = "=";
            this.btndividir1.UseVisualStyleBackColor = true;
            this.btndividir1.Click += new System.EventHandler(this.btndividir1_Click);
            // 
            // divisor
            // 
            this.divisor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.divisor.Font = new System.Drawing.Font("Rajdhani Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisor.Location = new System.Drawing.Point(249, 202);
            this.divisor.MaxLength = 2;
            this.divisor.Name = "divisor";
            this.divisor.Size = new System.Drawing.Size(50, 27);
            this.divisor.TabIndex = 12;
            this.divisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 416);
            this.Controls.Add(this.divisor);
            this.Controls.Add(this.btndividir1);
            this.Controls.Add(this.resultado1);
            this.Controls.Add(this.dividendo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultado1;
        private System.Windows.Forms.Button btndividir1;
        public System.Windows.Forms.TextBox dividendo;
        public System.Windows.Forms.TextBox divisor;
    }
}