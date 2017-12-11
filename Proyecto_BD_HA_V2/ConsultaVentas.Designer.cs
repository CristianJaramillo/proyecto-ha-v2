namespace Proyecto_BD_HA_V2
{
    partial class ConsultaVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVentas));
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SearchMetroButton = new MetroFramework.Controls.MetroButton();
            this.BillErrorMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.BillMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDetailtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVentaMetroLabel = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.BillMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(376, 66);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(178, 20);
            this.SearchTextBox.TabIndex = 106;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(192, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(178, 19);
            this.metroLabel1.TabIndex = 112;
            this.metroLabel1.Text = "Ingresa el número de factura";
            // 
            // SearchMetroButton
            // 
            this.SearchMetroButton.Location = new System.Drawing.Point(560, 63);
            this.SearchMetroButton.Name = "SearchMetroButton";
            this.SearchMetroButton.Size = new System.Drawing.Size(97, 23);
            this.SearchMetroButton.TabIndex = 113;
            this.SearchMetroButton.Text = "Buscar";
            this.SearchMetroButton.UseSelectable = true;
            this.SearchMetroButton.Click += new System.EventHandler(this.SearchMetroButton_Click);
            // 
            // BillErrorMetroLabel
            // 
            this.BillErrorMetroLabel.AutoSize = true;
            this.BillErrorMetroLabel.Location = new System.Drawing.Point(376, 91);
            this.BillErrorMetroLabel.Name = "BillErrorMetroLabel";
            this.BillErrorMetroLabel.Size = new System.Drawing.Size(101, 19);
            this.BillErrorMetroLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.BillErrorMetroLabel.TabIndex = 115;
            this.BillErrorMetroLabel.Text = "bill search error";
            this.BillErrorMetroLabel.UseStyleColors = true;
            this.BillErrorMetroLabel.Visible = false;
            // 
            // BillMetroGrid
            // 
            this.BillMetroGrid.AllowUserToAddRows = false;
            this.BillMetroGrid.AllowUserToDeleteRows = false;
            this.BillMetroGrid.AllowUserToOrderColumns = true;
            this.BillMetroGrid.AllowUserToResizeRows = false;
            this.BillMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BillMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BillMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BillMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.ProductColumn,
            this.ProductCountColumn,
            this.ProductPriceColumn,
            this.ProductDetailtColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.BillMetroGrid.EnableHeadersVisualStyles = false;
            this.BillMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BillMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BillMetroGrid.Location = new System.Drawing.Point(23, 113);
            this.BillMetroGrid.Name = "BillMetroGrid";
            this.BillMetroGrid.ReadOnly = true;
            this.BillMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BillMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BillMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillMetroGrid.Size = new System.Drawing.Size(634, 271);
            this.BillMetroGrid.TabIndex = 116;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // ProductColumn
            // 
            this.ProductColumn.HeaderText = "Producto";
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.ReadOnly = true;
            // 
            // ProductCountColumn
            // 
            this.ProductCountColumn.HeaderText = "Cantidad";
            this.ProductCountColumn.Name = "ProductCountColumn";
            this.ProductCountColumn.ReadOnly = true;
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.HeaderText = "Precio";
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            this.ProductPriceColumn.ReadOnly = true;
            // 
            // ProductDetailtColumn
            // 
            this.ProductDetailtColumn.HeaderText = "Detalles";
            this.ProductDetailtColumn.Name = "ProductDetailtColumn";
            this.ProductDetailtColumn.ReadOnly = true;
            // 
            // TotalVentaMetroLabel
            // 
            this.TotalVentaMetroLabel.ActiveControl = null;
            this.TotalVentaMetroLabel.Location = new System.Drawing.Point(376, 390);
            this.TotalVentaMetroLabel.Name = "TotalVentaMetroLabel";
            this.TotalVentaMetroLabel.Size = new System.Drawing.Size(281, 47);
            this.TotalVentaMetroLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalVentaMetroLabel.TabIndex = 117;
            this.TotalVentaMetroLabel.Text = "$ 0.00";
            this.TotalVentaMetroLabel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TotalVentaMetroLabel.UseSelectable = true;
            // 
            // ConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.TotalVentaMetroLabel);
            this.Controls.Add(this.BillMetroGrid);
            this.Controls.Add(this.BillErrorMetroLabel);
            this.Controls.Add(this.SearchMetroButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SearchTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaVentas";
            this.Resizable = false;
            this.Text = "Consulta de Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultaVentas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.BillMetroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton SearchMetroButton;
        private MetroFramework.Controls.MetroLabel BillErrorMetroLabel;
        private MetroFramework.Controls.MetroGrid BillMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDetailtColumn;
        private MetroFramework.Controls.MetroTile TotalVentaMetroLabel;
    }
}