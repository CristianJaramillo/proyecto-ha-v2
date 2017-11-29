using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_BD_HA_V2
{
    public class Responsable : AbstractaRegistro
    {
        /// <summary>
        /// 
        /// </summary>
        public Responsable()
        {
//            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Nombre">Name</param>
        /// <param name="Alias">Username</param>
        /// <param name="Correo">Email</param>
        /// <param name="Password">Password</param>
        /// <param name="Puesto">Role</param>
        public Responsable(string Nombre, string Alias, string Correo, string Password, string Puesto)
        {
            this.Nombre = Nombre;
            this.Alias = Alias;
            this.Password = Password;
            this.Puesto = Puesto;
            this.Correo = Correo;
        }

        public Responsable(int idResponsable, string Nombre, string Password, string Puesto, string FechaIngreso, string HoraIngreso, string Correo)
        {
            this.idResponsable = idResponsable;
            this.Nombre = Nombre;
            this.Password = Password;
            this.Puesto = Puesto;
            this.FechaIngreso = FechaIngreso;
            this.HoraIngreso = HoraIngreso;
            this.Correo = Correo;
        }

        public int idResponsable { get; set; }

        public string Nombre { get; set; }

        public string Alias { get; set; }

        public string Password { get; set; }

        public string Puesto { get; set; }

        public string FechaIngreso { get; set; }

        public string HoraIngreso { get; set; }

        public string Correo { get; set; }
    }
}