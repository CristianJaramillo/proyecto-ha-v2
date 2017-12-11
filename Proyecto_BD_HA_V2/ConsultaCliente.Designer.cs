namespace Proyecto_BD_HA_V2
{
    partial class ConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCliente));
            this.SearchMetroButton = new MetroFramework.Controls.MetroButton();
            this.SearchUserMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.SearchClientMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ClientsMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchMetroButton
            // 
            this.SearchMetroButton.Location = new System.Drawing.Point(595, 57);
            this.SearchMetroButton.Name = "SearchMetroButton";
            this.SearchMetroButton.Size = new System.Drawing.Size(66, 23);
            this.SearchMetroButton.TabIndex = 97;
            this.SearchMetroButton.Text = "Buscar";
            this.SearchMetroButton.UseSelectable = true;
            this.SearchMetroButton.Click += new System.EventHandler(this.SearchMetroButton_Click);
            // 
            // SearchUserMetroLabel
            // 
            this.SearchUserMetroLabel.AutoSize = true;
            this.SearchUserMetroLabel.Location = new System.Drawing.Point(332, 57);
            this.SearchUserMetroLabel.Name = "SearchUserMetroLabel";
            this.SearchUserMetroLabel.Size = new System.Drawing.Size(85, 19);
            this.SearchUserMetroLabel.TabIndex = 96;
            this.SearchUserMetroLabel.Text = "Ingrese un ID";
            // 
            // SearchClientMetroTextBox
            // 
            // 
            // 
            // 
            this.SearchClientMetroTextBox.CustomButton.Image = null;
            this.SearchClientMetroTextBox.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.SearchClientMetroTextBox.CustomButton.Name = "";
            this.SearchClientMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchClientMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchClientMetroTextBox.CustomButton.TabIndex = 1;
            this.SearchClientMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchClientMetroTextBox.CustomButton.UseSelectable = true;
            this.SearchClientMetroTextBox.CustomButton.Visible = false;
            this.SearchClientMetroTextBox.Lines = new string[0];
            this.SearchClientMetroTextBox.Location = new System.Drawing.Point(423, 57);
            this.SearchClientMetroTextBox.MaxLength = 32767;
            this.SearchClientMetroTextBox.Name = "SearchClientMetroTextBox";
            this.SearchClientMetroTextBox.PasswordChar = '\0';
            this.SearchClientMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchClientMetroTextBox.SelectedText = "";
            this.SearchClientMetroTextBox.SelectionLength = 0;
            this.SearchClientMetroTextBox.SelectionStart = 0;
            this.SearchClientMetroTextBox.ShortcutsEnabled = true;
            this.SearchClientMetroTextBox.Size = new System.Drawing.Size(166, 23);
            this.SearchClientMetroTextBox.TabIndex = 95;
            this.SearchClientMetroTextBox.UseSelectable = true;
            this.SearchClientMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchClientMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ClientsMetroGrid
            // 
            this.ClientsMetroGrid.AllowUserToAddRows = false;
            this.ClientsMetroGrid.AllowUserToDeleteRows = false;
            this.ClientsMetroGrid.AllowUserToOrderColumns = true;
            this.ClientsMetroGrid.AllowUserToResizeRows = false;
            this.ClientsMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientsMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientsMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientsMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientsMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.LastNameColumn,
            this.AddressColumn,
            this.PhoneColumn,
            this.EmailColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientsMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClientsMetroGrid.EnableHeadersVisualStyles = false;
            this.ClientsMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClientsMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientsMetroGrid.Location = new System.Drawing.Point(21, 86);
            this.ClientsMetroGrid.Name = "ClientsMetroGrid";
            this.ClientsMetroGrid.ReadOnly = true;
            this.ClientsMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientsMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ClientsMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ClientsMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsMetroGrid.Size = new System.Drawing.Size(640, 353);
            this.ClientsMetroGrid.TabIndex = 98;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.HeaderText = "Last Name";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.HeaderText = "Phone";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.ReadOnly = true;
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.ClientsMetroGrid);
            this.Controls.Add(this.SearchMetroButton);
            this.Controls.Add(this.SearchUserMetroLabel);
            this.Controls.Add(this.SearchClientMetroTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaCliente";
            this.Resizable = false;
            this.Text = "The Dark Uniforms - Busqueda de Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultaCliente_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsMetroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton SearchMetroButton;
        private MetroFramework.Controls.MetroLabel SearchUserMetroLabel;
        private MetroFramework.Controls.MetroTextBox SearchClientMetroTextBox;
        private MetroFramework.Controls.MetroGrid ClientsMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
    }
}