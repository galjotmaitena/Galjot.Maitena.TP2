
namespace FrmGenerala
{
    partial class FrmRegistrarse
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.gpbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Enabled = false;
            this.btnRegistrarse.Location = new System.Drawing.Point(122, 147);
            this.btnRegistrarse.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresar.Location = new System.Drawing.Point(225, 178);
            this.btnIngresar.Size = new System.Drawing.Size(27, 23);
            this.btnIngresar.Text = "";
            this.btnIngresar.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gold;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Crimson;
            this.btnRegistrar.Location = new System.Drawing.Point(122, 148);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(128, 26);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gpbSexo
            // 
            this.gpbSexo.BackColor = System.Drawing.Color.Transparent;
            this.gpbSexo.Controls.Add(this.rdbMujer);
            this.gpbSexo.Controls.Add(this.rdbHombre);
            this.gpbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbSexo.ForeColor = System.Drawing.Color.White;
            this.gpbSexo.Location = new System.Drawing.Point(10, 124);
            this.gpbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbSexo.Size = new System.Drawing.Size(107, 71);
            this.gpbSexo.TabIndex = 8;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Location = new System.Drawing.Point(5, 22);
            this.rdbMujer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(66, 24);
            this.rdbMujer.TabIndex = 9;
            this.rdbMujer.TabStop = true;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Location = new System.Drawing.Point(5, 46);
            this.rdbHombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(84, 24);
            this.rdbHombre.TabIndex = 10;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // FrmRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 198);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FrmRegistrarse";
            this.Text = "Registrarse";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.btnRegistrarse, 0);
            this.Controls.SetChildIndex(this.btnIngresar, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.gpbSexo, 0);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.FrmRegistrarse_Load);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbHombre;
    }
}