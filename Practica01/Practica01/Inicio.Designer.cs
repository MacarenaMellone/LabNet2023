namespace Practica01
{
    partial class Inicio
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarOmnibus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargaTaxi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(282, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.Location = new System.Drawing.Point(276, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(248, 37);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarOmnibus
            // 
            this.btnCargarOmnibus.BackColor = System.Drawing.Color.LightCyan;
            this.btnCargarOmnibus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarOmnibus.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarOmnibus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCargarOmnibus.Location = new System.Drawing.Point(276, 279);
            this.btnCargarOmnibus.Name = "btnCargarOmnibus";
            this.btnCargarOmnibus.Size = new System.Drawing.Size(248, 34);
            this.btnCargarOmnibus.TabIndex = 3;
            this.btnCargarOmnibus.Text = "CARGAR OMNIBUS";
            this.btnCargarOmnibus.UseVisualStyleBackColor = false;
            this.btnCargarOmnibus.Click += new System.EventHandler(this.btnCargarOmnibus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(250, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "INFORME LA CANTIDAD DE PASAJEROS";
            // 
            // btnCargaTaxi
            // 
            this.btnCargaTaxi.BackColor = System.Drawing.Color.LightCyan;
            this.btnCargaTaxi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargaTaxi.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaTaxi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCargaTaxi.Location = new System.Drawing.Point(276, 237);
            this.btnCargaTaxi.Name = "btnCargaTaxi";
            this.btnCargaTaxi.Size = new System.Drawing.Size(248, 34);
            this.btnCargaTaxi.TabIndex = 5;
            this.btnCargaTaxi.Text = "CARGAR TAXIS";
            this.btnCargaTaxi.UseVisualStyleBackColor = false;
            this.btnCargaTaxi.Click += new System.EventHandler(this.btnCargaTaxi_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargaTaxi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCargarOmnibus);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inicio";
            this.Text = "Práctica 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarOmnibus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargaTaxi;
    }
}

