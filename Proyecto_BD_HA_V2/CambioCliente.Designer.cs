namespace Proyecto_BD_HA_V2
{
    partial class CambioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioCliente));
            this.button2 = new System.Windows.Forms.Button();
            this.textoEmail = new System.Windows.Forms.TextBox();
            this.textoTel = new System.Windows.Forms.TextBox();
            this.textoDir = new System.Windows.Forms.TextBox();
            this.textoApe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textoNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(511, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 192;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textoEmail
            // 
            this.textoEmail.Location = new System.Drawing.Point(229, 282);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(364, 20);
            this.textoEmail.TabIndex = 203;
            // 
            // textoTel
            // 
            this.textoTel.Location = new System.Drawing.Point(229, 253);
            this.textoTel.Name = "textoTel";
            this.textoTel.Size = new System.Drawing.Size(364, 20);
            this.textoTel.TabIndex = 202;
            // 
            // textoDir
            // 
            this.textoDir.Location = new System.Drawing.Point(229, 223);
            this.textoDir.Name = "textoDir";
            this.textoDir.Size = new System.Drawing.Size(364, 20);
            this.textoDir.TabIndex = 201;
            // 
            // textoApe
            // 
            this.textoApe.Location = new System.Drawing.Point(229, 193);
            this.textoApe.Name = "textoApe";
            this.textoApe.Size = new System.Drawing.Size(364, 20);
            this.textoApe.TabIndex = 200;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(71, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 24);
            this.label11.TabIndex = 199;
            this.label11.Text = "E-mail *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.label12.Location = new System.Drawing.Point(71, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 24);
            this.label12.TabIndex = 198;
            this.label12.Text = "Telefono *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(71, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 24);
            this.label10.TabIndex = 197;
            this.label10.Text = "Direccion *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(71, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 196;
            this.label8.Text = "Apellidos *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(71, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 195;
            this.label9.Text = "Nombre *";
            // 
            // textoNom
            // 
            this.textoNom.Location = new System.Drawing.Point(229, 164);
            this.textoNom.Name = "textoNom";
            this.textoNom.Size = new System.Drawing.Size(364, 20);
            this.textoNom.TabIndex = 194;
            // 
            // CambioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.textoEmail);
            this.Controls.Add(this.textoTel);
            this.Controls.Add(this.textoDir);
            this.Controls.Add(this.textoApe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textoNom);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CambioCliente";
            this.Resizable = false;
            this.Text = "The Dark Uniforms - Actualizar Datos Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CambioCliente_FormClosed);
            this.Load += new System.EventHandler(this.CambioCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textoEmail;
        private System.Windows.Forms.TextBox textoTel;
        private System.Windows.Forms.TextBox textoDir;
        private System.Windows.Forms.TextBox textoApe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textoNom;
    }
}