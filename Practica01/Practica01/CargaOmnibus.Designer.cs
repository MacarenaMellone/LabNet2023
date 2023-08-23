namespace Practica01
{
    partial class Carga
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textError = new System.Windows.Forms.Panel();
            this.textOmnibus1 = new System.Windows.Forms.TextBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textOmnibus2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textOmnibus3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textOmnibus4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textOmnibus5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGA DE PASAJEROS";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVolver.Location = new System.Drawing.Point(290, 414);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(207, 34);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "OMNIBUS 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textError
            // 
            this.textError.BackColor = System.Drawing.SystemColors.Control;
            this.textError.Cursor = System.Windows.Forms.Cursors.Default;
            this.textError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textError.Location = new System.Drawing.Point(334, 278);
            this.textError.Name = "textError";
            this.textError.Size = new System.Drawing.Size(57, 32);
            this.textError.TabIndex = 35;
            // 
            // textOmnibus1
            // 
            this.textOmnibus1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOmnibus1.Location = new System.Drawing.Point(422, 121);
            this.textOmnibus1.MaxLength = 2;
            this.textOmnibus1.Name = "textOmnibus1";
            this.textOmnibus1.Size = new System.Drawing.Size(59, 24);
            this.textOmnibus1.TabIndex = 37;
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.LightCyan;
            this.buttonCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCargar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCargar.Location = new System.Drawing.Point(290, 316);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(207, 34);
            this.buttonCargar.TabIndex = 38;
            this.buttonCargar.Text = "CARGAR";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLimpiar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.Color.Black;
            this.buttonLimpiar.Location = new System.Drawing.Point(290, 365);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(207, 34);
            this.buttonLimpiar.TabIndex = 41;
            this.buttonLimpiar.Text = "LIMPIAR LISTA";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textOmnibus2
            // 
            this.textOmnibus2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOmnibus2.Location = new System.Drawing.Point(422, 153);
            this.textOmnibus2.MaxLength = 2;
            this.textOmnibus2.Name = "textOmnibus2";
            this.textOmnibus2.Size = new System.Drawing.Size(59, 24);
            this.textOmnibus2.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 42;
            this.label3.Text = "OMNIBUS 2";
            // 
            // textOmnibus3
            // 
            this.textOmnibus3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOmnibus3.Location = new System.Drawing.Point(422, 185);
            this.textOmnibus3.MaxLength = 2;
            this.textOmnibus3.Name = "textOmnibus3";
            this.textOmnibus3.Size = new System.Drawing.Size(59, 24);
            this.textOmnibus3.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "OMNIBUS 3";
            // 
            // textOmnibus4
            // 
            this.textOmnibus4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOmnibus4.Location = new System.Drawing.Point(422, 217);
            this.textOmnibus4.MaxLength = 2;
            this.textOmnibus4.Name = "textOmnibus4";
            this.textOmnibus4.Size = new System.Drawing.Size(59, 24);
            this.textOmnibus4.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "OMNIBUS 4";
            // 
            // textOmnibus5
            // 
            this.textOmnibus5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOmnibus5.Location = new System.Drawing.Point(422, 249);
            this.textOmnibus5.MaxLength = 2;
            this.textOmnibus5.Name = "textOmnibus5";
            this.textOmnibus5.Size = new System.Drawing.Size(59, 24);
            this.textOmnibus5.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 48;
            this.label6.Text = "OMNIBUS 5";
            // 
            // Carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 496);
            this.Controls.Add(this.textOmnibus5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textOmnibus4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textOmnibus3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textOmnibus2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.textOmnibus1);
            this.Controls.Add(this.textError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Name = "Carga";
            this.Text = "Práctica 1";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOmnibus1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel textError;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textOmnibus5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textOmnibus4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textOmnibus3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textOmnibus2;
        private System.Windows.Forms.Label label3;
    }
}