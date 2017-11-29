namespace Proyecto_BD_HA_V2
{
    partial class BDCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BDCliente));
            this.dataGridReporte = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReporte
            // 
            this.dataGridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReporte.Location = new System.Drawing.Point(23, 63);
            this.dataGridReporte.Name = "dataGridReporte";
            this.dataGridReporte.Size = new System.Drawing.Size(634, 374);
            this.dataGridReporte.TabIndex = 97;
            // 
            // BDCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.dataGridReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BDCliente";
            this.Text = "The Dark Uniform - Clientes";
            this.Load += new System.EventHandler(this.BDCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridReporte;
    }
}