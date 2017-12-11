namespace Proyecto_BD_HA_V2
{
    partial class ConsultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaUsuario));
            this.SearchUserMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SearchUserMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.SearchMetroButton = new MetroFramework.Controls.MetroButton();
            this.UpdateAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersMetroGrid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.UsersMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchUserMetroTextBox
            // 
            // 
            // 
            // 
            this.SearchUserMetroTextBox.CustomButton.Image = null;
            this.SearchUserMetroTextBox.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.SearchUserMetroTextBox.CustomButton.Name = "";
            this.SearchUserMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchUserMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchUserMetroTextBox.CustomButton.TabIndex = 1;
            this.SearchUserMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchUserMetroTextBox.CustomButton.UseSelectable = true;
            this.SearchUserMetroTextBox.CustomButton.Visible = false;
            this.SearchUserMetroTextBox.Lines = new string[0];
            this.SearchUserMetroTextBox.Location = new System.Drawing.Point(355, 63);
            this.SearchUserMetroTextBox.MaxLength = 32767;
            this.SearchUserMetroTextBox.Name = "SearchUserMetroTextBox";
            this.SearchUserMetroTextBox.PasswordChar = '\0';
            this.SearchUserMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchUserMetroTextBox.SelectedText = "";
            this.SearchUserMetroTextBox.SelectionLength = 0;
            this.SearchUserMetroTextBox.SelectionStart = 0;
            this.SearchUserMetroTextBox.ShortcutsEnabled = true;
            this.SearchUserMetroTextBox.Size = new System.Drawing.Size(200, 23);
            this.SearchUserMetroTextBox.TabIndex = 91;
            this.SearchUserMetroTextBox.UseSelectable = true;
            this.SearchUserMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchUserMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchUserMetroLabel
            // 
            this.SearchUserMetroLabel.AutoSize = true;
            this.SearchUserMetroLabel.Location = new System.Drawing.Point(264, 63);
            this.SearchUserMetroLabel.Name = "SearchUserMetroLabel";
            this.SearchUserMetroLabel.Size = new System.Drawing.Size(85, 19);
            this.SearchUserMetroLabel.TabIndex = 92;
            this.SearchUserMetroLabel.Text = "Ingrese un ID";
            // 
            // SearchMetroButton
            // 
            this.SearchMetroButton.Location = new System.Drawing.Point(561, 63);
            this.SearchMetroButton.Name = "SearchMetroButton";
            this.SearchMetroButton.Size = new System.Drawing.Size(100, 23);
            this.SearchMetroButton.TabIndex = 93;
            this.SearchMetroButton.Text = "Buscar";
            this.SearchMetroButton.UseSelectable = true;
            this.SearchMetroButton.Click += new System.EventHandler(this.SearchMetroButton_Click);
            // 
            // UpdateAtColumn
            // 
            this.UpdateAtColumn.HeaderText = "Fecha de Actualización";
            this.UpdateAtColumn.Name = "UpdateAtColumn";
            this.UpdateAtColumn.ReadOnly = true;
            // 
            // CreateAtColumn
            // 
            this.CreateAtColumn.HeaderText = "Fecha de Creación";
            this.CreateAtColumn.Name = "CreateAtColumn";
            this.CreateAtColumn.ReadOnly = true;
            // 
            // RoleColumn
            // 
            this.RoleColumn.HeaderText = "Cargo";
            this.RoleColumn.Name = "RoleColumn";
            this.RoleColumn.ReadOnly = true;
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "Correo Electrónico";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.HeaderText = "Username";
            this.UsernameColumn.Name = "UsernameColumn";
            this.UsernameColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // UsersMetroGrid
            // 
            this.UsersMetroGrid.AllowUserToAddRows = false;
            this.UsersMetroGrid.AllowUserToDeleteRows = false;
            this.UsersMetroGrid.AllowUserToOrderColumns = true;
            this.UsersMetroGrid.AllowUserToResizeRows = false;
            this.UsersMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UsersMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UsersMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.UsernameColumn,
            this.EmailColumn,
            this.RoleColumn,
            this.CreateAtColumn,
            this.UpdateAtColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UsersMetroGrid.EnableHeadersVisualStyles = false;
            this.UsersMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsersMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UsersMetroGrid.Location = new System.Drawing.Point(17, 92);
            this.UsersMetroGrid.Name = "UsersMetroGrid";
            this.UsersMetroGrid.ReadOnly = true;
            this.UsersMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UsersMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersMetroGrid.Size = new System.Drawing.Size(644, 353);
            this.UsersMetroGrid.TabIndex = 94;
            // 
            // ConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.UsersMetroGrid);
            this.Controls.Add(this.SearchMetroButton);
            this.Controls.Add(this.SearchUserMetroLabel);
            this.Controls.Add(this.SearchUserMetroTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaUsuario";
            this.Resizable = false;
            this.Text = "The Dark Uniforms - Busqueda de Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultaUsuario_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UsersMetroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox SearchUserMetroTextBox;
        private MetroFramework.Controls.MetroLabel SearchUserMetroLabel;
        private MetroFramework.Controls.MetroButton SearchMetroButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateAtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateAtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private MetroFramework.Controls.MetroGrid UsersMetroGrid;
    }
}