﻿namespace Proyecto_BD_HA_V2
{
    partial class Alta_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Productos));
            this.textoPrecio = new System.Windows.Forms.TextBox();
            this.textoStock = new System.Windows.Forms.TextBox();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboTalla = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // textoPrecio
            // 
            this.textoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic);
            this.textoPrecio.Location = new System.Drawing.Point(381, 209);
            this.textoPrecio.Name = "textoPrecio";
            this.textoPrecio.Size = new System.Drawing.Size(276, 27);
            this.textoPrecio.TabIndex = 70;
            this.textoPrecio.Validated += new System.EventHandler(this.textoPrecio_Validated);
            // 
            // textoStock
            // 
            this.textoStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic);
            this.textoStock.Location = new System.Drawing.Point(141, 239);
            this.textoStock.Name = "textoStock";
            this.textoStock.Size = new System.Drawing.Size(129, 27);
            this.textoStock.TabIndex = 69;
            this.textoStock.Validated += new System.EventHandler(this.textoCosto_Validated);
            // 
            // textoNombre
            // 
            this.textoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic);
            this.textoNombre.Location = new System.Drawing.Point(141, 175);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(516, 27);
            this.textoNombre.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 29);
            this.label11.TabIndex = 67;
            this.label11.Text = "Stock *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(276, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 29);
            this.label12.TabIndex = 66;
            this.label12.Text = "Precio *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 29);
            this.label10.TabIndex = 65;
            this.label10.Text = "Talla *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 29);
            this.label8.TabIndex = 64;
            this.label8.Text = "Nombre *";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(505, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 34);
            this.button2.TabIndex = 78;
            this.button2.Text = "ACEPTAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(339, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 34);
            this.button1.TabIndex = 77;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboTalla
            // 
            this.comboTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic);
            this.comboTalla.FormattingEnabled = true;
            this.comboTalla.Items.AddRange(new object[] {
            "Extra Chico",
            "Chico",
            "Mediano",
            "Grande",
            "Extra Grande"});
            this.comboTalla.Location = new System.Drawing.Point(141, 205);
            this.comboTalla.Name = "comboTalla";
            this.comboTalla.Size = new System.Drawing.Size(129, 28);
            this.comboTalla.TabIndex = 79;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(104, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 80;
            // 
            // Alta_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTalla);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoPrecio);
            this.Controls.Add(this.textoStock);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Alta_Productos";
            this.Resizable = false;
            this.Text = "The Dark Uniforms - Alta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alta_Productos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textoPrecio;
        private System.Windows.Forms.TextBox textoStock;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboTalla;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label2;
    }
}