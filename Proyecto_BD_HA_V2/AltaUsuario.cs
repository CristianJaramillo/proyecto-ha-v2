using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Globalization;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_BD_HA_V2
{
    public partial class AltaUsuario : MetroForm
    {

        private Form parent;

        private static string NAME_PATTER = "^([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\\']+[\\s])+([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\\'])+[\\s]?([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\\'])?$";
        private static string USERNAME_PATTER = "^[a-zA-Z][_\\-a-zA-Z0-9]{5,11}$";
        private static string PASSWORD_PATTER = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$";

        private string name;
        private string username;
        private string email;
        private string emailConfirm;
        private string password;
        private string passwordConfirm;
        private string role;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public AltaUsuario(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            passwordMetroTextBox.PasswordChar = '\u2022';
            passwordConfirmMetroTextBox.PasswordChar = '\u2022';
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AltaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelMetroButton_Click(object sender, EventArgs e)
        {
            Hide();
            parent.Show();
            parent.Top = (Screen.PrimaryScreen.WorkingArea.Height - parent.Height) / 2;
            parent.Left = (Screen.PrimaryScreen.WorkingArea.Width - parent.Width) / 2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveMetroButton_Click(object sender, EventArgs e)
        {
            if (!IsValidName())
            {
                return;
            }

            if (!IsValidUsername())
            {
                return;
            }

            if (!IsValidEmail())
            {
                return;
            }

            if (!IsValidEmailConfirm())
            {
                return;
            }

            if (!IsValidPassword())
            {
                return;
            }

            if (!IsValidPasswordConfirm())
            {
                return;
            }

            if (!IsValidRole())
            {
                return;
            }



            int resultado = TablaUsuario.AgregarUsuario(new Responsable(name, username, email, password, role));

            if (resultado > 0)
            {
                MetroMessageBox.Show(this, "Usuario registrado con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, "El usuario ya existe!", this.Text + "- Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            name = nameMetroTextBox.Text = string.Empty;
            username = usernameMetroTextBox.Text = string.Empty;
            email = emailMetroTextBox.Text = string.Empty;
            emailConfirm = emailConfirmMetroTextBox.Text = string.Empty;
            password = passwordConfirmMetroTextBox.Text = string.Empty;
            role = roleMetroComboBox.Text = string.Empty;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidName()
        {
            name = nameMetroTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                nameErrorMetroLabel.Text = "El campo \"nombre\" es requerido";
                nameErrorMetroLabel.Visible = true;
            }
            else if (!Regex.IsMatch(name, NAME_PATTER))
            {
                nameErrorMetroLabel.Text = "El campo \"nombre\" no es valido";
                nameErrorMetroLabel.Visible = true;
            }
            else
            {
                nameErrorMetroLabel.Visible = false;
            }

            return !nameErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidUsername()
        {
            username = usernameMetroTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                usernameErrorMetroLabel.Text = "El campo \"usuario\" es requerido";
                usernameErrorMetroLabel.Visible = true;
            }
            else if (!Regex.IsMatch(username, USERNAME_PATTER))
            {
                usernameErrorMetroLabel.Text = "El campo \"usuario\" es invalido";
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
        private bool IsValidEmail()
        {
            email = emailMetroTextBox.Text.Trim();
            
            try
            {

                if (string.IsNullOrEmpty(email))
                {
                    emailErrorMetroLabel.Text = "El campo \"correo electrónico\" es requerido";
                    emailErrorMetroLabel.Visible = true;
                }
                else {
                    MailAddress mailAddres = new MailAddress(email);
                    emailErrorMetroLabel.Visible = false;
                }
            }
            catch (FormatException)
            {
                emailErrorMetroLabel.Text = "El campo \"correo electrónico\" es invalido!";
                emailErrorMetroLabel.Visible = true;
            }
            

            return !emailErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidEmailConfirm()
        {
            emailConfirm = emailConfirmMetroTextBox.Text.Trim();

            if (!emailConfirm.Equals(email))
            {
                emailConfirmErrorMetroLabel.Text = "El \"correo electrónico\" no coincide!";
                emailConfirmErrorMetroLabel.Visible = true;
            }
            else
            {
                emailConfirmErrorMetroLabel.Visible = false;
            }

            return !emailConfirmErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidPassword()
        {

            password = passwordMetroTextBox.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                passwordErrorMetroLabel.Text = "El campo \"contraseña\" es requerido";
                passwordErrorMetroLabel.Visible = true;
            }
            else if (!Regex.IsMatch(password, PASSWORD_PATTER))
            {
                passwordErrorMetroLabel.Text = "El campo \"contraseña\" es invalida";
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
        /// <returns></returns>
        private bool IsValidPasswordConfirm()
        {
            passwordConfirm = passwordConfirmMetroTextBox.Text.Trim();

            if (!passwordConfirm.Equals(password))
            {
                passwordConfirmErrorMetroLabel.Text = "El campo \"contraseña\" no coincide";
                passwordConfirmErrorMetroLabel.Visible = true;
            }
            else
            {
                passwordConfirmErrorMetroLabel.Visible = false;
            }

            return !passwordConfirmErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidRole()
        {
            role = roleMetroComboBox.Text.Trim();

            if (string.IsNullOrEmpty(role))
            {
                roleErrorMetroLabel.Text = "El campo \"role\" es requerido";
                roleErrorMetroLabel.Visible = true;
            }
            else
            {
                roleErrorMetroLabel.Visible = false;
            }

            return !roleErrorMetroLabel.Visible;
        }


    }
}
