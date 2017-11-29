namespace Proyecto_BD_HA_V2
{
    partial class AdministradorUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorUsuario));
            this.createMetroTile = new MetroFramework.Controls.MetroTile();
            this.updateMetroTile = new MetroFramework.Controls.MetroTile();
            this.deleteMetroTile = new MetroFramework.Controls.MetroTile();
            this.SearchMetroTile = new MetroFramework.Controls.MetroTile();
            this.ShowUsersMetroTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // createMetroTile
            // 
            this.createMetroTile.ActiveControl = null;
            this.createMetroTile.Location = new System.Drawing.Point(23, 63);
            this.createMetroTile.Name = "createMetroTile";
            this.createMetroTile.Size = new System.Drawing.Size(171, 185);
            this.createMetroTile.Style = MetroFramework.MetroColorStyle.Green;
            this.createMetroTile.TabIndex = 101;
            this.createMetroTile.Text = "Crear Usuario";
            this.createMetroTile.UseSelectable = true;
            this.createMetroTile.Click += new System.EventHandler(this.createMetroTile_Click);
            // 
            // updateMetroTile
            // 
            this.updateMetroTile.ActiveControl = null;
            this.updateMetroTile.Location = new System.Drawing.Point(200, 63);
            this.updateMetroTile.Name = "updateMetroTile";
            this.updateMetroTile.Size = new System.Drawing.Size(457, 98);
            this.updateMetroTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.updateMetroTile.TabIndex = 102;
            this.updateMetroTile.Text = "Modificar Usuario";
            this.updateMetroTile.UseSelectable = true;
            this.updateMetroTile.Click += new System.EventHandler(this.updateMetroTile_Click);
            // 
            // deleteMetroTile
            // 
            this.deleteMetroTile.ActiveControl = null;
            this.deleteMetroTile.Location = new System.Drawing.Point(200, 167);
            this.deleteMetroTile.Name = "deleteMetroTile";
            this.deleteMetroTile.Size = new System.Drawing.Size(457, 81);
            this.deleteMetroTile.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteMetroTile.TabIndex = 103;
            this.deleteMetroTile.Text = "Eliminar Usuario";
            this.deleteMetroTile.UseSelectable = true;
            this.deleteMetroTile.Click += new System.EventHandler(this.deleteMetroTile_Click);
            // 
            // SearchMetroTile
            // 
            this.SearchMetroTile.ActiveControl = null;
            this.SearchMetroTile.Location = new System.Drawing.Point(348, 254);
            this.SearchMetroTile.Name = "SearchMetroTile";
            this.SearchMetroTile.Size = new System.Drawing.Size(309, 146);
            this.SearchMetroTile.TabIndex = 104;
            this.SearchMetroTile.Text = "Busqueda de Usuario";
            this.SearchMetroTile.UseSelectable = true;
            this.SearchMetroTile.Click += new System.EventHandler(this.SearchMetroTile_Click);
            // 
            // ShowUsersMetroTile
            // 
            this.ShowUsersMetroTile.ActiveControl = null;
            this.ShowUsersMetroTile.Location = new System.Drawing.Point(23, 254);
            this.ShowUsersMetroTile.Name = "ShowUsersMetroTile";
            this.ShowUsersMetroTile.Size = new System.Drawing.Size(319, 146);
            this.ShowUsersMetroTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.ShowUsersMetroTile.TabIndex = 105;
            this.ShowUsersMetroTile.Text = "Visualizar Registros";
            this.ShowUsersMetroTile.UseSelectable = true;
            this.ShowUsersMetroTile.Click += new System.EventHandler(this.ShowUsersMetroTile_Click);
            // 
            // AdministradorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.ShowUsersMetroTile);
            this.Controls.Add(this.SearchMetroTile);
            this.Controls.Add(this.deleteMetroTile);
            this.Controls.Add(this.updateMetroTile);
            this.Controls.Add(this.createMetroTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdministradorUsuario";
            this.Resizable = false;
            this.Text = "Administrador de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministradorUsuario_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile createMetroTile;
        private MetroFramework.Controls.MetroTile updateMetroTile;
        private MetroFramework.Controls.MetroTile deleteMetroTile;
        private MetroFramework.Controls.MetroTile SearchMetroTile;
        private MetroFramework.Controls.MetroTile ShowUsersMetroTile;
    }
}