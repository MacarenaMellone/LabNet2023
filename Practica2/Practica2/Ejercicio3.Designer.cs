namespace Practica2
{
    partial class Ejercicio3
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
            this.mayor = new System.Windows.Forms.TextBox();
            this.menor = new System.Windows.Forms.TextBox();
            this.mayorMenor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rajdhani", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(194, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rajdhani", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "EJERCICIO 3";
            // 
            // mayor
            // 
            this.mayor.Font = new System.Drawing.Font("Rajdhani", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mayor.Location = new System.Drawing.Point(194, 208);
            this.mayor.MaxLength = 3;
            this.mayor.Name = "mayor";
            this.mayor.Size = new System.Drawing.Size(57, 34);
            this.mayor.TabIndex = 5;
            // 
            // menor
            // 
            this.menor.Font = new System.Drawing.Font("Rajdhani", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menor.Location = new System.Drawing.Point(297, 208);
            this.menor.MaxLength = 3;
            this.menor.Name = "menor";
            this.menor.Size = new System.Drawing.Size(57, 34);
            this.menor.TabIndex = 6;
            // 
            // mayorMenor
            // 
            this.mayorMenor.FlatAppearance.BorderSize = 2;
            this.mayorMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mayorMenor.Font = new System.Drawing.Font("Rajdhani", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mayorMenor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mayorMenor.Location = new System.Drawing.Point(194, 265);
            this.mayorMenor.Name = "mayorMenor";
            this.mayorMenor.Size = new System.Drawing.Size(160, 39);
            this.mayorMenor.TabIndex = 12;
            this.mayorMenor.Text = "COMPARAR";
            this.mayorMenor.UseVisualStyleBackColor = true;
            this.mayorMenor.Click += new System.EventHandler(this.mayorMenor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rajdhani", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 34);
            this.label4.TabIndex = 13;
            this.label4.Text = ">";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rajdhani Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingrese los valores correspondientes:";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mayorMenor);
            this.Controls.Add(this.menor);
            this.Controls.Add(this.mayor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mayor;
        private System.Windows.Forms.TextBox menor;
        private System.Windows.Forms.Button mayorMenor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}