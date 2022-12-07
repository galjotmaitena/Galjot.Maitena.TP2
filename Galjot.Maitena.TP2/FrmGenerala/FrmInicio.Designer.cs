
namespace FrmGenerala
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnReglas = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnPartidas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Gold;
            this.btnJugar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJugar.ForeColor = System.Drawing.Color.Crimson;
            this.btnJugar.Location = new System.Drawing.Point(56, 308);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(183, 46);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnReglas
            // 
            this.btnReglas.BackColor = System.Drawing.Color.Gold;
            this.btnReglas.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReglas.ForeColor = System.Drawing.Color.Crimson;
            this.btnReglas.Location = new System.Drawing.Point(308, 308);
            this.btnReglas.Name = "btnReglas";
            this.btnReglas.Size = new System.Drawing.Size(183, 46);
            this.btnReglas.TabIndex = 1;
            this.btnReglas.Text = "REGLAS";
            this.btnReglas.UseVisualStyleBackColor = false;
            this.btnReglas.Click += new System.EventHandler(this.btnReglas_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Gold;
            this.btnPerfil.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPerfil.ForeColor = System.Drawing.Color.Crimson;
            this.btnPerfil.Location = new System.Drawing.Point(549, 308);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(183, 46);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.Text = "PERFIL";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnPartidas
            // 
            this.btnPartidas.BackColor = System.Drawing.Color.Gold;
            this.btnPartidas.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPartidas.ForeColor = System.Drawing.Color.Crimson;
            this.btnPartidas.Location = new System.Drawing.Point(184, 380);
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(183, 46);
            this.btnPartidas.TabIndex = 3;
            this.btnPartidas.Text = "PARTIDAS";
            this.btnPartidas.UseVisualStyleBackColor = false;
            this.btnPartidas.Click += new System.EventHandler(this.btnPartidas_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(156, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 86);
            this.label1.TabIndex = 4;
            this.label1.Text = "GENERALA";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPartidas);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnReglas);
            this.Controls.Add(this.btnJugar);
            this.DoubleBuffered = true;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnReglas;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnPartidas;
        private System.Windows.Forms.Label label1;
    }
}

