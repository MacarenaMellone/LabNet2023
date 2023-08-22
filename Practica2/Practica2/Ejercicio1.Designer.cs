namespace Practica2
{
    partial class Ejercicio1
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
            this.cero = new System.Windows.Forms.TextBox();
            this.btndividir0 = new System.Windows.Forms.Button();
            this.dividendo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cero
            // 
            this.cero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cero.Enabled = false;
            this.cero.Font = new System.Drawing.Font("Rajdhani Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cero.Location = new System.Drawing.Point(277, 231);
            this.cero.MaxLength = 2;
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(50, 27);
            this.cero.TabIndex = 20;
            this.cero.Text = "0";
            this.cero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btndividir0
            // 
            this.btndividir0.BackColor = System.Drawing.SystemColors.Control;
            this.btndividir0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndividir0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndividir0.FlatAppearance.BorderSize = 2;
            this.btndividir0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndividir0.Font = new System.Drawing.Font("Rajdhani", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndividir0.Location = new System.Drawing.Point(337, 229);
            this.btndividir0.Name = "btndividir0";
            this.btndividir0.Size = new System.Drawing.Size(32, 33);
            this.btndividir0.TabIndex = 19;
            this.btndividir0.Text = "=";
            this.btndividir0.UseVisualStyleBackColor = false;
            this.btndividir0.Click += new System.EventHandler(this.btndividir0_Click);
            // 
            // dividendo
            // 
            this.dividendo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dividendo.Font = new System.Drawing.Font("Rajdhani Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividendo.Location = new System.Drawing.Point(173, 231);
            this.dividendo.MaxLength = 2;
            this.dividendo.Name = "dividendo";
            this.dividendo.Size = new System.Drawing.Size(50, 27);
            this.dividendo.TabIndex = 17;
            this.dividendo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rajdhani", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rajdhani Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingrese un valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rajdhani", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "EJERCICIO  1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rajdhani", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(223, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.btndividir0);
            this.Controls.Add(this.dividendo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cero;
        private System.Windows.Forms.Button btndividir0;
        private System.Windows.Forms.TextBox dividendo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}