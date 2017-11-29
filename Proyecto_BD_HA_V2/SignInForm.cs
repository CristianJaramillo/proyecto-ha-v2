using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// 
/// </summary>
namespace Proyecto_BD_HA_V2
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SignIn : MetroForm
    {

        private Form children;

        /// <summary>
        /// 
        /// </summary>
        public SignIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signUpMetroLink_Click(object sender, EventArgs e)
        {
            children = new AltaUsuario(this);
            children.Show();
            children.Top = (Screen.PrimaryScreen.WorkingArea.Height - children.Height) / 2;
            children.Left = (Screen.PrimaryScreen.WorkingArea.Width - children.Width) / 2;
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignInMetroButton_Click(object sender, EventArgs e)
        {
            if (!IsValidUsername())
            {
                return;
            }

            if (!IsValidPassword())
            {
                return;
            }

            string username = usernameMetroTextBox.Text;
            string password = passwordMetroTextBox.Text;

            usernameMetroTextBox.Clear();
            passwordMetroTextBox.Clear();
            

            DataTable dataTable = TablaUsuario.Buscar(username, password);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                string role = Convert.ToString(row["puesto"]);
                string userId = Convert.ToString(row["idResponsable"]);

                switch (role)
                {
                    case "Gerente":
                        Hide();
                        children = new MenuGerente(this);
                        TablaUsuario.Actualhora(username, password);
                        ((MenuGerente)children).Recibir(userId);
                        children.Show();
                        break;
                    case "Almacenista":
                        Hide();
                        children = new MenuAlmacenista(this);
                        TablaUsuario.Actualhora(username, password);
                        ((MenuAlmacenista)children).Recibir(userId);
                        children.Show();
                        break;
                    case "Vendedor":
                        Hide();
                        children = new MenuVendedor(this);
                        TablaUsuario.Actualhora(username, password);
                        ((MenuVendedor)children).Recibir(userId);
                        children.Show();
                        break;
                    default:
                        MetroMessageBox.Show(this, "Cargo \"" + role + "\" invalido!", this.Text + "- Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

            }
            else {
                MetroMessageBox.Show(this, "Usuario ó contraseña invalidos!", this.Text + "- Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidUsername()
        {
            string username = usernameMetroTextBox.Text;

            if (string.IsNullOrEmpty(username))
            {
                usernameErrorMetroLabel.Text = "El campo \"Usuario\" es requerido";
                usernameErrorMetroLabel.Visible = true;
            }
            else
            {
                usernameErrorMetroLabel.Visible = false;
            }

            return !usernameErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidPassword()
        {

            string password = passwordMetroTextBox.Text;

            if (string.IsNullOrEmpty(password))
            {
                passwordErrorMetroLabel.Text = "El campo \"Contraseña\" es requerido";
                passwordErrorMetroLabel.Visible = true;
            }
            else
            {
                passwordErrorMetroLabel.Visible = false;
            }

            return !passwordErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignIn_Load(object sender, EventArgs e)
        {
            passwordMetroTextBox.PasswordChar = '\u2022';
        }
    }
}
