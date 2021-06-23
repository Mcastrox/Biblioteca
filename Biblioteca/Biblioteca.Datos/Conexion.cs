﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "Biblioteca";
            this.Servidor = "DESKTOP-A5KN1DG"; // aqui poner ip si lo queremos remoto
            this.Usuario = "sa";
            this.Clave = "";//pass del server 
            this.Seguridad = true; //seguridad de windows

        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server="+this.Servidor+";Database="+this.Base+";";
                if (this.Seguridad) // seguridad de windows
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else // Seguridad de sql server
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
            
        }
        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();

            }
            return Con;
        }
    }
}
