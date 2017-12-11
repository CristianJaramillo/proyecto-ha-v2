namespace Proyecto_BD_HA_V2
{
    partial class AdministradorClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorClientes));
            this.NewClientMetroTile = new MetroFramework.Controls.MetroTile();
            this.DeleteClientMetroTile = new MetroFramework.Controls.MetroTile();
            this.UpdateClientMetroTile = new MetroFramework.Controls.MetroTile();
            this.SearchClientMetroTile = new MetroFramework.Controls.MetroTile();
            this.ShowUsersMetroTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // NewClientMetroTile
            // 
            this.NewClientMetroTile.ActiveControl = null;
            this.NewClientMetroTile.Location = new System.Drawing.Point(23, 101);
            this.NewClientMetroTile.Name = "NewClientMetroTile";
            this.NewClientMetroTile.Size = new System.Drawing.Size(371, 142);
            this.NewClientMetroTile.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewClientMetroTile.TabIndex = 111;
            this.NewClientMetroTile.Text = "Nuevo Cliente";
            this.NewClientMetroTile.UseSelectable = true;
            this.NewClientMetroTile.Click += new System.EventHandler(this.NewClientMetroTile_Click);
            // 
            // DeleteClientMetroTile
            // 
            this.DeleteClientMetroTile.ActiveControl = null;
            this.DeleteClientMetroTile.Location = new System.Drawing.Point(400, 101);
            this.DeleteClientMetroTile.Name = "DeleteClientMetroTile";
            this.DeleteClientMetroTile.Size = new System.Drawing.Size(257, 142);
            this.DeleteClientMetroTile.Style = MetroFramework.MetroColorStyle.Red;
            this.DeleteClientMetroTile.TabIndex = 112;
            this.DeleteClientMetroTile.Text = "Eliminar Cliente";
            this.DeleteClientMetroTile.UseSelectable = true;
            this.DeleteClientMetroTile.Click += new System.EventHandler(this.DeleteClientMetroTile_Click);
            // 
            // UpdateClientMetroTile
            // 
            this.UpdateClientMetroTile.ActiveControl = null;
            this.UpdateClientMetroTile.Location = new System.Drawing.Point(496, 249);
            this.UpdateClientMetroTile.Name = "UpdateClientMetroTile";
            this.UpdateClientMetroTile.Size = new System.Drawing.Size(161, 142);
            this.UpdateClientMetroTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.UpdateClientMetroTile.TabIndex = 114;
            this.UpdateClientMetroTile.Text = "Actualizar Cliente";
            this.UpdateClientMetroTile.UseSelectable = true;
            this.UpdateClientMetroTile.Click += new System.EventHandler(this.UpdateClientMetroTile_Click);
            // 
            // SearchClientMetroTile
            // 
            this.SearchClientMetroTile.ActiveControl = null;
            this.SearchClientMetroTile.Location = new System.Drawing.Point(268, 249);
            this.SearchClientMetroTile.Name = "SearchClientMetroTile";
            this.SearchClientMetroTile.Size = new System.Drawing.Size(222, 142);
            this.SearchClientMetroTile.Style = MetroFramework.MetroColorStyle.Green;
            this.SearchClientMetroTile.TabIndex = 113;
            this.SearchClientMetroTile.Text = "Buscar Cliente";
            this.SearchClientMetroTile.UseSelectable = true;
            this.SearchClientMetroTile.Click += new System.EventHandler(this.SearchClientMetroTile_Click);
            // 
            // ShowUsersMetroTile
            // 
            this.ShowUsersMetroTile.ActiveControl = null;
            this.ShowUsersMetroTile.Location = new System.Drawing.Point(23, 249);
            this.ShowUsersMetroTile.Name = "ShowUsersMetroTile";
            this.ShowUsersMetroTile.Size = new System.Drawing.Size(239, 142);
            this.ShowUsersMetroTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.ShowUsersMetroTile.TabIndex = 115;
            this.ShowUsersMetroTile.Text = "Visualizar Registros";
            this.ShowUsersMetroTile.UseSelectable = true;
            this.ShowUsersMetroTile.Click += new System.EventHandler(this.ShowUsersMetroTile_Click);
            // 
            // AdministradorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.ShowUsersMetroTile);
            this.Controls.Add(this.UpdateClientMetroTile);
            this.Controls.Add(this.SearchClientMetroTile);
            this.Controls.Add(this.DeleteClientMetroTile);
            this.Controls.Add(this.NewClientMetroTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdministradorClientes";
            this.Resizable = false;
            this.Text = "Administrador de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministradorClientes_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile NewClientMetroTile;
        private MetroFramework.Controls.MetroTile DeleteClientMetroTile;
        private MetroFramework.Controls.MetroTile UpdateClientMetroTile;
        private MetroFramework.Controls.MetroTile SearchClientMetroTile;
        private MetroFramework.Controls.MetroTile ShowUsersMetroTile;
    }
}