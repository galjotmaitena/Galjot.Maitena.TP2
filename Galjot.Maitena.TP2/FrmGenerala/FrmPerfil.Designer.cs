
namespace FrmGenerala
{
    partial class FrmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfil));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVictorias = new System.Windows.Forms.Label();
            this.lblDerrotas = new System.Windows.Forms.Label();
            this.lblAbandonos = new System.Windows.Forms.Label();
            this.lblEmpates = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(152, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 27);
            this.txtNombre.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBox4.Location = new System.Drawing.Point(24, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(367, 262);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gold;
            this.btnLogOut.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogOut.Location = new System.Drawing.Point(217, 233);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(151, 38);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox5.Location = new System.Drawing.Point(50, 91);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(318, 126);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(74, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Victorias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Derrotas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCoral;
            this.label4.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(217, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Abandonos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCoral;
            this.label5.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(217, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Empates:";
            // 
            // lblVictorias
            // 
            this.lblVictorias.AutoSize = true;
            this.lblVictorias.BackColor = System.Drawing.Color.LightCoral;
            this.lblVictorias.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVictorias.Location = new System.Drawing.Point(102, 126);
            this.lblVictorias.Name = "lblVictorias";
            this.lblVictorias.Size = new System.Drawing.Size(23, 27);
            this.lblVictorias.TabIndex = 12;
            this.lblVictorias.Text = "0";
            // 
            // lblDerrotas
            // 
            this.lblDerrotas.AutoSize = true;
            this.lblDerrotas.BackColor = System.Drawing.Color.LightCoral;
            this.lblDerrotas.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDerrotas.Location = new System.Drawing.Point(102, 180);
            this.lblDerrotas.Name = "lblDerrotas";
            this.lblDerrotas.Size = new System.Drawing.Size(23, 27);
            this.lblDerrotas.TabIndex = 13;
            this.lblDerrotas.Text = "0";
            // 
            // lblAbandonos
            // 
            this.lblAbandonos.AutoSize = true;
            this.lblAbandonos.BackColor = System.Drawing.Color.LightCoral;
            this.lblAbandonos.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAbandonos.Location = new System.Drawing.Point(264, 126);
            this.lblAbandonos.Name = "lblAbandonos";
            this.lblAbandonos.Size = new System.Drawing.Size(23, 27);
            this.lblAbandonos.TabIndex = 14;
            this.lblAbandonos.Text = "0";
            // 
            // lblEmpates
            // 
            this.lblEmpates.AutoSize = true;
            this.lblEmpates.BackColor = System.Drawing.Color.LightCoral;
            this.lblEmpates.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmpates.Location = new System.Drawing.Point(264, 180);
            this.lblEmpates.Name = "lblEmpates";
            this.lblEmpates.Size = new System.Drawing.Size(23, 27);
            this.lblEmpates.TabIndex = 15;
            this.lblEmpates.Text = "0";
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(422, 311);
            this.Controls.Add(this.lblEmpates);
            this.Controls.Add(this.lblAbandonos);
            this.Controls.Add(this.lblDerrotas);
            this.Controls.Add(this.lblVictorias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Name = "FrmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVictorias;
        private System.Windows.Forms.Label lblDerrotas;
        private System.Windows.Forms.Label lblAbandonos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEmpates;
    }
}