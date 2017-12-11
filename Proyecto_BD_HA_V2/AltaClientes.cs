using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using MetroFramework.Forms;
using System.Net.Mail;
using MetroFramework;
using Proyecto_BD_HA_V2.Store;

namespace Proyecto_BD_HA_V2
{
    public partial class AltaClientes : MetroForm
    {

#region
        private Form parent;
        #endregion


        private static string NAME_PATTER = "^([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\\']+[\\s])+([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\\'])+[\\s]?([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\\'])?$";
        private static string PHONE_PATTER = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
        private static string INSERT_CLIENT = "INSERT INTO cliente (Nombre, Apellidos, Direccion, Telefono, email) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";

        private string name;
        private string lastName;
        private string address;
        private string phone;
        private string email;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public AltaClientes(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AltaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterMetroButton_Click(object sender, EventArgs e)
        {
            if (!IsValidName()) return;
            if (!IsValidLastName()) return;
            if (!IsValidAddress()) return;
            if (!IsValidPhone()) return;
            if (!IsValidEmail()) return;

            var cmd = Connection.GetCommand(string.Format(INSERT_CLIENT, name, lastName, address, phone, email));
            var reader = cmd.ExecuteReader();
            Connection.Close();

            NameMetroTextBox.Text = name = string.Empty;
            LastNameMetroTextBox.Text = lastName = string.Empty;
            AddressMetroTextBox.Text = address = string.Empty;
            PhoneMetroTextBox.Text = phone = string.Empty;
            EmailMetroTextBox.Text = email = string.Empty;

            MetroMessageBox.Show(this, "Cliente registrado con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidName()
        {
            name = NameMetroTextBox.Text.Trim();
            lastName = LastNameMetroTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                NameErrorMetroLabel.Text = "El campo \"nombre\" es requerido";
                NameErrorMetroLabel.Visible = true;
            }
            else
            {
                NameErrorMetroLabel.Visible = false;
            }

            return !NameErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidLastName()
        {
            lastName = LastNameMetroTextBox.Text.Trim();

            if (string.IsNullOrEmpty(lastName))
            {
                LastNameErrorMetroLabel.Text = "El campo \"apellido\" es requerido";
                LastNameErrorMetroLabel.Visible = true;
            }
            else if (!Regex.IsMatch(name + " " + lastName, NAME_PATTER))
            {
                LastNameErrorMetroLabel.Text = "El campo \"apellido\" no es valido";
                LastNameErrorMetroLabel.Visible = true;
            }
            else
            {
                LastNameErrorMetroLabel.Visible = false;
            }

            return !LastNameErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidAddress()
        {
            address = AddressMetroTextBox.Text.Trim();

            if (string.IsNullOrEmpty(address))
            {
                AddressErrorMetroLabel.Text = "El campo \"dirección\" es requerido";
                AddressErrorMetroLabel.Visible = true;
            }
            else if (address.Length > 50)
            {
                AddressErrorMetroLabel.Text = "El campo \"dirección\" no puede ser mayor a 50 caracteres";
                AddressErrorMetroLabel.Visible = true;
            }
            else
            {
                AddressErrorMetroLabel.Visible = false;
            }

            return !AddressErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidEmail()
        {
            email = EmailMetroTextBox.Text.Trim();

            try
            {

                if (string.IsNullOrEmpty(email))
                {
                    EmailErrorMetroLabel.Text = "El campo \"correo electrónico\" es requerido";
                    EmailErrorMetroLabel.Visible = true;
                }
                else
                {
                    MailAddress mailAddres = new MailAddress(email);
                    EmailErrorMetroLabel.Visible = false;
                }
            }
            catch (FormatException)
            {
                EmailErrorMetroLabel.Text = "El campo \"correo electrónico\" es invalido!";
                EmailErrorMetroLabel.Visible = true;
            }


            return !EmailErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidPhone()
        {
            phone = PhoneMetroTextBox.Text.Trim();

            if (string.IsNullOrEmpty(phone))
            {
                PhoneErrorMetroLabel.Text = "El campo \"teléfono\" es requerido";
                PhoneErrorMetroLabel.Visible = true;
            }
            else if (!Regex.IsMatch(phone, PHONE_PATTER))
            {
                PhoneErrorMetroLabel.Text = "El campo \"teléfono\" no es valido";
                PhoneErrorMetroLabel.Visible = true;
            }
            else
            {
                PhoneErrorMetroLabel.Visible = false;
            }

            return !PhoneErrorMetroLabel.Visible;
        }

    }
}
